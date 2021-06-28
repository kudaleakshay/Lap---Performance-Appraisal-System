/*   Started Report tables    */

use DocPAS
go

/* Department 1 - Establishment */

Create table Report11(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Inquiry_C int,
Inquiry_D int,
Inquiry_Total int,
Inquiry_Target_C int,
Inquiry_Target_D int,
Inquiry_Total_Target int,
Inquiry_Achieved_C int,
Inquiry_Achieved_D int,
Inquiry_Total_Achieved int,
Inquiry_Remaining_C int,
Inquiry_Remaining_D int,
Inquiry_Total_Remaining int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go




Create table Report12(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Officer_Count int,
Retired_Officer_Count int,
Retirement_Benefits_Target int,
Retirement_Benefits_Achieved int,
Retirement_Benefits_Pendig int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks nvarchar(500))
go




Create table Report13(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Service_Books_Total int,
Service_Books_Updation_Target int,
Service_Books_Updation_Achieved int,
Service_Books_Updation_Pending int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks nvarchar(500))
go




Create table Report14(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Available_Applications int,
Current_Month_Aim int,
Last_Month_Classification_Achieved int,
Current_Month_Classification_Achieved int,
Total_Classification_Achieved int,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report15(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Pending_Inspection_Count int,
Submitted_Compliance int,
Accepted_Compliance int,
Target int,
Pending_Paragraph_Count int,
Current_Month_Aim int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go




Create table Report16(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Cases_Target int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go




/* Department 2 - Krushipat */


Create table Report17(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Loan_Allocation_Target float,
Last_Month_Loan_Allocation float,
Current_Month_Loan_Allocation float,
Total_Loan_Allocation float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go





Create table Report18(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Loan_Allocation_Target float,
Last_Month_Loan_Allocation float,
Current_Month_Loan_Allocation float,
Total_Loan_Allocation float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report23(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Eligible_Members_Aim int,
Last_Month_Members_Increase  int,
Current_Month_Members_Increase int,
Total_Members int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



/* Department 3 - IT */

Create table Report24(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Aim int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
Remarks varchar(500),
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int)
go



Create table Report25(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Aim int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
Remarks varchar(500),
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int)
go



Create table Report26(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Aim int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
Remarks varchar(500),
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int)
go



Create table Report27(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Aim int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
Remarks varchar(500),
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int)
go



Create table Report28(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Aim int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
Remarks varchar(500),
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int)
go


Create table Report29(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
CM_Last_Month_Pending_Complaints int,
CM_Current_Month_Received_Complaints int,
CM_Total_Complaints int,
CM_Current_Month_Resolved_Complaints int,
CM_Pending_Complaints int,
PM_Last_Month_Pending_Complaints int,
PM_Current_Month_Received_Complaints int,
PM_Total_Complaints int,
PM_Current_Month_Resolved_Complaints int,
PM_Pending_Complaints int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



/* Department 4 - Budget */

Create table Report30(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
BDS_Funds_Aim float,
Last_Month_Achieved_Expenses float,
Current_Month_Achieved_Expenses float,
Total_Expenses float,
Balance_Amount float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report31(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Aim int,
Last_Month_Report_Submitted int,
Current_Month_Report_Submitted int,
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))




Create table Report34(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Yearly_Recovery_Aim int,
Last_Month_Recovery int,
Current_Month_Recovery int,
Total_Recovery int,
Appraisal_Percentage float,
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))



/* Department 5 - Audit */

Create table Report35(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Total_Target int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Appraisal_Percentage float,
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report36(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Eligible_for_Audit int,
Current_Month_Audit int,
Current_Month_Remaining_for_Audit int,
Action_Taken int,
Percentage_Action_Taken float,
Marks_Action_Taken float,
Appraisal_Percentage float,
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report37(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Year_Pending int,
Last_Month_Reports int,
Current_Month_Reports int,
Total_Reports int,
Last_Month_Action_Taken int,
Current_Month_Action_Taken int,
Total_Action_Taken int,
Action_Pending_Reports int,
Percentage_Action_Taken float,
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report38(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Year_Pending int,
Last_Month_Reports int,
Current_Month_Reports int,
Total_Reports int,
Last_Month_Action_Taken int,
Current_Month_Action_Taken int,
Total_Action_Taken int,
Action_Pending_Reports int,
Percentage_Action_Taken float,
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report39(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Year_Remaining int,
Last_Month_Remaining int,
Current_Month_Remaining int,
Total_Remaining int,
Last_Month_Action_Taken int,
Current_Month_Action_Taken int,
Total_Action_Taken int,
Action_Pending_Reports int,
Percentage_Action_Taken float,
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report40(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Year_Received int,
Last_Month_Received int,
Current_Month_Received int,
Total_Received int,
Last_Month_Action_Taken int,
Current_Month_Action_Taken int,
Total_Action_Taken int,
Action_Pending_Reports int,
Percentage_Action_Taken float,
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



/* Department 6 - Law */

Create table Report41(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Society_Cancellation int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report42(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Society_Cancellation int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int, 
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report43(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Aim int,
Last_Month_Remaining int,
Current_Month_Achieved int,
Total_Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report44(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Aim1 int,
Aim2 int,
Total_Annual_Aim int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report45(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Annual_aim int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))



Create table Report46(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Month_Received_Cases int,
Current_Month_Received_Cases int,
Total_Cases int,
Target int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report47(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Month_Received_Cases int,
Current_Month_Received_Cases int,
Total_Cases int,
Target int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report48(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Month_Received_Cases int,
Current_Month_Received_Cases int,
Total_Cases int,
Target int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report49(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Month_Received_Cases int,
Current_Month_Received_Cases int,
Total_Cases int,
Target int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report50(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Month_Received_Cases int,
Current_Month_Received_Cases int,
Total_Cases int,
Target int,
Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go




/* Department 7 - Housing */

Create table Report51(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Month_Pending_Cases int,
Current_Month_Received_Cases int,
Total_Cases int,
Last_Month_Cases_Aim int,
Current_Month_Cases_Aim int,
Total_Cases_Aim int,
Last_Month_Disposed_Cases int,
Current_Month_Disposed_Cases int,
Total_Disposed_Cases int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report52  (
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Last_Month_Pending_Cases int,
Current_Month_Received_Cases int,
Total_Cases int,
Last_Month_Cases_Aim int,
Current_Month_Cases_Aim int,
Total_Cases_Aim int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



/* Department 8 - Credit Societies */

Create table Report53( 
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Annual_Target int,
Total_Achieved int,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report54(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Annual_Target int,
Total_Achieved int,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report56(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Annual_Target int,
Current_Month_Aim_Count int,
Current_Month_Aim_Amount float,
Last_Month_Achieved_Count int,
Last_Month_Achieved_Amount float,
Current_Month_Achieved_Count int,
Current_Month_Achieved_Amount float,
Total_Count int,
Total_Amount float,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report57(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Annual_Target int,
Current_Month_Aim_Count int,
Current_Month_Aim_Amount float,
Last_Month_Achieved_Count int,
Last_Month_Achieved_Amount float,
Current_Month_Achieved_Count int,
Current_Month_Achieved_Amount float,
Total_Count int,
Total_Amount float,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report58(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Annual_Target int,
Current_Month_Aim_Count int,
Current_Month_Aim_Amount float,
Last_Month_Achieved_Count int,
Last_Month_Achieved_Amount float,
Current_Month_Achieved_Count int,
Current_Month_Achieved_Amount float,
Total_Count int,
Total_Amount float,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report59(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Annual_Target int,
Current_Month_Aim_Count int,
Current_Month_Aim_Amount float,
Last_Month_Achieved_Count int,
Last_Month_Achieved_Amount float,
Current_Month_Achieved_Count int,
Current_Month_Achieved_Amount float,
Total_Count int,
Total_Amount float,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


/* Department 9 - O and M */

Create table Report60(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Officer_Count int,
Staff_Count int,
Total_Staff int,
Officer_Target int,
Staff_Target int,
Total_Target int,
Current_Month_Aim int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report61(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Total_Target int,
Current_Month_Aim int,
Last_Month_Achieved int,
Current_Month_Achieved int,
Total_Achieved int,
Current_Month_Percentage float,
Appraisal_Marks float,
Appraisal_Percentage float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



/* Department 10 - Money Lending*/

Create table Report62(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Total_Complaint int,
Resolved_Complaint int,
Resolved_Percentage float, 
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go


Create table Report63(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Total_Application int,
Resolved_Application int,
Resolved_Percentage float, 
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go



Create table Report64(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Total_Appeal int,
Resolved_Appeal int,
Resolved_Percentage float, 
Appraisal_Marks float,
NotApplicable Bit DEFAULT 0 NOT NULL,
Month int,
Year int,
CreatedTime DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
Remarks varchar(500))
go
