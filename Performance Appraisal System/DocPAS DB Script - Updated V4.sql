use DocPAS
go

ALTER TABLE [DocPAS].[dbo].[Report34]
ALTER COLUMN Yearly_Recovery_Aim float;
go


ALTER TABLE [DocPAS].[dbo].[Report34]
ALTER COLUMN Last_Month_Recovery float;
go


ALTER TABLE [DocPAS].[dbo].[Report34]
ALTER COLUMN Current_Month_Recovery float;
go

ALTER TABLE [DocPAS].[dbo].[Report34]
ALTER COLUMN Total_Recovery float;
go


Update [DocPAS].[dbo].[Users]
  SET RoleId =1
  where UserName = 'admin';
  go



use DocPAS
go

drop trigger [dbo].[DepartmentMasterReports_Entry]
drop trigger [dbo].[Get_Appraisal_Percentage]

SELECT * FROM [sys].[triggers]