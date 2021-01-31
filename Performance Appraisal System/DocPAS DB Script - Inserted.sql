
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
insert into Roles values('Commissioner Office')
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
go


insert into Subjects values(N'विभागीय चौकशी (गट-क व गट-ड)',1,2)
insert into Subjects values(N'सेवा निवृत्तीवेतन प्रकरणविषयक',1,2)
insert into Subjects values(N'सेवा पुस्तक अद्यायवात करणे',1,2)
insert into Subjects values(N'अभिलेखाचे वर्गीकरण',1,2)
insert into Subjects values(N'महालेखापाल प्रलंबीत, लेखापरीच्छेद अहवाल सादर करणे.',1,2)
insert into Subjects values(N'मा.उच्च/सर्वोच्च न्यायालयातील प्रकरणे शपथ पत्र दाखल करणे',1,2)

insert into Subjects values(N'खरीप पीक कर्जवाटप',2,2)
insert into Subjects values(N'रब्बी पीक कर्जवाटप',2,2)
insert into Subjects values(N'बिगर कर्जदार सभासदांना कर्जवाटप',2,-1)
insert into Subjects values(N'1 टक्के व्याजअनुदान प्रस्ताव',2,-1)
insert into Subjects values(N'2.5 टक्के व्याज अनुदान प्रस्ताव',2,-1)
insert into Subjects values(N'उपयोगिता प्रमाणपत्र निपटारा.',2,-1)
insert into Subjects values(N'सभासद वाढ (भूविकास कार्यासन)',2,2)

insert into Subjects values(N'सहकारी संस्थांची नोंदणी',3,2)
insert into Subjects values(N'सहकारी संस्थांची उपविधी दुरुस्ती',3,2)
insert into Subjects values(N'सावकारी व्यवसायासाठी परवाना देणे',3,2)
insert into Subjects values(N'सावकारी व्यवसायासाठी परवाना नुतनीकरण',3,2)
insert into Subjects values(N'सहकारी गृहनिर्माण संस्थांचे मानीव अभिहस्तांतरण',3,2)
insert into Subjects values(N'सी.एम./ पी.एम पोर्टल वरील प्राप्त तक्रारींचा आढावा',3,2)

insert into Subjects values(N'वाटप करण्यात आलेला निधी खर्च करणे या बाबीमध्ये कार्यक्रम खर्च (प्लॅन) व अनिवार्य खर्च (नॉन प्लॅन)',4,2)
insert into Subjects values(N'मासिक खर्च (एम.ई.एस) अहवाल दरमहा 10 तारखेपर्यंत वेळेत सादर करणे ',4,2)
insert into Subjects values(N'शासकीय महसूली जमा रक्कमांचे ताळमेळ प्रत्येक तिमाहिस सादर करणे.',4,-1)
insert into Subjects values(N'चारमाही, आठमाही , वार्षिक अंदाजपत्रक विहीत वेळेत सादर करणे',4,-1)
insert into Subjects values(N'शासकीय भागभांडवल,कर्ज,लाभांश,व्याज,हमी याबाबतची वसुली करणे',4,2)

insert into Subjects values(N'लेखापरीक्षण पुर्ण करणे',5,2)
insert into Subjects values(N'लेखापरीक्षण पुर्ण न झालेल्या संस्था व लेखापरीक्षक यांचेवर केलेली कारवाई',5,2)
insert into Subjects values(N'प्रशासकीय विशेष अहवालाबाबत कारवाई',5,2)
insert into Subjects values(N'विनिर्दिष्ट अहवालावर निबंधकाने केलेली कारवाई',5,2)
insert into Subjects values(N'(अ) दोषदुरुस्ती अहवाल सादर न केलेल्या संस्थांवर कारवाई',5,2)
insert into Subjects values(N'(ब) प्राप्त दोष दुरुस्ती अहवालावर केलेली कारवाई',5,2)

insert into Subjects values(N'अवसायनातील 10 वर्षावरील संस्था रद्द करणे',6,2)
insert into Subjects values(N'अवसायनातील स्थावर जंगम  मालमत्ता नसलेल्या संस्था नोंदणी रद्द करणे',6,2)
insert into Subjects values(N'कलम 24 नुसार आयोजित केलेल्या  प्रशिक्षणाचा आढावा',6,2)
insert into Subjects values(N'कलम 83 अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 88 अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 78अ अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 77 (अ) अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 101 अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 152 प्रकरणांचा निपटारा',6,2)
insert into Subjects values(N'कलम 154 प्रकरणांचा निपटारा',6,2)

insert into Subjects values(N'विकासक असहकार्य नोंदणी संदर्भातील अर्ज',7,2)
insert into Subjects values(N'गृहनिर्माण संस्था संबंधित तक्रारी ',7,2)

insert into Subjects values(N'‘ड’ - वर्गातील पतसंस्था ‘क’ - वर्गात आणणे',8,2)
insert into Subjects values(N'‘क’ वर्गातील पतसंस्था ‘ब’ वर्गामध्ये आणणे',8,2)
insert into Subjects values(N'जनहित याचिका क्र.60/2011 चे अनुषंगाने अडचणीतील पतसंस्थांबाबतची कारवाई विहीत मुदतीत करणे',8,-1)
insert into Subjects values(N'कलम 101 अन्वये वसुली दाखले देणे',8,2)
insert into Subjects values(N'वाजवी मुल्यास मान्यता देणे',8,2)
insert into Subjects values(N'कलम 100 व नियम 85 अन्वये आदेश पारीत करणे',8,2)
insert into Subjects values(N'कलम 98 अन्वये वसुली दाखल्याप्रमाणे सर्व अपचारी यांचेवर वसुलीची कारवाई करणे',8,2)

insert into Subjects values(N'सहकारी संस्थांची तपासणी',9,2)
insert into Subjects values(N'कार्यालय तपासणी',9,2)

insert into Subjects values(N'महाराष्ट्र सावकारी (नियमन) अधिनियम 2014 मधील नियम 16 अन्वये तक्रारी बाबत',10,2)
insert into Subjects values(N'महाराष्ट्र सावकारी (नियमन) अधिनियम 2014 मधील नियम 17 अन्वये जिल्हा उप निबंधक यांनी सहा.निबं यांना चौकशी कामी प्राधिकृत केले असल्यास चौकशी पुर्ण करणे / जि.उपनिबंधक यांनी कलम 18 (2) अन्वये आदेश पारित करणे',10,2)
insert into Subjects values(N'महाराष्ट्र सावकारी (नियमन)अधिनियम 2014 मधील कलम 18 (4) अन्वये विभागीय सहनिबंधक यांनी प्राप्त अपिलावर अंतिम आदेश पारित करणे',10,2)

go


insert into Divisions values(N'मुंबई विभाग')
insert into Divisions values(N'पुणे विभाग')
insert into Divisions values(N'कोल्हापूर विभाग')
insert into Divisions values(N'नाशिक विभाग')
insert into Divisions values(N'औरंगाबाद विभाग')
insert into Divisions values(N'लातूर विभाग')
insert into Divisions values(N'अमरावती विभाग')
insert into Divisions values(N'नागपूर विभाग')
insert into Divisions values(N'कोकण विभाग')
go



insert into Districts values(N'मुंबई शहर - 1',1,1)
insert into Districts values(N'मुंबई शहर - 2',1,1)
insert into Districts values(N'मुंबई शहर - 3',1,1)
insert into Districts values(N'मुंबई शहर - 4',1,1)
insert into Districts values(N'पुणे शहर',2,1)
insert into Districts values(N'पुणे ग्रामिण',2,3)
insert into Districts values(N'सोलापूर',2,2)
insert into Districts values(N'कोल्हापूर',3,2)
insert into Districts values(N'सातारा',3,3)
insert into Districts values(N'सांगली',3,2)
insert into Districts values(N'नाशिक',4,3)
insert into Districts values(N'धुळे',4,2)
insert into Districts values(N'नंदुरबार',4,2)
insert into Districts values(N'जळगाव',4,2)
insert into Districts values(N'अहमदनगर',4,2)
insert into Districts values(N'औरंगाबाद',5,3)
insert into Districts values(N'जालना',5,2)
insert into Districts values(N'परभणी',5,2)
insert into Districts values(N'हिंगोली',5,2)
insert into Districts values(N'लातूर',6,2)
insert into Districts values(N'उस्मानाबाद',6,2)
insert into Districts values(N'नांदेड',6,2)
insert into Districts values(N'बीड',6,2)
insert into Districts values(N'अमरावती',7,2)
insert into Districts values(N'अकोला',7,2)
insert into Districts values(N'वाशिम',7,2)
insert into Districts values(N'यवतमाळ',7,2)
insert into Districts values(N'बुलढाणा',7,2)
insert into Districts values(N'नागपूर',8,3)
insert into Districts values(N'वर्धा',8,2)
insert into Districts values(N'चंद्रपूर',8,2)
insert into Districts values(N'भंडारा',8,2)
insert into Districts values(N'गोंदीया',8,2)
insert into Districts values(N'गडचिरोली',8,2)
insert into Districts values(N'पालघर',9,3)
insert into Districts values(N'ठाणे',9,3)
insert into Districts values(N'रत्नागिरी',9,3)
insert into Districts values(N'रायगड',9,3)
insert into Districts values(N'सिंधुदुर्ग',9,3)
go



insert into Users(UserName,Name,Password,RoleId,Status,AppraisalType) values('comm1',N'सह्कार आयुक्त','ev1t/osfpMghRuzlR7XZ1g==',2,1,3)
go


insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR1',N'मुंबई विभाग','8NK/rO1law9dY4gP44tgzg==',1,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR2',N'पुणे विभाग','8NK/rO1law9dY4gP44tgzg==',2,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR3',N'कोल्हापूर विभाग','8NK/rO1law9dY4gP44tgzg==',3,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR4',N'नाशिक विभाग','8NK/rO1law9dY4gP44tgzg==',4,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR5',N'औरंगाबाद विभाग','8NK/rO1law9dY4gP44tgzg==',5,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR6',N'लातूर विभाग','8NK/rO1law9dY4gP44tgzg==',6,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR7',N'अमरावती विभाग','8NK/rO1law9dY4gP44tgzg==',7,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR8',N'नागपूर विभाग','8NK/rO1law9dY4gP44tgzg==',8,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('DJR9',N'कोकण विभाग','8NK/rO1law9dY4gP44tgzg==',9,3,1,1,3)
go


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR1',N'मुंबई शहर - 1','9PAG6f8yPnTuEpyNtiE8sw==',1,1,4,1,2,1)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR2',N'मुंबई शहर - 2','9PAG6f8yPnTuEpyNtiE8sw==',1,2,4,1,2,1)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR3',N'मुंबई शहर - 3','9PAG6f8yPnTuEpyNtiE8sw==',1,3,4,1,2,1)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR4',N'मुंबई शहर - 4','9PAG6f8yPnTuEpyNtiE8sw==',1,4,4,1,2,1)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR5',N'पुणे शहर','9PAG6f8yPnTuEpyNtiE8sw==',2,5,4,1,3,1)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR6',N'पुणे ग्रामिण','9PAG6f8yPnTuEpyNtiE8sw==',2,6,4,1,3,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR7',N'सोलापूर','9PAG6f8yPnTuEpyNtiE8sw==',2,7,4,1,3,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR8',N'कोल्हापूर','9PAG6f8yPnTuEpyNtiE8sw==',3,8,4,1,4,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR9',N'सातारा','9PAG6f8yPnTuEpyNtiE8sw==',3,9,4,1,4,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR10',N'सांगली','9PAG6f8yPnTuEpyNtiE8sw==',3,10,4,1,4,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR11',N'नाशिक','9PAG6f8yPnTuEpyNtiE8sw==',4,11,4,1,5,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR12',N'धुळे','9PAG6f8yPnTuEpyNtiE8sw==',4,12,4,1,5,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR13',N'नंदुरबार','9PAG6f8yPnTuEpyNtiE8sw==',4,13,4,1,5,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR14',N'जळगाव','9PAG6f8yPnTuEpyNtiE8sw==',4,14,4,1,5,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR15',N'अहमदनगर','9PAG6f8yPnTuEpyNtiE8sw==',4,15,4,1,5,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR16',N'औरंगाबाद','9PAG6f8yPnTuEpyNtiE8sw==',5,16,4,1,6,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR17',N'जालना','9PAG6f8yPnTuEpyNtiE8sw==',5,17,4,1,6,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR18',N'परभणी','9PAG6f8yPnTuEpyNtiE8sw==',5,18,4,1,6,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR19',N'हिंगोली','9PAG6f8yPnTuEpyNtiE8sw==',5,19,4,1,6,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR20',N'लातूर','9PAG6f8yPnTuEpyNtiE8sw==',6,20,4,1,7,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR21',N'उस्मानाबाद','9PAG6f8yPnTuEpyNtiE8sw==',6,21,4,1,7,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR22',N'नांदेड','9PAG6f8yPnTuEpyNtiE8sw==',6,22,4,1,7,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR23',N'बीड','9PAG6f8yPnTuEpyNtiE8sw==',6,23,4,1,7,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR24',N'अमरावती','9PAG6f8yPnTuEpyNtiE8sw==',7,24,4,1,8,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR25',N'अकोला','9PAG6f8yPnTuEpyNtiE8sw==',7,25,4,1,8,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR26',N'वाशिम','9PAG6f8yPnTuEpyNtiE8sw==',7,26,4,1,8,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR27',N'यवतमाळ','9PAG6f8yPnTuEpyNtiE8sw==',7,27,4,1,8,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR28',N'बुलढाणा','9PAG6f8yPnTuEpyNtiE8sw==',7,28,4,1,8,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR29',N'नागपूर','9PAG6f8yPnTuEpyNtiE8sw==',8,29,4,1,9,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR30',N'वर्धा','9PAG6f8yPnTuEpyNtiE8sw==',8,30,4,1,9,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR31',N'चंद्रपूर','9PAG6f8yPnTuEpyNtiE8sw==',8,31,4,1,9,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR32',N'भंडारा','9PAG6f8yPnTuEpyNtiE8sw==',8,32,4,1,9,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR33',N'गोंदीया','9PAG6f8yPnTuEpyNtiE8sw==',8,33,4,1,9,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR34',N'गडचिरोली','9PAG6f8yPnTuEpyNtiE8sw==',8,34,4,1,9,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR35',N'पालघर','9PAG6f8yPnTuEpyNtiE8sw==',9,35,4,1,10,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR36',N'ठाणे','9PAG6f8yPnTuEpyNtiE8sw==',9,36,4,1,10,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR37',N'रत्नागिरी','9PAG6f8yPnTuEpyNtiE8sw==',9,37,4,1,10,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR38',N'रायगड','9PAG6f8yPnTuEpyNtiE8sw==',9,38,4,1,10,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR39',N'सिंधुदुर्ग','9PAG6f8yPnTuEpyNtiE8sw==',9,39,4,1,10,3)
go


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_mum@rediffmail.com'
Where UserName = 'DJR1'


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_pna@rediffmail.com'
Where UserName = 'DJR2'


Update [DocPAS].[dbo].[Users]
SET Email = 'djrkolhapur@gmail.com'
Where UserName = 'DJR3'



Update [DocPAS].[dbo].[Users]
SET Email = 'djr_nsk@rediffmail.com'
Where UserName = 'DJR4'


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_agd@rediffmail.com'
Where UserName = 'DJR5'



Update [DocPAS].[dbo].[Users]
SET Email = 'djr_ltr@rediffmail.com'
Where UserName = 'DJR6'


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_amravati@rediffmail.com'
Where UserName = 'DJR7'



Update [DocPAS].[dbo].[Users]
SET Email = 'djrngp2011@gmail.com'
Where UserName = 'DJR8'



Update [DocPAS].[dbo].[Users]
SET Email = 'djrkkn@gmail.com'
Where UserName = 'DJR9'





Update [DocPAS].[dbo].[Users]
SET Email = 'ddr1mumbai@gmail.com'
Where UserName = 'DDR1'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr2mumbai@gmail.com'
Where UserName = 'DDR2'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_mum3@rediffmail.com'
Where UserName = 'DDR3'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_mum4@rediffmail.com'
Where UserName = 'DDR4'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrpunecity@gmail.com'
Where UserName = 'DDR5'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrpunegramin@gmail.com'
Where UserName = 'DDR6'



Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_spr@rediffmail.com'
Where UserName = 'DDR7'



Update [DocPAS].[dbo].[Users]
SET Email = 'ddrkolhapur@gmail.com'
Where UserName = 'DDR8'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_sat@rediffmail.com'
Where UserName = 'DDR9'


Update [DocPAS].[dbo].[Users]
SET Email = 'sangliddr@gmail.com'
Where UserName = 'DDR10'



Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_nsk@rediffmail.com'
Where UserName = 'DDR11'

Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_dhule2017@gmail.com'
Where UserName = 'DDR12'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_nbr@rediffmail.com'
Where UserName = 'DDR13'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_jla@rediffmail.com'
Where UserName = 'DDR14'

Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_anr@rediffmail.com'
Where UserName = 'DDR15'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_agd@rediffmail.com'
Where UserName = 'DDR16'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_jal@rediffmail.com'
Where UserName = 'DDR17'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_pbn@rediffmail.com'
Where UserName = 'DDR18'




Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_hli@rediffmail.com'
Where UserName = 'DDR19'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_ltr@rediffmail.com'
Where UserName = 'DDR20'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_osm@rediffmail.com'
Where UserName = 'DDR21'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr.nnd@rediffmail.com'
Where UserName = 'DDR22'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_bid@rediffmail.com'
Where UserName = 'DDR23'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_amr@rediffmail.com'
Where UserName = 'DDR24'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_akl@rediffmail.com'
Where UserName = 'DDR25'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_wsm@rediffmail.com'
Where UserName = 'DDR26'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_yml@rediffmail.com'
Where UserName = 'DDR27'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_bud@rediffmail.com'
Where UserName = 'DDR28'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrnagpur_2008@rediffmail.com'
Where UserName = 'DDR29'

Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_wda@rediffmail.com'
Where UserName = 'DDR30'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrchandrapur@gmail.com'
Where UserName = 'DDR31'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrbhan_2010@rediffmail.com'
Where UserName = 'DDR32'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_gnd@rediffmail.com'
Where UserName = 'DDR33'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_gad@rediffmail.com'
Where UserName = 'DDR34'



Update [DocPAS].[dbo].[Users]
SET Email = 'ddr.palghar@gmail.com'
Where UserName = 'DDR35'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr.tna@gmail.com'
Where UserName = 'DDR36'

Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_rtg@rediffmail.com'
Where UserName = 'DDR37'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_rgd@rediffmail.com'
Where UserName = 'DDR38'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr.sin@gmail.com'
Where UserName = 'DDR39'



/* Insert Value into Subject Mapping table */
Insert into Subjects_MarksMapping values(11,1,2)
Insert into Subjects_MarksMapping values(12,1,2)
Insert into Subjects_MarksMapping values(13,1,1)
Insert into Subjects_MarksMapping values(14,1,2)
Insert into Subjects_MarksMapping values(15,1,2)
Insert into Subjects_MarksMapping values(16,1,1)

Insert into Subjects_MarksMapping values(17,1,0)
Insert into Subjects_MarksMapping values(18,1,0)
Insert into Subjects_MarksMapping values(19,1,0)
Insert into Subjects_MarksMapping values(20,1,0)
Insert into Subjects_MarksMapping values(21,1,0)
Insert into Subjects_MarksMapping values(22,1,0)
Insert into Subjects_MarksMapping values(23,1,0)

Insert into Subjects_MarksMapping values(24,1,1.5)
Insert into Subjects_MarksMapping values(25,1,1.5)
Insert into Subjects_MarksMapping values(26,1,1.5)
Insert into Subjects_MarksMapping values(27,1,1.5)
Insert into Subjects_MarksMapping values(28,1,1.5)
Insert into Subjects_MarksMapping values(29,1,2.5)

Insert into Subjects_MarksMapping values(30,1,3)
Insert into Subjects_MarksMapping values(31,1,3)
Insert into Subjects_MarksMapping values(32,1,0)
Insert into Subjects_MarksMapping values(33,1,0)
Insert into Subjects_MarksMapping values(34,1,4)

Insert into Subjects_MarksMapping values(35,1,2)
Insert into Subjects_MarksMapping values(36,1,2)
Insert into Subjects_MarksMapping values(37,1,2)
Insert into Subjects_MarksMapping values(38,1,2)
Insert into Subjects_MarksMapping values(39,1,1)
Insert into Subjects_MarksMapping values(40,1,1)

Insert into Subjects_MarksMapping values(41,1,1)
Insert into Subjects_MarksMapping values(42,1,1)
Insert into Subjects_MarksMapping values(43,1,3)
Insert into Subjects_MarksMapping values(44,1,3)
Insert into Subjects_MarksMapping values(45,1,2)
Insert into Subjects_MarksMapping values(46,1,1)
Insert into Subjects_MarksMapping values(47,1,1)
Insert into Subjects_MarksMapping values(48,1,2)
Insert into Subjects_MarksMapping values(49,1,0.5)
Insert into Subjects_MarksMapping values(50,1,0.5)

Insert into Subjects_MarksMapping values(51,1,10)
Insert into Subjects_MarksMapping values(52,1,10)
Insert into Subjects_MarksMapping values(53,1,2)
Insert into Subjects_MarksMapping values(54,1,2)
Insert into Subjects_MarksMapping values(55,1,0)
Insert into Subjects_MarksMapping values(56,1,1.5)
Insert into Subjects_MarksMapping values(57,1,1.5)
Insert into Subjects_MarksMapping values(58,1,1.5)
Insert into Subjects_MarksMapping values(59,1,1.5)

Insert into Subjects_MarksMapping values(60,1,5)
Insert into Subjects_MarksMapping values(61,1,5)
Insert into Subjects_MarksMapping values(62,1,1)
Insert into Subjects_MarksMapping values(63,1,2)
Insert into Subjects_MarksMapping values(64,1,2)
go

Insert into Subjects_MarksMapping values(11,2,2)
Insert into Subjects_MarksMapping values(12,2,2)
Insert into Subjects_MarksMapping values(13,2,2)
Insert into Subjects_MarksMapping values(14,2,3)
Insert into Subjects_MarksMapping values(15,2,2)
Insert into Subjects_MarksMapping values(16,2,1)

Insert into Subjects_MarksMapping values(17,2,5)
Insert into Subjects_MarksMapping values(18,2,5)
Insert into Subjects_MarksMapping values(19,2,0)
Insert into Subjects_MarksMapping values(20,2,0)
Insert into Subjects_MarksMapping values(21,2,0)
Insert into Subjects_MarksMapping values(22,2,0)
Insert into Subjects_MarksMapping values(23,2,2)

Insert into Subjects_MarksMapping values(24,2,2)
Insert into Subjects_MarksMapping values(25,2,2)
Insert into Subjects_MarksMapping values(26,2,2)
Insert into Subjects_MarksMapping values(27,2,2)
Insert into Subjects_MarksMapping values(28,2,1.5)
Insert into Subjects_MarksMapping values(29,2,2.5)

Insert into Subjects_MarksMapping values(30,2,4)
Insert into Subjects_MarksMapping values(31,2,4)
Insert into Subjects_MarksMapping values(32,2,0)
Insert into Subjects_MarksMapping values(33,2,0)
Insert into Subjects_MarksMapping values(34,2,4)

Insert into Subjects_MarksMapping values(35,2,2)
Insert into Subjects_MarksMapping values(36,2,2)
Insert into Subjects_MarksMapping values(37,2,2)
Insert into Subjects_MarksMapping values(38,2,2)
Insert into Subjects_MarksMapping values(39,2,1)
Insert into Subjects_MarksMapping values(40,2,1)

Insert into Subjects_MarksMapping values(41,2,1)
Insert into Subjects_MarksMapping values(42,2,2)
Insert into Subjects_MarksMapping values(43,2,3)
Insert into Subjects_MarksMapping values(44,2,3)
Insert into Subjects_MarksMapping values(45,2,2)
Insert into Subjects_MarksMapping values(46,2,1)
Insert into Subjects_MarksMapping values(47,2,1)
Insert into Subjects_MarksMapping values(48,2,3)
Insert into Subjects_MarksMapping values(49,2,0.5)
Insert into Subjects_MarksMapping values(50,2,0.5)

Insert into Subjects_MarksMapping values(51,2,0)
Insert into Subjects_MarksMapping values(52,2,0)

Insert into Subjects_MarksMapping values(53,2,2)
Insert into Subjects_MarksMapping values(54,2,2)
Insert into Subjects_MarksMapping values(55,2,0)
Insert into Subjects_MarksMapping values(56,2,0.5)
Insert into Subjects_MarksMapping values(57,2,0.5)
Insert into Subjects_MarksMapping values(58,2,0.5)
Insert into Subjects_MarksMapping values(59,2,0.5)

Insert into Subjects_MarksMapping values(60,2,5)
Insert into Subjects_MarksMapping values(61,2,5)

Insert into Subjects_MarksMapping values(62,2,1)
Insert into Subjects_MarksMapping values(63,2,2)
Insert into Subjects_MarksMapping values(64,2,2)
go


Insert into Subjects_MarksMapping values(11,3,2)
Insert into Subjects_MarksMapping values(12,3,2)
Insert into Subjects_MarksMapping values(13,3,1)
Insert into Subjects_MarksMapping values(14,3,2)
Insert into Subjects_MarksMapping values(15,3,2)
Insert into Subjects_MarksMapping values(16,3,1)

Insert into Subjects_MarksMapping values(17,3,4)
Insert into Subjects_MarksMapping values(18,3,4)
Insert into Subjects_MarksMapping values(19,3,0)
Insert into Subjects_MarksMapping values(20,3,0)
Insert into Subjects_MarksMapping values(21,3,0)
Insert into Subjects_MarksMapping values(22,3,0)
Insert into Subjects_MarksMapping values(23,3,2)

Insert into Subjects_MarksMapping values(24,3,1.5)
Insert into Subjects_MarksMapping values(25,3,1.5)
Insert into Subjects_MarksMapping values(26,3,1.5)
Insert into Subjects_MarksMapping values(27,3,1.5)
Insert into Subjects_MarksMapping values(28,3,1.5)
Insert into Subjects_MarksMapping values(29,3,2.5)

Insert into Subjects_MarksMapping values(30,3,3)
Insert into Subjects_MarksMapping values(31,3,3)
Insert into Subjects_MarksMapping values(32,3,0)
Insert into Subjects_MarksMapping values(33,3,0)
Insert into Subjects_MarksMapping values(34,3,4)

Insert into Subjects_MarksMapping values(35,3,2)
Insert into Subjects_MarksMapping values(36,3,2)
Insert into Subjects_MarksMapping values(37,3,2)
Insert into Subjects_MarksMapping values(38,3,2)
Insert into Subjects_MarksMapping values(39,3,1)
Insert into Subjects_MarksMapping values(40,3,1)

Insert into Subjects_MarksMapping values(41,3,1)
Insert into Subjects_MarksMapping values(42,3,1)
Insert into Subjects_MarksMapping values(43,3,3)
Insert into Subjects_MarksMapping values(44,3,3)
Insert into Subjects_MarksMapping values(45,3,2)
Insert into Subjects_MarksMapping values(46,3,1)
Insert into Subjects_MarksMapping values(47,3,1)
Insert into Subjects_MarksMapping values(48,3,2)
Insert into Subjects_MarksMapping values(49,3,0.5)
Insert into Subjects_MarksMapping values(50,3,0.5)

Insert into Subjects_MarksMapping values(51,3,5)
Insert into Subjects_MarksMapping values(52,3,5)

Insert into Subjects_MarksMapping values(53,3,2)
Insert into Subjects_MarksMapping values(54,3,2)
Insert into Subjects_MarksMapping values(55,3,0)
Insert into Subjects_MarksMapping values(56,3,1.5)
Insert into Subjects_MarksMapping values(57,3,1.5)
Insert into Subjects_MarksMapping values(58,3,1.5)
Insert into Subjects_MarksMapping values(59,3,1.5)

Insert into Subjects_MarksMapping values(60,3,5)
Insert into Subjects_MarksMapping values(61,3,5)

Insert into Subjects_MarksMapping values(62,3,1)
Insert into Subjects_MarksMapping values(63,3,2)
Insert into Subjects_MarksMapping values(64,3,2)
go


Insert into DepartmentMapping  values(1,1,1,1)
Insert into DepartmentMapping  values(2,0,1,1)
Insert into DepartmentMapping  values(3,1,1,1)
Insert into DepartmentMapping  values(4,1,1,1)
Insert into DepartmentMapping  values(5,1,1,1)
Insert into DepartmentMapping  values(6,1,1,1)
Insert into DepartmentMapping  values(7,1,0,1)
Insert into DepartmentMapping  values(8,1,1,1)
Insert into DepartmentMapping  values(9,1,1,1)
Insert into DepartmentMapping  values(10,1,1,1)
go




