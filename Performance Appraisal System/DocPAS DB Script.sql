create database DocPAS
go

use DocPAS
go

create table Departments(
Id int primary key identity(1,1),
DepartmentName nvarchar(200))
go

create table Roles(
Id int primary key identity(1,1),
RoleName varchar(40))
go

create table Divisions(
Id int primary key identity(1,1),
DivisionName nvarchar(200))
go

create table Districts(
Id int primary key identity(1,1),
DistrictName nvarchar(200),
DivisionId int references Divisions(Id) on delete set null,
AppraisalType int)
go


create table Subjects(
SId int primary key identity(1,1),
SubjectName nvarchar(500),
DepartmentId int references Departments(Id) on delete set null,
Type int)
go

create table Users(
UId int primary key identity(1,1),
UserName varchar(40),
Name nvarchar(200),
Email nvarchar(50),
Password varchar(40),
DivisionId int references Divisions(Id) on delete set null,
DistrictId int references Districts(Id) on delete set null,
RoleId int references Roles(Id) on delete set null,
Status int default 1,
AppraisalType int,
ReportTo int)
go



create table SubMasterReports(
Id int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Rid int,
Month int,
Year int,
DepartmentId int references Departments(Id) on delete set null,
SubjectId int references Subjects(SId) on delete set null,
Appraisal_Marks float,
Appraisal_Percentage float,
Total_Marks float,
Not_Applicable_Marks float,
Remarks varchar(500))
go


create table DepartmentMasterReports(
Id int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Month int,
Year int,
DepartmentId int references Departments(Id) on delete set null,
Appraisal_Marks float,
Appraisal_Percentage float,
Total_Marks float,
Not_Applicable_Marks float,
Remarks varchar(500))
go


create table Subjects_MarksMapping(
Id int primary key identity(1,1),
SId int references Subjects(SId) on delete set null,
AType int,
Marks float)
go


create table Departments_MarksMapping(
Id int primary key identity(1,1),
DId int references Subjects(SId) on delete set null,
AType int,
Marks float)
go
