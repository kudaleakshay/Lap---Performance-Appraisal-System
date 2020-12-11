create database DocPAS
go

use DocPAS
go

create table Departments(
Id int primary key identity(1,1),
DepartmentName nvarchar(200))
go

create table AppraisalTables(
Id int primary key identity(1,1),
TableName nvarchar(50))
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
SubjectName nvarchar(200),
DepartmentId int references Departments(Id) on delete set null)
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

insert into Departments values(N'आस्थापना / संवका/लेखा/कायदा व वैधानिक')
insert into Departments values(N'कृषीपतपुरवठा व भूविकास')
insert into Departments values(N'माहिती व तंत्रज्ञान / दक्षता')
insert into Departments values(N'अंदाज व नियोजन')
insert into Departments values(N'लेखापरीक्षण')
insert into Departments values(N'कायदा व वैधानिक')
insert into Departments values(N'गृहनिर्माण')
insert into Departments values(N'पतसंस्था')
insert into Departments values(N'संघटना व कार्यपध्दती')
insert into Departments values(N'सावकारी')
go

insert into Roles values('Admin')
insert into Roles values('Commissioner')
insert into Roles values('DJR')
insert into Roles values('DDR')
insert into Roles values('AR')
insert into Roles values('CO')
go


insert into Subjects values(N'प्रशासकीय बाबी - विभागीय चौकशी करणे, सेवानिवृत्ती प्रकरणे, सेवापुस्तक अदयावत करणे ,अभिलेख वर्गीकरण, महालेखापाल परिच्छेद, मा.उच्च/ सर्वोच्च न्यायालय शपथपत्र दाखल करणे.',1)
insert into Subjects values(N'खरीप व रब्बी पीक कर्जवाटप,  बिगर कर्जदार सभासदांना कर्जवाटप , व्याज परतावा प्रस्ताव , उपयोगिता प्रमाणपत्र निपटारा',2)
insert into Subjects values(N'ई-सेवा  व सी.एम. / पी.एम पोर्टल',3)
insert into Subjects values(N'अंदाजपत्रक  व शासकीय वसुली',4)
insert into Subjects values(N'लेखापरीक्षण व दोषदुरुस्ती',5)
insert into Subjects values(N'अवसायन व प्रशिक्षण कलम 83,88,78 (अ), 77(अ) इ.',6)
insert into Subjects values(N'विकासक असहकार्य नोंदणी , गृहनिर्माण संस्था संबंधित तक्रारी ',7)
insert into Subjects values(N'कमकुवत संस्थांचे बळकटीकरण व अडचणीतील पतसंस्थांवर कारवाई.',8)
insert into Subjects values(N'सहकारी संस्थांची व कार्यालय तपासणी',9)
insert into Subjects values(N'अवैध सावकारी तक्रार अर्ज कार्यवाही',10)
go


insert into Divisions values(N'मुंबई')
insert into Divisions values(N'पुणे')
insert into Divisions values(N'कोल्हापूर')
insert into Divisions values(N'नाशिक')
insert into Divisions values(N'औरंगाबाद')
insert into Divisions values(N'लातूर')
insert into Divisions values(N'अमरावती')
insert into Divisions values(N'नागपूर')
insert into Divisions values(N'कोकण')
go



insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, मुंबई शहर - 1',1,1)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, मुंबई शहर - 2',1,1)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, मुंबई शहर - 3',1,1)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, मुंबई शहर - 4',1,1)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, पुणे शहर',2,1)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, पुणे ग्रामिण',2,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, सोलापूर',2,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, कोल्हापूर',3,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, सातारा',3,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, सांगली',3,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, नाशिक',4,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, धुळे',4,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, नंदुरबार',4,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, जळगाव',4,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, अहमदनगर',4,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, औरंगाबाद',5,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, जालना',5,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, परभणी',5,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, हिंगोली',5,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, लातूर',6,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, उस्मानाबाद',6,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, नांदेड',6,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, बीड',6,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, अमरावती',7,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, अकोला',7,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, वाशिम',7,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, यवतमाळ',7,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, बुलढाणा',7,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, नागपूर',8,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, वर्धा',8,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, चंद्रपूर',8,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, भंडारा',8,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, गोंदीया',8,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, गडचिरोली',8,2)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, पालघर',9,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, ठाणे',9,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, रत्नागिरी',9,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, रायगड',9,3)
insert into Districts values(N'जिल्हा उपनिबंधक, सहकारी संस्थां, सिंधुदुर्ग',9,3)
go