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


insert into Subjects values(N'प्रशासकीय बाबी - विभागीय चौकशी करणे, सेवानिवृत्ती प्रकरणे, सेवापुस्तक अदयावत करणे ,अभिलेख वर्गीकरण, महालेखापाल परिच्छेद, मा.उच्च/ सर्वोच्च न्यायालय शपथपत्र दाखल करणे.',1,1)
insert into Subjects values(N'खरीप व रब्बी पीक कर्जवाटप,  बिगर कर्जदार सभासदांना कर्जवाटप , व्याज परतावा प्रस्ताव , उपयोगिता प्रमाणपत्र निपटारा',2,1)
insert into Subjects values(N'ई-सेवा  व सी.एम. / पी.एम पोर्टल',3,1)
insert into Subjects values(N'अंदाजपत्रक  व शासकीय वसुली',4,1)
insert into Subjects values(N'लेखापरीक्षण व दोषदुरुस्ती',5,1)
insert into Subjects values(N'अवसायन व प्रशिक्षण कलम 83,88,78 (अ), 77(अ) इ.',6,1)
insert into Subjects values(N'विकासक असहकार्य नोंदणी , गृहनिर्माण संस्था संबंधित तक्रारी ',7,1)
insert into Subjects values(N'कमकुवत संस्थांचे बळकटीकरण व अडचणीतील पतसंस्थांवर कारवाई.',8,1)
insert into Subjects values(N'सहकारी संस्थांची व कार्यालय तपासणी',9,1)
insert into Subjects values(N'अवैध सावकारी तक्रार अर्ज कार्यवाही',10,1)

insert into Subjects values(N'विभागीय चौकशी',1,2)
insert into Subjects values(N'सेवानिवृत्ती प्रकरणे',1,2)
insert into Subjects values(N'सेवा पुस्तक अद्यायवात करणे',1,2)
insert into Subjects values(N'अभिलेखाचे वर्गीकरण',1,2)
insert into Subjects values(N'महालेखापाल प्रलंबीत, लेखापरीच्छेद अहवाल सादर करणे.',1,2)
insert into Subjects values(N'मा.उच्च/सर्वोच्च न्यायालयातील  प्रकरणे शपथ पत्र दाखल करणे',1,2)

insert into Subjects values(N'खरीप पीक कर्जवाटप',2,2)
insert into Subjects values(N'रब्बी पीक कर्जवाटप',2,2)
insert into Subjects values(N'बिगर कर्जदार सभासदांना कर्जवाटप',2,2)
insert into Subjects values(N'1  टक्के व्याजअनुदान प्रस्ताव',2,2)
insert into Subjects values(N'2.5 टक्के व्याज अनुदान प्रस्ताव',2,2)
insert into Subjects values(N'उपयोगिता प्रमाणपत्र निपटारा.',2,2)
insert into Subjects values(N'सभासद वाढ (भूविकास कार्यासन)',2,2)

insert into Subjects values(N'सहकारी संस्थांची नोंदणी',3,2)
insert into Subjects values(N'सहकारी संस्थांची उपविधी दुरुस्ती',3,2)
insert into Subjects values(N'सावकारी व्यवसायासाठी परवाना देणे',3,2)
insert into Subjects values(N'सावकारी व्यवसायासाठी परवाना नुतनीकरण',3,2)
insert into Subjects values(N'सहकारी गृहनिर्माण संस्थांचे मानीव अभिहस्तांतरण',3,2)
insert into Subjects values(N'सी.एम. / पी.एम/ पोर्टल  ',3,2)

insert into Subjects values(N'वाटप करण्यात आलेला निधी खर्च करणे या बाबीमध्ये कार्यक्रम खर्च (प्लॅन) व अनिवार्य खर्च (नॉन प्लॅन)',4,2)
insert into Subjects values(N'मासिक खर्च (एम.ई.एस) अहवाल दरमहा 10 तारखेपर्यंत वेळेत सादर करणे ',4,2)
insert into Subjects values(N'शासकीय महसूली जमा रक्कमांचे ताळमेळ प्रत्येक तिमाहिस सादर करणे.',4,2)
insert into Subjects values(N'चारमाही, आठमाही , वार्षिक अंदाजपत्रक विहीत वेळेत सादर करणे',4,2)
insert into Subjects values(N'शासकीय वसुली ',4,2)

insert into Subjects values(N'लेखापरीक्षण पुर्ण करणे',5,2)
insert into Subjects values(N'लेखापरीक्षण पुर्ण न झालेल्या संस्था व लेखापरीक्षक यांचेवर केलेली कारवाई',5,2)
insert into Subjects values(N'प्रशासकीय विशेष अहवालाबाबत कारवाई',5,2)
insert into Subjects values(N'विनिर्दिष्ट अहवालावर निबंधकाने केलेली कारवाई',5,2)
insert into Subjects values(N'अ) दोषदुरुस्ती अहवाल सादर न केलेल्या संस्थांवर कारवाई',5,2)
insert into Subjects values(N'ब) प्राप्त दोष दुरुस्ती अहवालावर केलेली कारवाई',5,2)

insert into Subjects values(N'अवसायनातील 10 वर्षावरील संस्था रद्द करणे',6,2)
insert into Subjects values(N'अवसायनातील स्थावर जंगम  मालमत्ता नसलेल्या संस्था नोंदणी रद्द करणे',6,2)
insert into Subjects values(N'कलम 24 नुसार आयोजित केलेल्या  प्रशिक्षणाचा आढावा',6,2)
insert into Subjects values(N'कलम 83',6,2)
insert into Subjects values(N'कलम 88',6,2)
insert into Subjects values(N'कलम 78 (अ)',6,2)
insert into Subjects values(N'कलम 77 (अ)',6,2)
insert into Subjects values(N'कलम 101 आर सी देणे',6,2)
insert into Subjects values(N'कलम 152 प्रकरणांचा निपटारा',6,2)
insert into Subjects values(N'कलम 154 प्रकरणांचा निपटारा',6,2)

insert into Subjects values(N'विकासक असहकार्य नोंदणी संदर्भातील अर्ज',7,2)
insert into Subjects values(N'गृहनिर्माण संस्था संबंधित तक्रारी ',7,2)

insert into Subjects values(N'‘ड’ -  वर्गातील पतसंस्था ‘क’ - वर्गात आणणे',8,2)
insert into Subjects values(N'‘क’ वर्गातील संस्था ‘ब’ वर्गामध्ये आणणे',8,2)
insert into Subjects values(N'जनहित याचिका क्र.60/2011 चे अनुषंगाने अडचणीतील पतसंस्थांबाबतची कारवाई विहीत मुदतीत करणे',8,2)
insert into Subjects values(N'अ)कलम 101 अन्वये वसुली दाखले देणे',8,2)
insert into Subjects values(N'ब)वाजवी मुल्यास मान्यता देणे',8,2)
insert into Subjects values(N'क) कलम 100 व नियम 85 अन्वये आदेश पारीत करणे',8,2)
insert into Subjects values(N'ड)कलम 98 अन्वये वसुली दाखल्याप्रमाणे सर्व अपचारी यांचेवर वसुलीची कारवाई करणे',8,2)

insert into Subjects values(N'सहकारी संस्थांची तपासणी',9,2)
insert into Subjects values(N'कार्यालय तपासणी',9,2)

insert into Subjects values(N'महाराष्ट्र सावकारी (नियमन) अधिनियम 2014 मधील नियम 16 अन्वये चौकशी पुर्ण करणे.',10,2)
insert into Subjects values(N'महाराष्ट्र सावकारी (नियमन) अधिनियम 2014 मधील नियम 17 अन्वये जिल्हा उप निबंधक यांनी सहा.निबं यांना चौकशी कामी प्राधिकृत केले असल्यास चौकशी पुर्ण करणे / जि.उपनिबंधक यांनी कलम 18 (2) अन्वये आदेश पारित करणे',10,2)
insert into Subjects values(N'महाराष्ट्र सावकारी (नियमन)अधिनियम 2014 मधील कलम 18 (4) अन्वये विभागीय सहनिबंधक यांनी प्राप्त अपिलावर अंतिम आदेश पारित करणे',10,2)

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



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,RoleId,Status) values('comm1','सह्कार आयुक्त','comm1',2,1)
go


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR1',N'मुंबई','DJR123',1,3,1,1)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR2',N'पुणे','DJR123',2,3,1,1)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR3',N'कोल्हापूर','DJR123',3,3,1,1)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR4',N'नाशिक','DJR123',4,3,1,1)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR5',N'औरंगाबाद','DJR123',5,3,1,1)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR6',N'लातूर','DJR123',6,3,1,1)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR7',N'अमरावती','DJR123',7,3,1,1)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR8',N'नागपूर','DJR123',8,3,1,1)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,RoleId,Status,ReportTo) values('DJR9',N'कोकण','DJR123',9,3,1,1)
go


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR1',N'जिल्हा उपनिबंधक, सहकारी संस्थां, मुंबई शहर - 1','DDR123',1,1,4,1,2)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR2',N'जिल्हा उपनिबंधक, सहकारी संस्थां, मुंबई शहर - 2','DDR123',1,2,4,1,2)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR3',N'जिल्हा उपनिबंधक, सहकारी संस्थां, मुंबई शहर - 3','DDR123',1,3,4,1,2)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR4',N'जिल्हा उपनिबंधक, सहकारी संस्थां, मुंबई शहर - 4','DDR123',1,4,4,1,2)

insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR5',N'जिल्हा उपनिबंधक, सहकारी संस्थां, पुणे शहर','DDR123',2,5,4,1,3)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR6',N'जिल्हा उपनिबंधक, सहकारी संस्थां, पुणे ग्रामिण','DDR123',2,6,4,1,3)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR7',N'जिल्हा उपनिबंधक, सहकारी संस्थां, सोलापूर','DDR123',2,7,4,1,3)

insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR8',N'जिल्हा उपनिबंधक, सहकारी संस्थां, कोल्हापूर','DDR123',3,8,4,1,4)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR9',N'जिल्हा उपनिबंधक, सहकारी संस्थां, सातारा','DDR123',3,9,4,1,4)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR10',N'जिल्हा उपनिबंधक, सहकारी संस्थां, सांगली','DDR123',3,10,4,1,4)

insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR11',N'जिल्हा उपनिबंधक, सहकारी संस्थां, नाशिक','DDR123',4,11,4,1,5)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR12',N'जिल्हा उपनिबंधक, सहकारी संस्थां, धुळे','DDR123',4,12,4,1,5)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR13',N'जिल्हा उपनिबंधक, सहकारी संस्थां, नंदुरबार','DDR123',4,13,4,1,5)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR14',N'जिल्हा उपनिबंधक, सहकारी संस्थां, जळगाव','DDR123',4,14,4,1,5)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR15',N'जिल्हा उपनिबंधक, सहकारी संस्थां, अहमदनगर','DDR123',4,15,4,1,5)

insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR16',N'जिल्हा उपनिबंधक, सहकारी संस्थां, औरंगाबाद','DDR123',5,16,4,1,6)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR17',N'जिल्हा उपनिबंधक, सहकारी संस्थां, जालना','DDR123',5,17,4,1,6)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR18',N'जिल्हा उपनिबंधक, सहकारी संस्थां, परभणी','DDR123',5,18,4,1,6)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR19',N'जिल्हा उपनिबंधक, सहकारी संस्थां, हिंगोली','DDR123',5,19,4,1,6)

insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR20',N'जिल्हा उपनिबंधक, सहकारी संस्थां, लातूर','DDR123',6,20,4,1,7)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR21',N'जिल्हा उपनिबंधक, सहकारी संस्थां, उस्मानाबाद','DDR123',6,21,4,1,7)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR22',N'जिल्हा उपनिबंधक, सहकारी संस्थां, नांदेड','DDR123',6,22,4,1,7)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR23',N'जिल्हा उपनिबंधक, सहकारी संस्थां, बीड','DDR123',6,23,4,1,7)

insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR24',N'जिल्हा उपनिबंधक, सहकारी संस्थां, अमरावती','DDR123',7,24,4,1,8)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR25',N'जिल्हा उपनिबंधक, सहकारी संस्थां, अकोला','DDR123',7,25,4,1,8)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR26',N'जिल्हा उपनिबंधक, सहकारी संस्थां, वाशिम','DDR123',7,26,4,1,8)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR27',N'जिल्हा उपनिबंधक, सहकारी संस्थां, यवतमाळ','DDR123',7,27,4,1,8)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR28',N'जिल्हा उपनिबंधक, सहकारी संस्थां, बुलढाणा','DDR123',7,28,4,1,8)

insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR29',N'जिल्हा उपनिबंधक, सहकारी संस्थां, नागपूर','DDR123',8,29,4,1,9)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR30',N'जिल्हा उपनिबंधक, सहकारी संस्थां, वर्धा','DDR123',8,30,4,1,9)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR31',N'जिल्हा उपनिबंधक, सहकारी संस्थां, चंद्रपूर','DDR123',8,31,4,1,9)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR32',N'जिल्हा उपनिबंधक, सहकारी संस्थां, भंडारा','DDR123',8,32,4,1,9)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR33',N'जिल्हा उपनिबंधक, सहकारी संस्थां, गोंदीया','DDR123',8,33,4,1,9)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR34',N'जिल्हा उपनिबंधक, सहकारी संस्थां, गडचिरोली','DDR123',8,34,4,1,9)

insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR35',N'जिल्हा उपनिबंधक, सहकारी संस्थां, पालघर','DDR123',9,35,4,1,10)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR36',N'जिल्हा उपनिबंधक, सहकारी संस्थां, ठाणे','DDR123',9,36,4,1,10)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR37',N'जिल्हा उपनिबंधक, सहकारी संस्थां, रत्नागिरी','DDR123',9,37,4,1,10)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR38',N'जिल्हा उपनिबंधक, सहकारी संस्थां, रायगड','DDR123',9,38,4,1,10)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('DDR39',N'जिल्हा उपनिबंधक, सहकारी संस्थां, सिंधुदुर्ग','DDR123',9,39,4,1,10)
go



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR1',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR2',N'सहाय्यक निबंधक (2) अधिन जिल्हा उपनिबंधक, सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3',N'सहाय्यक निबंधक (3) अधिन जिल्हा उपनिबंधक, सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR4',N'सहाय्यक निबंधक, सहकारी संस्था, उत्तर सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR5',N'सहाय्यक निबंधक, सहकारी संस्था, दक्षिण सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR6',N'सहाय्यक निबंधक, सहकारी संस्था, अक्क्लकोट जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR7',N'सहाय्यक निबंधक, सहकारी संस्था बार्शी  जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR8',N'सहाय्यक निबंधक, सहकारी संस्था मोहोळ जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR9',N'सहाय्यक निबंधक, सहकारी संस्था, माढा जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR10',N'सहाय्यक निबंधक, सहकारी संस्था, करमाळा  जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR11',N'सहाय्यक निबंधक, सहकारी संस्था, पंढरपुर  जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR12',N'सहाय्यक निबंधक, सहकारी संस्था, सांगोला  जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR13',N'सहाय्यक निबंधक, सहकारी संस्था, अकलुज  जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR14',N'सहाय्यक निबंधक, सहकारी संस्था,मंगळवेढा जि. सोलापूर','AR123',2,7,5,1,17)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR15',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) सोलापूर','AR123',2,7,5,1,17)


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR16',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR17',N'सहाय्यक निबंधक  (2) अधिन जिल्हा उपनिबंधक, नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR18',N'सहाय्यक निबंधक, सहकारी संस्था, दिंडोरी/पेठ, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR19',N'सहाय्यक निबंधक, सहकारी संस्था, सुरगाणा, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR20',N'सहाय्यक निबंधक, सहकारी संस्था, कळवण, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR21',N'सहाय्यक निबंधक, सहकारी संस्था, सिन्नर, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR22',N'सहाय्यक निबंधक, सहकारी संस्था, इगतपुरी, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR23',N'सहाय्यक निबंधक, सहकारी संस्था, निफाड, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR24',N'सहाय्यक निबंधक, सहकारी संस्था, येवला, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR25',N'सहाय्यक निबंधक, सहकारी संस्था, चांदवड, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR26',N'सहाय्यक निबंधक, सहकारी संस्था, नांदगांव, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR27',N'सहाय्यक निबंधक, सहकारी संस्था, सटाणा, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR28',N'सहाय्यक निबंधक, सहकारी संस्था, देवळा, जि. नाशिक','AR123',4,11,5,1,21)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR29',N'सहाय्यक निबंधक,सहकारी संस्था (दुग्ध) नाशिक','AR123',4,11,5,1,21)


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR30',N'सहाय्यक निबंधक अधिन जिल्हा उपनिबंधक,स.सं.धुळे','AR123',4,12,5,1,22)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR31',N'सहाय्यक निबंधक, सहकारी संस्था, शिरपुर, जिल्हा धुळे','AR123',4,12,5,1,22)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR32',N'सहाय्यक निबंधक, सहकारी संस्था, सिंदखेडा, जिल्हा धुळे','AR123',4,12,5,1,22)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR33',N'सहाय्यक निबंधक, सहकारी संस्था, साक्री, जिल्हा धुळे','AR123',4,12,5,1,22)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR34',N'सहाय्यक निबंधक,सहकारी संस्था (दुग्ध) धुळे','AR123',4,12,5,1,22)


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR35',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. नंदुरबार','AR123',4,13,5,1,23)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR36',N'सहाय्यक निबंधक, सहकारी संस्था, नंदुरबार, जि. नंदुरबार','AR123',4,13,5,1,23)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR37',N'सहाय्यक निबंधक, सहकारी संस्था,नवापुर, जि. नंदुरबार','AR123',4,13,5,1,23)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR38',N'सहाय्यक निबंधक, सहकारी संस्था,शहादा, जि. नंदुरबार','AR123',4,13,5,1,23)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR39',N'सहाय्यक निबंधक, सहकारी संस्था, तळोदा, जि. नंदुरबार','AR123',4,13,5,1,23)


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR40',N'सहाय्यक निबंधक  (1) अधिन जिल्हा उपनिबंधक, जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR41',N'सहाय्यक निबंधक  (2) अधिन जिल्हा उपनिबंधक, जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR42',N'सहाय्यक निबंधक, सहकारी संस्था, भुसावळ, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR43',N'सहाय्यक निबंधक, सहकारी संस्था, जामनेर, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR44',N'सहाय्यक निबंधक, सहकारी संस्था, मुक्ताईनगर, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR45',N'सहाय्यक निबंधक, सहकारी संस्था, रावेर, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR46',N'सहाय्यक निबंधक, सहकारी संस्था, यावल, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR47',N'सहाय्यक निबंधक, सहकारी संस्था, चोपडा, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR48',N'सहाय्यक निबंधक, सहकारी संस्था, अमळनेर, जि. जळगांव ','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR49',N'सहाय्यक निबंधक, सहकारी संस्था, पारोळा, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR50',N'सहाय्यक निबंधक, सहकारी संस्था, एरंडोल, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR51',N'सहाय्यक निबंधक, सहकारी संस्था, पाचोरा, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR52',N'सहाय्यक निबंधक, सहकारी संस्था, भडगांव, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR53',N'सहाय्यक निबंधक, सहकारी संस्था, चाळीसगांव, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR54',N'सहाय्यक निबंधक,सहकारी संस्था, धरणगांव, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR55',N'सहाय्यक निबंधक, सहकारी संस्था, बोदवड, जि. जळगांव','AR123',4,14,5,1,24)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR56',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) जळगांव','AR123',4,14,5,1,24)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR57',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, अहमदनगर','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR58',N'सहाय्यक निबंधक (2) अधिन जिल्हा उपनिबंधक, अहमदनगर','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR59',N'सहाय्यक निबंधक (3) अधिन जिल्हा उपनिबंधक, अहमदनगर','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR60',N'सहाय्यक निबंधक, सहकारी संस्था, पारनेर, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR61',N'सहाय्यक निबंधक, सहकारी संस्था, श्रीगोंदा, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR62',N'सहाय्यक निबंधक, सहकारी संस्था, कर्जत, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR63',N'सहाय्यक निबंधक, सहकारी संस्था, जामखेड, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR64',N'सहाय्यक निबंधक, सहकारी संस्था, राहुरी, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR65',N'सहाय्यक निबंधक, सहकारी संस्था, शेवगांव, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR66',N'सहाय्यक निबंधक, सहकारी संस्था, नेवासा, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR67',N'सहाय्यक निबंधक, सहकारी संस्था, पाथर्डी, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR68',N'सहाय्यक निबंधक, सहकारी संस्था, श्रीरामपुर, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR69',N'सहाय्यक निबंधक, सहकारी संस्था,कोपरगांव, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR70',N'सहाय्यक निबंधक, सहकारी संस्था, अकोले, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR71',N'सहाय्यक निबंधक, सहकारी संस्था, राहाता, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR72',N'सहाय्यक निबंधक, सहकारी  संस्था (दुग्ध) अहमदनगर','AR123',4,15,5,1,25)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR73',N'सहाय्यक निबधक, सहकारी संस्था,  शिरोळ, कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR74',N'सहाय्यक निबधक, सहकारी संस्था, भुदरगड, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR75',N'सहाय्यक निबधक, सहकारी संस्था, करवीर, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR76',N'सहाय्यक निबधक, सहकारी संस्था, पन्हाळा, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR77',N'सहाय्यक निबधक, सहकारी संस्था, राधानगरी, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR78',N'सहाय्यक निबधक, सहकारी संस्था, शाहुवाडी, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR79',N'सहाय्यक निबधक, सहकारी संस्था, गगनबावडा,जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR80',N'सहाय्यक निबधक (1) अधीन जिल्हा उपनिबंधक, कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR81',N'सहाय्यक निबधक (2) अधीन जिल्हा उपनिबंधक, कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR82',N'सहाय्यक निबधक (3) अधीन जिल्हा उपनिबंधक, कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR83',N'सहाय्यक निबधक (4) अधीन जिल्हा उपनिबंधक, कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR84',N'सहाय्यक निबधक, सहकारी संस्था, कागल, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR85',N'सहाय्यक निबधक, सहकारी संस्था, गडहिंग्लज, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR86',N'सहाय्यक निबधक, सहकारी संस्था, आजरा, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR87',N'सहाय्यक निबधक, सहकारी संस्था, चंदगड, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR88',N'सहाय्यक निबधक, सहकारी संस्था, (दुग्ध)कोल्हापूर','AR123',3,8,5,1,18)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR89',N'सहाय्यक निबंधक (1) अधीन जिल्हा उपनिबंधक,स.सं.सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR90',N'सहाय्यक निबंधक (2) अधीन जिल्हा उपनिबंधक,स.सं.सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR91',N'सहाय्यक निबंधक (3) अधीन जिल्हा उपनिबंधक,स.सं.सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR92',N'सहाय्यक निबंधक, सहकारी संस्था,कवठे महंकाळ,जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR93',N'सहाय्यक निबंधक, सहकारी संस्था, जत, जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR94',N'सहाय्यक निबंधक, सहकारी संस्था, आटपाडी, जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR95',N'सहाय्यक निबंधक, सहकारी संस्था, विटा, जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR96',N'सहाय्यक निबंधक, सहकारी संस्था, तासगांव, जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR97',N'सहाय्यक निबंधक, सहकारी संस्था, इस्लामपूर, जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR98',N'सहाय्यक निबंधक, सहकारी संस्था, शिराळा, जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR99',N'सहाय्यक निबंधक, सहकारी संस्था, पलुस, जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR100',N'सहाय्यक निबंधक, सहकारी संस्था, कडेगांव, जि. सांगली','AR123',3,10,5,1,20)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR101',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) सांगली','AR123',3,10,5,1,20)


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR102',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR103',N'सहाय्यक निबंधक (2) अधिन जिल्हा उपनिबंधक, सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR104',N'सहाय्यक निबंधक (3) अधिन जिल्हा उपनिबंधक, सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR105',N'सहाय्यक निबंधक, सहकारी संस्था,मेढा ता. जावळी, जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR106',N'सहाय्यक निबंधक, सहकारी संस्था,पाटण, जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR107',N'सहाय्यक निबंधक, सहकारी संस्था,सातारा,जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR108',N'सहाय्यक निबंधक, सहकारी संस्था,वडुज-खटाव, जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR109',N'सहाय्यक निबंधक, सहकारी संस्था,दहीवडी-माण,जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR110',N'सहाय्यक निबंधक, सहकारी संस्था,कोरेगांव,  जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR111',N'सहाय्यक निबंधक, सहकारी संस्था, खंडाळा, जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR112',N'सहाय्यक निबंधक, सहकारी संस्था,फलटण,जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR113',N'सहाय्यक निबंधक, सहकारी संस्था, वाई, जि. सातारा','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR114',N'सहाय्यक निबंधक, सहकारी संस्था , महाबळेश्वर, जि. सातरा ','AR123',3,9,5,1,19)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR115',N'सहाय्यक निबंधक, सहकारी संस्था,(दुग्ध ) सातारा','AR123',3,9,5,1,19)


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR116',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक,स.सं. औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR117',N'सहाय्यक निबंधक, सहकारी संस्था,खुलताबाद,जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR118',N'सहाय्यक निबंधक, सहकारी संस्था,कन्नड, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR119',N'सहाय्यक निबंधक, सहकारी संस्था,गंगापुर, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR120',N'सहाय्यक निबंधक, सहकारी संस्था,सिल्लोड, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR121',N'सहाय्यक निबंधक, सहकारी संस्था, वैजापुर, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR122',N'सहाय्यक निबंधक, सहकारी संस्था, पैठण, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR123',N'सहाय्यक निबंधक, सहकारी संस्था, फुलंब्री, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR124',N'सहाय्यक उपायुक्त, संलग्न प्रादेशिक उपायुक्त,वस्त्रोद्योग औरंगाबाद','AR123',5,16,5,1,26)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR125',N'सहाय्यक निबंधक, सहकारी संस्था,(दुग्ध) औरंगाबाद','AR123',5,16,5,1,26)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR126',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं.  जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR127',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR128',N'सहाय्यक निबंधक, सहकारी संस्था, भोकरदन, जि.जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR129',N'सहाय्यक निबंधक, सहकारी संस्था,परतुर, जि.जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR130',N'सहाय्यक निबंधक, सहकारी संस्था, अंबड, जि.जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR131',N'सहाय्यक निबंधक, सहकारी संस्था,जाफ्राबाद, जि.जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR132',N'सहाय्यक निबंधक, सहकारी संस्था, बदनापूर, जि.जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR133',N'सहाय्यक निबंधक, सहकारी संस्था, घनसावंगी, जि.जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR134',N'सहाय्यक निबंधक, सहकारी संस्था,मंठा, जिल्हा जालना','AR123',5,17,5,1,27)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR135',N'सहाय्यक निबंधक, सहकारी संस्था, (दूग्ध) जालना','AR123',5,17,5,1,27)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR136',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक,स.सं.,ठाणे','AR123',9,36,5,1,46)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR137',N'सहाय्यक निबंधक (2) अधिन जिल्हा उपनिबंधक,स.सं.,ठाणे','AR123',9,36,5,1,46)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR138',N'सहाय्यक निबंधक, सहकारी संस्था, उल्हासनगर जि.ठाणे','AR123',9,36,5,1,46)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR139',N'सहाय्यक निबंधक, सहकारी संस्था, भिवंडी जि.ठाणे ','AR123',9,36,5,1,46)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR140',N'सहाय्यक निबंधक, सहकारी संस्था, मुरबाड, जि.ठाणे','AR123',9,36,5,1,46)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR141',N'सहाय्यक निबंधक, सहकारी संस्था, शहापुर','AR123',9,36,5,1,46)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR142',N'सहाय्यक निबंधक, सहकारी संस्था, अंबरनाथ ,जि.ठाणे','AR123',9,36,5,1,46)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR143',N'सहाय्यक निबंधक,सहकारी संस्था, (दुग्ध) जि. ठाणे','AR123',9,36,5,1,46)


insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR144',N'सहाय्यक निबंधक अधिन जिल्हा उपनिबंधक,स.सं.पालघर','AR123',9,35,5,1,45)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR145',N'सहाय्यक निबंधक, सहकारी संस्था, पालघर , जि. पालघर','AR123',9,35,5,1,45)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR146',N'सहाय्यक निबंधक, सहकारी संस्था, वाडा, जि. पालघर','AR123',9,35,5,1,45)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR147',N'सहाय्यक निबंधक, सहकारी संस्था, डहाणू , जि. पालघर','AR123',9,35,5,1,45)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR148',N'सहाय्यक निबंधक, सहकारी संस्था, विक्रमगड ,जि. पालघर','AR123',9,35,5,1,45)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR149',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक,स.सं.रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR150',N'सहाय्यक निबंधक, सहकारी संस्था, अलिबाग जि.रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR151',N'सहाय्यक निबंधक, सहकारी संस्था, पेण, जि. रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR152',N'सहाय्यक निबंधक, सहकारी संस्था,पनवेल,जि. रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR153',N'सहाय्यक निबंधक, सहकारी संस्था, उरण जि. रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR154',N'सहाय्यक निबंधक, सहकारी संस्था, कर्जत जि. रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR155',N'सहाय्यक निबंधक, सहकारी संस्था, खालापुर जि. रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR156',N'सहाय्यक निबंधक, सहकारी संस्था, सुधागड पाली जि.रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR157',N'सहाय्यक निबंधक, सहकारी संस्था, मुरुड, जि. रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR158',N'सहाय्यक निबंधक, सहकारी संस्था, माणगांव, जि.रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR159',N'सहाय्यक निबंधक, सहकारी संस्था,महाड,जि.रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR160',N'सहाय्यक निबंधक, सहकारी संस्था,रोहा.जि. रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR161',N'सहाय्यक निबंधक, सहकारी संस्था, तळा, जि. रायगड','AR123',9,38,5,1,48)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR162',N'सहाय्यक निबंधक ,सहकारी संस्था, (दुग्ध) जि. रायगड','AR123',9,38,5,1,48)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR163',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, रत्नागिरी','AR123',9,37,5,1,47)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR164',N'सहाय्यक निबंधक, सहकारी संस्था रत्नागिरी  तालुका','AR123',9,37,5,1,47)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR165',N'सहाय्यक निबंधक सहकारी संस्था, चिपळुण, जि. रत्नागिरी','AR123',9,37,5,1,47)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR166',N'सहाय्यक निबंधक,सहकारी संस्था देवरुख (संगमेशवर),जि.रत्नागिरी','AR123',9,37,5,1,47)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR167',N'सहाय्यक निबंधक,सहकारी संस्था राजापुर, जि. रत्नागिरी','AR123',9,37,5,1,47)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR168',N'सहाय्यक निबंधक,सहकारी संस्था, दापोली, जि. रत्नागिरी','AR123',9,37,5,1,47)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR169',N'सहाय्यक निबंधक, सहकारी संस्था, खेड, जि.रत्नागिरी','AR123',9,37,5,1,47)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR170',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) जि. रत्नागिरी','AR123',9,37,5,1,47)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR171',N'सहाय्यक निबंधक अधिन जिल्हा उपनिबंधक,स.सं. सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR172',N'सहाय्यक निबंधक,सहकारी संस्था, कणकवली, सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR173',N'सहाय्यक निबंधक,सहकारी संस्था, सावंतवाडी, सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR174',N'सहाय्यक निबंधक,सहकारी संस्था, मालवण, जि. सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR175',N'सहाय्यक निबंधक,सहकारी संस्था, कुडाळ,जि. सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR176',N'सहाय्यक निबंधक,सहकारी संस्था, देवगड, जि.सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR177',N'सहाय्यक निबंधक,सहकारी संस्था, दोडामार्ग, जि. सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR178
',N'सहाय्यक निबंधक,सहकारी संस्था (दुग्ध) जि. सिंधुदुर्ग','AR123',9,39,5,1,49)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR179',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR180',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR181',N'सहाय्यक निबंधक, सहकारी संस्था, सेलु, जि. परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR182',N'सहाय्यक निबंधक, सहकारी संस्था,गंगाखेड, जि. परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR183',N'सहाय्यक निबंधक, सहकारी संस्था,जिंतुर, जि. परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR184',N'सहाय्यक निबंधक, सहकारी संस्था, सोनपेठ, जि.परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR185',N'सहाय्यक निबंधक, सहकारी संस्था, पालम, जि. परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR186',N'सहाय्यक निबंधक, सहकारी संस्था, मानवत, जि.परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR187',N'सहाय्यक निबंधक, सहकारी संस्था, पूर्णा, जि. परभणी','AR123',5,18,5,1,28)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR188',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध ) परभणी','AR123',5,18,5,1,28)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR189',N'सहाय्यक निंबंधक अधीन जिल्हा उपनिबंधक, स. सं. हिंगोली','AR123',5,19,5,1,29)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR190',N'सहाय्यक निबंधक, सहकारी संस्था, हिंगोली तालुका ','AR123',5,19,5,1,29)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR191',N'सहाय्यक निबंधक, सहकारी संस्था, कळमनुरी, जि.हिंगोली','AR123',5,19,5,1,29)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR192',N'सहाय्यक निबंधक, सहकारी संस्था, वसमत, जि.हिंगोली','AR123',5,19,5,1,29)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR193',N'सहाय्यक निबंधक, सहकारी संस्था,औंढा नागनाथ, जि.हिंगोली','AR123',5,19,5,1,29)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR194',N'सहाय्यक निबंधक, सहकारी संस्था, सेनगांव, जि. हिंगोली','AR123',5,19,5,1,29)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR195',N'विभागीय सहाय्यक निबंधक, सहकारी संस्था, लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR196',N'सहाय्यक निबंधक (प्रशासन) अधीन जिल्हा उपनिबंधक लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR197',N'सहाय्यक निबंधक, सहकारी संस्था,लातुर जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR198',N'सहाय्यक निबंधक, सहकारी संस्था,तालूका औसा, जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR199',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका निलंगा, जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR200',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका अहमदपूर,जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR201',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका उदगीर,जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR202',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका जळकोट,जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR203',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका रेणापूर ,जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR204',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका चाकूर, जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR205',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका शिरुर अनंतपाळ,जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR206',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका  देवणी,जि.लातूर','AR123',6,20,5,1,30)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR207',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) लातूर','AR123',6,20,5,1,30)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR208',N'सहाय्यक निबंधक  अधीन जिल्हा उपनिबंधक, उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR209',N'सहाय्यक निबंधक, सहकारी संस्था, ता. उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR210',N'सहाय्यक निबंधक, सहकारी संस्था, उमरगा, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR211',N'सहाय्यक निबंधक, सहकारी संस्था, तूळजापुर,जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR212',N'सहाय्यक निबंधक, सहकारी संस्था, भूम, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR213',N'सहाय्यक निबंधक, सहकारी संस्था, परांडा, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR214',N'सहाय्यक निबंधक, सहकारी संस्था, कळंब, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR215',N'सहाय्यक निबंधक, सहकारी संस्था, लोहारा, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR216',N'सहाय्यक निबंधक, सहकारी संस्था, वाशी, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR217',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध)उस्मानाबाद','AR123',6,21,5,1,31)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR218',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR219',N'सहाय्यक निबंधक, सहकारी संस्था, गेवराई, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR220',N'सहाय्यक निबंधक, सहकारी संस्था,माजलगाव, जि.बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR221',N'सहाय्यक निबंधक, सहकारी संस्था, केज, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR222',N'सहाय्यक निबंधक, सहकारी संस्था, अंबाजोगाई, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR223',N'सहाय्यक निबंधक, सहकारी संस्था,आष्टी, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR224',N'सहाय्यक निबंधक, सहकारी संस्था  पाटोदा, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR225',N'सहाय्यक निबंधक, सहकारी संस्था, परळी, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR226',N'सहाय्यक निबंधक, सहकारी संस्था, धारुर, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR227',N'सहाय्यक निबंधक, सहकारी संस्था, शिरुर कासार, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR228',N'सहाय्यक निबंधक, सहकारी संस्था, वडवणी, जि. बीड','AR123',6,23,5,1,33)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR229',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) बीड','AR123',6,23,5,1,33)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR230',N'सहाय्यक निबंधक (1) अधीन जिल्हा उपनिबंधक,स.सं. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR231',N'सहाय्यक निबंधक (2) अधीन जिल्हा उपनिबंधक,स.सं. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR232',N'सहाय्यक निबंधक, सहकारी संस्था, कंधार, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR233',N'सहाय्यक निबंधक, सहकारी संस्था, मुखेड, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR234',N'सहाय्यक निबंधक, सहकारी संस्था,भोकर, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR235',N'सहाय्यक निबंधक, सहकारी संस्था, हदगाव, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR236',N'सहाय्यक निबंधक, सहकारी संस्था,देगलुर, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR237',N'सहाय्यक निबंधक, सहकारी संस्था,बिलोली, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR238',N'सहाय्यक निबंधक, सहकारी संस्था,किनवट, जि. नांदेड.','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR239',N'सहाय्यक निबंधक, सहकारी संस्था, मुदखेड, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR240',N'सहाय्यक निबंधक, सहकारी संस्था, अर्धापूर, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR241',N'सहाय्यक निबंधक, सहकारी संस्था, उमरी, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR242',N'सहाय्यक निबंधक, सहकारी संस्था, लोहा, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR243',N'सहाय्यक निबंधक, सहकारी संस्था, माहूर, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR244',N'सहाय्यक निबंधक, सहकारी संस्था, धर्माबाद, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR245',N'सहाय्यक निबंधक, सहकारी संस्था, नायगांव, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR246',N'सहाय्यक निबंधक, सहकारी संस्था, हिमायतनगर, जि. नांदेड','AR123',6,22,5,1,32)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR247',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) नांदेड','AR123',6,22,5,1,32)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR248',N'सहाय्यक निबंधक (1) अधीन जिल्हा उपनिबंधक, अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR249',N'सहाय्यक निबंधक (2) अधीन जिल्हा उपनिबंधक, अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR250',N'सहाय्यक निबंधक, सहकारी संस्था, तिवसा, जि. अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR251',N'सहाय्यक निबंधक, सहकारी संस्था, वरुड, जि. अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR252',N'सहाय्यक निबंधक,सहकारी संस्था अंजनगाव सूर्जी, अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR253',N'सहाय्यक निबंधक, सहकारी संस्था, मोर्शी, जि. अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR254',N'सहाय्यक निबंधक,सहकारी संस्था नांदगाव खंडेश्वर,अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR255',N'सहाय्यक निबंधक, सहकारी संस्था,अचलपुर, जि. अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR256',N'सहाय्यक निबंधक,सहकारी संस्था चांदुर बाजार, अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR257',N'सहाय्यक निबंधक, सहकारी संस्था, दर्यापुर, जि. अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR258',N'सहाय्यक निबंधक,सहकारी संस्था चांदुर रेल्वे, जि. अमरावती','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR259',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) अमरावती ','AR123',7,24,5,1,34)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR260',N'सहाय्यक निबंधक, सहकारी संस्था,धामणगांव, जि. अमरावती','AR123',7,24,5,1,34)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR261',N'सहाय्यक निबंधक (1) अधीन जिल्हा उपनिबंधक,  यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR262',N'सहाय्यक निबंधक (2) अधीन जिल्हा उपनिबंधक, यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR263',N'सहाय्यक निबंधक, सहकारी संस्था,पांढरकवडा,जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR264',N'सहाय्यक निबंधक, सहकारी संस्था, राळेगाव,जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR265',N'सहाय्यक निबंधक,सहकारी संस्था, यवतमाळ, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR266',N'सहाय्यक निबंधक, सहकारी संस्था, दारव्हा, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR267',N'सहाय्यक निबंधक, सहकारी संस्था, घाटंजी, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR268',N'सहाय्यक निबंधक, सहकारी संस्था, वणी, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR269',N'सहाय्यक निबंधक, सहकारी संस्था, उमरखेड, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR270',N'सहाय्यक निबंधक, सहकारी संस्था, दिग्रस, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR271',N'सहाय्यक निबंधक, सहकारी संस्था, बाभुळगांव, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR272',N'सहाय्यक निबंधक, सहकारी संस्था, पुसद, जि.यवतमाळ ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR273',N'सहाय्यक निबंधक, सहकारी संस्था, झरीझमणी, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR274',N'सहाय्यक निबंधक, सहकारी संस्था, आर्णी, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR275',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) यवतमाळ','AR123',7,27,5,1,37)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR276',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. अकोला','AR123',7,25,5,1,35)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR277',N'सहाय्यक निबंधक, सहकारी संस्था, अकोट, जि. अकोला','AR123',7,25,5,1,35)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR278',N'सहाय्यक निबंधक, सहकारी संस्था, तेल्हारा, जि. अकोला','AR123',7,25,5,1,35)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR279',N'सहाय्यक निबंधक, सहकारी संस्था, मुर्तीजापुर, जि. अकोला','AR123',7,25,5,1,35)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR280',N'सहाय्यक निबंधक,सहकारी संस्था बार्शी टाकळी, जि. अकोला','AR123',7,25,5,1,35)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR281',N'सहाय्यक निबंधक, सहकारी संस्था, पातूर, जि. अकोला','AR123',7,25,5,1,35)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR282',N'सहाय्यक निबंधक, सहकारी संस्था, बाळापुर, जि. अकोला','AR123',7,25,5,1,35)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR283',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) अकोला ','AR123',7,25,5,1,35)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR284',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. वाशिम','AR123',7,26,5,1,36)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR285',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका वाशिम','AR123',7,26,5,1,36)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR286',N'सहाय्यक निबंधक, सहकारी संस्था, कारंजा, जि. वाशिम','AR123',7,26,5,1,36)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR287',N'सहाय्यक निबंधक, सहकारी संस्था, मानोरा, जि. वाशिम','AR123',7,26,5,1,36)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR288',N'सहाय्यक निबंधक, सहकारी संस्था,मालेगांव, जि. वाशिम','AR123',7,26,5,1,36)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR289',N'सहाय्यक निबंधक, सहकारी संस्था,रिसोड, जि. वाशिम','AR123',7,26,5,1,36)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR290',N'सहाय्यक निबंधक, सहकारी संस्था,मंगरुळपीर, जि. वाशिम','AR123',7,26,5,1,36)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR291',N'सहाय्यक निबंधक, सहकारी संस्था,चिखली, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR292',N'सहाय्यक निबंधक, सहकारी संस्था, देउळगाव राजा,जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR293',N'सहाय्यक निबंधक, सहकारी संस्था,सिंदखेड राजा,  बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR294',N'सहाय्यक निबंधक, सहकारी संस्था,मोताळा, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR295',N'सहाय्यक निबंधक, सहकारी संस्था,बुलढाणा, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR296',N'सहाय्यक निबंधक, सहकारी संस्था, मलकापुर, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR297',N'सहाय्यक निबंधक, सहकारी संस्था, खामगांव, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR298',N'सहाय्यक निबंधक, सहकारी संस्था,मेहकर, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR299',N'सहाय्यक निबंधक, सहकारी संस्था, जळगाव जामोद, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR300',N'सहाय्यक निबंधक, सहकारी संस्था, शेगांव, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR301',N'सहाय्यक निबंधक, सहकारी संस्था, नांदुरा, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR302',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक,स.सं. बुलडाणा','AR123',7,28,5,1,38)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR303',N'सहाय्यक निबंधक, सहकारी संस्था,(दुग्ध)बुलडाणा','AR123',7,28,5,1,38)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR304',N'सहाय्यक निबंधक (प्रशासन)1 अधीन जिउनिससं. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR305',N'सहाय्यक निबंधक (प्रशासन) 2 अधीन जिउनिससं. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR306',N'सहाय्यक निबंधक (प्रशासन)3 अधीन जिउनिससं. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR307',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR308',N'सहाय्यक निबंधक, सहकारी संस्था, ता. हिंगणा, जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR309',N'सहाय्यक निबंधक, सहकारी संस्था कामठी, जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3010',N'सहाय्यक निबंधक, सहकारी संस्था उमरेड, जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3011',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका कुही,जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3012',N'सहाय्यक निबंधक, सहकारी संस्थ,रामटेक, जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3013',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका पारशिवणी, जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3014',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका मौदा,जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3015',N'सहाय्यक निबंधक, सहकारी संस्था  सावनेर, जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3016',N'सहाय्यक निबंधक, सहकारी संस्था,कळमेश्वर, जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3017',N'सहाय्यक निबंधक, सहकारी संस्था,काटोल तालुका,जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3018',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका नरखेड,जि. नागपूर','AR123',8,29,5,1,39)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3019',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) नागपूर','AR123',8,29,5,1,39)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR320',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. वर्धा','AR123',8,30,5,1,40)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR321',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका वर्धा','AR123',8,30,5,1,40)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR322',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका देवळी,जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR323',N'सहाय्यक निंबंधक, सहकारी संस्था, ता. हिंगणघाट,जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR324',N'सहाय्यक निबंधक, सहकारी संस्था,ता. समुद्रपुर,जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR325',N'सहाय्यक निबंधक, सहकारी संस्था, ता. सेलु, जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR326',N'सहाय्यक निबंधक, सहकारी संस्था, आर्वी, जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR327',N'सहाय्यक निबंधक, सहकारी संस्था, कारंजा, जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR328',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) वर्धा','AR123',8,30,5,1,40)





insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR329',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR330',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका चंद्रपूर,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR331',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका मुल, जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR332',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका गोंडपिंपरी, जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR333',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका नागभीड,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR334',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  वरोरा,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR335',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका भद्रावती,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR336',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका राजुरा,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR337',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका ब्रम्हपुरी,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR338',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका चिमुर,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR339',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  सिन्देवाही,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR340',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) चंद्रपुर,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR341',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  कोरपना,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR342',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  पोंभूर्णा,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR343',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका सावली,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR344',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  बल्लारशा,जि. चंद्रपूर','AR123',8,31,5,1,41)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR345',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. भंडारा','AR123',8,32,5,1,42)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR346',N'सहाय्यक निबंधक, सहकारी संस्था, ता. भंडारा','AR123',8,32,5,1,42)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR347',N'सहाय्यक निबंधक, सहकारी संस्था, ता.पवनी, जि.भंडारा','AR123',8,32,5,1,42)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR348',N'सहाय्यक निबंधक, सहकारी संस्था, ता.लाखांदुर,जि.भंडारा','AR123',8,32,5,1,42)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR349',N'सहाय्यक निबंधक, सहकारी संस्था, ता.साकोली,जि.भंडारा','AR123',8,32,5,1,42)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR350',N'सहाय्यक निबंधक, सहकारी संस्था, ता. तुमसर,जि.भंडारा','AR123',8,32,5,1,42)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR351',N'सहाय्यक निबंधक, सहकारी संस्था, ता.मोहाडी,जि.भंडारा','AR123',8,32,5,1,42)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR352',N'सहाय्यक निबंधक, सहकारी संस्था, ता. लाखनी,जि.भंडारा','AR123',8,32,5,1,42)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR353',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) भंडारा','AR123',8,32,5,1,42)




insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR354',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. गोंदीया','AR123',8,33,5,1,43)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR355',N'सहाय्यक निबंधक, सहकारी संस्था, ता. गोंदिया ,जि.गोंदिया','AR123',8,33,5,1,43)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR356',N'सहाय्यक निबंधक, सहकारी संस्था, ता. तिरोडा जि. गोंदिया','AR123',8,33,5,1,43)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR357',N'सहाय्यक निबंधक, सहकारी संस्था, ता. गोरेगांव, जि. गोंदिया','AR123',8,33,5,1,43)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR358',N'सहाय्यक निबंधक, सहकारी संस्था, ता. आमगांव, जि. गोंदिया','AR123',8,33,5,1,43)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR359',N'सहाय्यक निबंधक, सहकारी संस्था, ता. अर्जुनी मोरगांव, जि.गोंदिया ','AR123',8,33,5,1,43)



insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR360',N'सहाय्यक निबंधक (प्रशासन) अधिन जिल्हा उपनिबंधक सहकारी संस्था,गडचिरोली','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR361',N'सहाय्यक निबंधक. सहकारी संस्था, गडचिरोली तालुका','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR362',N'सहाय्यक निबंधक, सहकारी संस्था, ता. चामोर्शी, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR363',N'सहाय्यक निबंधक, सहकारी संस्था, ता. आरमोरी, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR364',N'सहाय्यक निबंधक, सहकारी संस्था, ता. अहेरी, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR365',N'सहाय्यक निबंधक, सहकारी संस्था, ता. भामरागड,जि.गडचिरोली','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR366',N'सहाय्यक निबंधक, सहकारी संस्था, ता. कोरची, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR367',N'सहाय्यक निबंधक, सहकारी संस्था, ता. देसाईगंज वडसा,जि.गडचिरोली','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR368',N'सहाय्यक निबंधक, सहकारी संस्था, ता. मूलचेरी, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into [DocPAS].[dbo].[Users](UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR369',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) गडचिरोली','AR123',8,34,5,1,44)





Create table Sub60(
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
Current_Month_Percentage int,
Appraisal_Marks int,
Appraisal_Percentage int,
Month int,
Year int,
Remarks varchar(500))
go


Create table Sub24(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Marks int,
Aim int,
Achieved int,
Appraisal_Marks int,
Remarks varchar(500),
Month int,
Year int)
go



Create table Sub25(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Marks int,
Aim int,
Achieved int,
Appraisal_Marks int,
Remarks varchar(500),
Month int,
Year int)
go



Create table Sub26(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Marks int,
Aim int,
Achieved int,
Appraisal_Marks int,
Remarks varchar(500),
Month int,
Year int)
go



Create table Sub27(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Marks int,
Aim int,
Achieved int,
Appraisal_Marks int,
Remarks varchar(500),
Month int,
Year int)
go



Create table Sub28(
RId int primary key identity(1,1),
UId int references Users(UId) on delete set null,
Marks int,
Aim int,
Achieved int,
Appraisal_Marks int,
Remarks varchar(500),
Month int,
Year int)
go