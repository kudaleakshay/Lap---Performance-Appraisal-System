
use DocPAS
go

CREATE TRIGGER [dbo].[Insert_Appraisal_Type] ON [DocPAS].[dbo].[Districts]
AFTER INSERT, UPDATE
AS
BEGIN

Declare @iId as int;
Declare @iAType as int;

Select 
  @iId = i.Id,
  @iAType = i.AppraisalType

From inserted i;

Update [Users] 
    SET AppraisalType = @iAType
WHERE
    DistrictId = @iId

END
go


CREATE TRIGGER [dbo].[Department_Marks_Mapping] ON [DocPAS].[dbo].[Subjects_MarksMapping]
AFTER INSERT, UPDATE
AS
BEGIN

Declare @iSId as int;
Declare @iDepartmentId as int;
Declare @iAType as int;
Declare @iMarks as float;

Select 
  @iSId = i.SId,
  @iAType = i.AType,
  @iMarks = i.Marks,
  @iDepartmentId= (select [DepartmentId] from [DocPAS].[dbo].[Subjects] where [SId] = i.SId)

From inserted i;


IF EXISTS (select [AType],[Marks] from [DocPAS].[dbo].[Departments_MarksMapping] where [DId] = @iDepartmentId and [AType] = @iAType) 
BEGIN
Update [Departments_MarksMapping] 
    SET [Marks] = [Marks]+ @iMarks
WHERE
    [DId] = @iDepartmentId AND
    [AType] = @iAType
END
ELSE 
BEGIN
INSERT INTO [Departments_MarksMapping] ([DId],[AType],[Marks]) Values (@iDepartmentId,@iAType,@iMarks)
END
END
go


CREATE TRIGGER [dbo].[DepartmentMasterReports_Entry] ON [DocPAS].[dbo].[SubMasterReports]
AFTER INSERT
AS
BEGIN

Declare @dDepartment as int;
Declare @iTotal as float;
Declare @iApppraisalMarks as float;
Declare @iUId as int;
Declare @iMonth as int;
Declare @iYear as int;
Declare @iNot_Applicable_Marks as float;
Declare @iAType as int;

Select 
  @dDepartment = i.[DepartmentId],
  @iApppraisalMarks = i.[Appraisal_Marks],
  @iUId = i.[UId],
  @iMonth = i.[Month],
  @iYear = i.[Year],
  @iNot_Applicable_Marks = i.Not_Applicable_Marks,
  @iAType = (select [AppraisalType] from Users where [UId] = i.[UId]),
  @iTotal = (Select [Marks] from [Departments_MarksMapping] where [DId] = i.[DepartmentId] and [AType] = (select [AppraisalType] from Users where [UId] = i.[UId]))

From inserted i;


IF EXISTS (Select [Appraisal_Marks],[Total_Marks] from [DepartmentMasterReports] where [DepartmentId] = @dDepartment 
                                      AND [Year]= @iYear 
                                      AND [Month] = @iMonth
                                      AND [UId] = @iUId) 
BEGIN
  IF (@iNot_Applicable_Marks IS NULL ) 
  BEGIN
  Update [DepartmentMasterReports] 
    SET Appraisal_Marks = Appraisal_Marks + @iApppraisalMarks,
    Not_Applicable_Marks = Not_Applicable_Marks,
    Total_Marks = (@iTotal)
  WHERE
    [DepartmentId] = @dDepartment
    AND [Year]= @iYear 
    AND [Month] = @iMonth
    AND [UId] = @iUId
  END
  ELSE
  BEGIN
  Update [DepartmentMasterReports] 
    SET Appraisal_Marks = Appraisal_Marks + @iApppraisalMarks,
	Not_Applicable_Marks = Not_Applicable_Marks + @iNot_Applicable_Marks,
    Total_Marks = (@iTotal)
  WHERE
      [DepartmentId] = @dDepartment
    AND [Year]= @iYear 
    AND [Month] = @iMonth
    AND [UId] = @iUId
  END

END
ELSE 
BEGIN
 IF (@iNot_Applicable_Marks IS NULL ) 
  BEGIN
		INSERT INTO [DepartmentMasterReports] ([UId],[DepartmentId],[Year],[Month],[Appraisal_Marks],[Total_Marks],[Not_Applicable_Marks]) Values (@iUId,@dDepartment,@iYear,@iMonth,@iApppraisalMarks,@iTotal,0)
  END
  Else
  BEGIN
		INSERT INTO [DepartmentMasterReports] ([UId],[DepartmentId],[Year],[Month],[Appraisal_Marks],[Total_Marks],[Not_Applicable_Marks]) Values (@iUId,@dDepartment,@iYear,@iMonth,@iApppraisalMarks,@iTotal,@iNot_Applicable_Marks)
  END
END
END
go


CREATE TRIGGER [dbo].[Get_Appraisal_Percentage] ON [DocPAS].[dbo].[DepartmentMasterReports]
AFTER INSERT, UPDATE
AS
BEGIN

Declare @iAMarks as float;
Declare @iTotal as float;
Declare @dDepartment as int;
Declare @iUId as int;
Declare @iMonth as int;
Declare @iYear as int;
Declare @iNotApplicable as float;

Select 
  @iAMarks = i.Appraisal_Marks,
  @iTotal = i.Total_Marks,
  @iNotApplicable = i.Not_Applicable_Marks,
  @dDepartment = i.[DepartmentId],
  @iUId = i.[UId],
  @iMonth = i.[Month],
  @iYear = i.[Year]
  
From inserted i;

Update DepartmentMasterReports
    SET Appraisal_Percentage = round((@iAMarks* 100) / (@iTotal-@iNotApplicable),2)
Where
	[DepartmentId] = @dDepartment
    AND [Year]= @iYear 
    AND [Month] = @iMonth
    AND [UId] = @iUId

END
go