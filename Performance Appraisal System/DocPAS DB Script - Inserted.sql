use DocPAS
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
insert into Subjects values(N'कलम 24 नुसार आयोजित केलेल्या प्रशिक्षणाचा आढावा',6,2)
insert into Subjects values(N'कलम 83 अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 88 अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 78 (अ) अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 77 (अ) अन्वये चौकशीची एकूण प्रकरणांवरील कार्यवाही',6,2)
insert into Subjects values(N'कलम 101 अन्वये वसुली दाखले देणे',6,2)
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


insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_mum',N'मुंबई विभाग','8NK/rO1law9dY4gP44tgzg==',1,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_pna',N'पुणे विभाग','8NK/rO1law9dY4gP44tgzg==',2,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_khpr',N'कोल्हापूर विभाग','8NK/rO1law9dY4gP44tgzg==',3,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_nsk',N'नाशिक विभाग','8NK/rO1law9dY4gP44tgzg==',4,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_agd',N'औरंगाबाद विभाग','8NK/rO1law9dY4gP44tgzg==',5,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_ltr',N'लातूर विभाग','8NK/rO1law9dY4gP44tgzg==',6,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_amr',N'अमरावती विभाग','8NK/rO1law9dY4gP44tgzg==',7,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_ngp',N'नागपूर विभाग','8NK/rO1law9dY4gP44tgzg==',8,3,1,1,3)
insert into Users(UserName,Name,Password,DivisionId,RoleId,Status,ReportTo,AppraisalType) values('djr_kkn',N'कोकण विभाग','8NK/rO1law9dY4gP44tgzg==',9,3,1,1,3)
go


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_mum1',N'मुंबई शहर - 1','9PAG6f8yPnTuEpyNtiE8sw==',1,1,4,1,2,1)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_mum2',N'मुंबई शहर - 2','9PAG6f8yPnTuEpyNtiE8sw==',1,2,4,1,2,1)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_mum3',N'मुंबई शहर - 3','9PAG6f8yPnTuEpyNtiE8sw==',1,3,4,1,2,1)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_mum4',N'मुंबई शहर - 4','9PAG6f8yPnTuEpyNtiE8sw==',1,4,4,1,2,1)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('DDR5',N'पुणे शहर','9PAG6f8yPnTuEpyNtiE8sw==',2,5,4,1,3,1)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_puneg',N'पुणे ग्रामिण','9PAG6f8yPnTuEpyNtiE8sw==',2,6,4,1,3,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_spr',N'सोलापूर','9PAG6f8yPnTuEpyNtiE8sw==',2,7,4,1,3,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_khp',N'कोल्हापूर','9PAG6f8yPnTuEpyNtiE8sw==',3,8,4,1,4,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_sat',N'सातारा','9PAG6f8yPnTuEpyNtiE8sw==',3,9,4,1,4,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_sangli',N'सांगली','9PAG6f8yPnTuEpyNtiE8sw==',3,10,4,1,4,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_nsk',N'नाशिक','9PAG6f8yPnTuEpyNtiE8sw==',4,11,4,1,5,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_dhule',N'धुळे','9PAG6f8yPnTuEpyNtiE8sw==',4,12,4,1,5,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_nbr',N'नंदुरबार','9PAG6f8yPnTuEpyNtiE8sw==',4,13,4,1,5,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_jlgv',N'जळगाव','9PAG6f8yPnTuEpyNtiE8sw==',4,14,4,1,5,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_ahngr',N'अहमदनगर','9PAG6f8yPnTuEpyNtiE8sw==',4,15,4,1,5,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_argd',N'औरंगाबाद','9PAG6f8yPnTuEpyNtiE8sw==',5,16,4,1,6,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_jaln',N'जालना','9PAG6f8yPnTuEpyNtiE8sw==',5,17,4,1,6,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_prbn',N'परभणी','9PAG6f8yPnTuEpyNtiE8sw==',5,18,4,1,6,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_hng',N'हिंगोली','9PAG6f8yPnTuEpyNtiE8sw==',5,19,4,1,6,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_latur',N'लातूर','9PAG6f8yPnTuEpyNtiE8sw==',6,20,4,1,7,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_osm',N'उस्मानाबाद','9PAG6f8yPnTuEpyNtiE8sw==',6,21,4,1,7,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_nnd',N'नांदेड','9PAG6f8yPnTuEpyNtiE8sw==',6,22,4,1,7,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_bid',N'बीड','9PAG6f8yPnTuEpyNtiE8sw==',6,23,4,1,7,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_amr',N'अमरावती','9PAG6f8yPnTuEpyNtiE8sw==',7,24,4,1,8,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_akola',N'अकोला','9PAG6f8yPnTuEpyNtiE8sw==',7,25,4,1,8,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_wsm',N'वाशिम','9PAG6f8yPnTuEpyNtiE8sw==',7,26,4,1,8,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_ym',N'यवतमाळ','9PAG6f8yPnTuEpyNtiE8sw==',7,27,4,1,8,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_bud',N'बुलढाणा','9PAG6f8yPnTuEpyNtiE8sw==',7,28,4,1,8,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_nagpur',N'नागपूर','9PAG6f8yPnTuEpyNtiE8sw==',8,29,4,1,9,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_wrdh',N'वर्धा','9PAG6f8yPnTuEpyNtiE8sw==',8,30,4,1,9,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_chdr',N'चंद्रपूर','9PAG6f8yPnTuEpyNtiE8sw==',8,31,4,1,9,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_bhan',N'भंडारा','9PAG6f8yPnTuEpyNtiE8sw==',8,32,4,1,9,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_gond',N'गोंदीया','9PAG6f8yPnTuEpyNtiE8sw==',8,33,4,1,9,2)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_gad',N'गडचिरोली','9PAG6f8yPnTuEpyNtiE8sw==',8,34,4,1,9,2)

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_palghar',N'पालघर','9PAG6f8yPnTuEpyNtiE8sw==',9,35,4,1,10,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_thn',N'ठाणे','9PAG6f8yPnTuEpyNtiE8sw==',9,36,4,1,10,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_rtg',N'रत्नागिरी','9PAG6f8yPnTuEpyNtiE8sw==',9,37,4,1,10,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_rgd',N'रायगड','9PAG6f8yPnTuEpyNtiE8sw==',9,38,4,1,10,3)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo,AppraisalType) values('ddr_sin',N'सिंधुदुर्ग','9PAG6f8yPnTuEpyNtiE8sw==',9,39,4,1,10,3)
go


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_mum@rediffmail.com'
Where UserName = 'djr_mum'


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_pna@rediffmail.com'
Where UserName = 'djr_pna'


Update [DocPAS].[dbo].[Users]
SET Email = 'djrkolhapur@gmail.com'
Where UserName = 'djr_khpr'	


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_nsk@rediffmail.com'
Where UserName = 'djr_nsk'


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_agd@rediffmail.com'
Where UserName = 'djr_agd'



Update [DocPAS].[dbo].[Users]
SET Email = 'djr_ltr@rediffmail.com'
Where UserName = 'djr_ltr'


Update [DocPAS].[dbo].[Users]
SET Email = 'djr_amravati@rediffmail.com'
Where UserName = 'djr_amr'



Update [DocPAS].[dbo].[Users]
SET Email = 'djrngp2011@gmail.com'
Where UserName = 'djr_ngp'



Update [DocPAS].[dbo].[Users]
SET Email = 'djrkkn@gmail.com'
Where UserName = 'djr_kkn'





Update [DocPAS].[dbo].[Users]
SET Email = 'ddr1mumbai@gmail.com'
Where UserName = 'ddr_mum1'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr2mumbai@gmail.com'
Where UserName = 'ddr_mum2'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_mum3@rediffmail.com'
Where UserName = 'ddr_mum3'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_mum4@rediffmail.com'
Where UserName = 'ddr_mum4'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrpunecity@gmail.com'
Where UserName = 'DDR5'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrpunegramin@gmail.com'
Where UserName = 'ddr_puneg'



Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_spr@rediffmail.com'
Where UserName = 'ddr_spr'



Update [DocPAS].[dbo].[Users]
SET Email = 'ddrkolhapur@gmail.com'
Where UserName = 'ddr_khp'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_sat@rediffmail.com'
Where UserName = 'ddr_sat'


Update [DocPAS].[dbo].[Users]
SET Email = 'sangliddr@gmail.com'
Where UserName = 'ddr_sangli'



Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_nsk@rediffmail.com'
Where UserName = 'ddr_nsk'

Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_dhule2017@gmail.com'
Where UserName = 'ddr_dhule'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_nbr@rediffmail.com'
Where UserName = 'ddr_nbr'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_jla@rediffmail.com'
Where UserName = 'ddr_jlgv'

Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_anr@rediffmail.com'
Where UserName = 'ddr_ahngr'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_agd@rediffmail.com'
Where UserName = 'ddr_argd'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_jal@rediffmail.com'
Where UserName = 'ddr_jaln'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_pbn@rediffmail.com'
Where UserName = 'ddr_prbn'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_hli@rediffmail.com'
Where UserName = 'ddr_hng'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_ltr@rediffmail.com'
Where UserName = 'ddr_latur'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_osm@rediffmail.com'
Where UserName = 'ddr_osm'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr.nnd@rediffmail.com'
Where UserName = 'ddr_nnd'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_bid@rediffmail.com'
Where UserName = 'ddr_bid'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_amr@rediffmail.com'
Where UserName = 'ddr_amr'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_akl@rediffmail.com'
Where UserName = 'ddr_akola'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_wsm@rediffmail.com'
Where UserName = 'ddr_wsm'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_yml@rediffmail.com'
Where UserName = 'ddr_ym'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_bud@rediffmail.com'
Where UserName = 'ddr_bud'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrnagpur_2008@rediffmail.com'
Where UserName = 'ddr_nagpur'

Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_wda@rediffmail.com'
Where UserName = 'ddr_wrdh'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrchandrapur@gmail.com'
Where UserName = 'ddr_chdr'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddrbhan_2010@rediffmail.com'
Where UserName = 'ddr_bhan'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_gnd@rediffmail.com'
Where UserName = 'ddr_gond'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_gad@rediffmail.com'
Where UserName = 'ddr_gad'



Update [DocPAS].[dbo].[Users]
SET Email = 'ddr.palghar@gmail.com'
Where UserName = 'ddr_palghar'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr.tna@gmail.com'
Where UserName = 'ddr_thn'

Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_rtg@rediffmail.com'
Where UserName = 'ddr_rtg'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr_rgd@rediffmail.com'
Where UserName = 'ddr_rgd'


Update [DocPAS].[dbo].[Users]
SET Email = 'ddr.sin@gmail.com'
Where UserName = 'ddr_sin'


insert into Users(UserName,Name,Password,RoleId,Status,AppraisalType) values('admin',N'सह्कार आयुक्त','ev1t/osfpMghRuzlR7XZ1g==',2,1,3)



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





/*

AR Offices

insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR1',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR2',N'सहाय्यक निबंधक (2) अधिन जिल्हा उपनिबंधक, सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3',N'सहाय्यक निबंधक (3) अधिन जिल्हा उपनिबंधक, सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR4',N'सहाय्यक निबंधक, सहकारी संस्था, उत्तर सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR5',N'सहाय्यक निबंधक, सहकारी संस्था, दक्षिण सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR6',N'सहाय्यक निबंधक, सहकारी संस्था, अक्क्लकोट जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR7',N'सहाय्यक निबंधक, सहकारी संस्था बार्शी  जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR8',N'सहाय्यक निबंधक, सहकारी संस्था मोहोळ जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR9',N'सहाय्यक निबंधक, सहकारी संस्था, माढा जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR10',N'सहाय्यक निबंधक, सहकारी संस्था, करमाळा  जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR11',N'सहाय्यक निबंधक, सहकारी संस्था, पंढरपुर  जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR12',N'सहाय्यक निबंधक, सहकारी संस्था, सांगोला  जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR13',N'सहाय्यक निबंधक, सहकारी संस्था, अकलुज  जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR14',N'सहाय्यक निबंधक, सहकारी संस्था,मंगळवेढा जि. सोलापूर','AR123',2,7,5,1,17)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR15',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) सोलापूर','AR123',2,7,5,1,17)


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR16',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR17',N'सहाय्यक निबंधक  (2) अधिन जिल्हा उपनिबंधक, नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR18',N'सहाय्यक निबंधक, सहकारी संस्था, दिंडोरी/पेठ, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR19',N'सहाय्यक निबंधक, सहकारी संस्था, सुरगाणा, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR20',N'सहाय्यक निबंधक, सहकारी संस्था, कळवण, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR21',N'सहाय्यक निबंधक, सहकारी संस्था, सिन्नर, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR22',N'सहाय्यक निबंधक, सहकारी संस्था, इगतपुरी, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR23',N'सहाय्यक निबंधक, सहकारी संस्था, निफाड, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR24',N'सहाय्यक निबंधक, सहकारी संस्था, येवला, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR25',N'सहाय्यक निबंधक, सहकारी संस्था, चांदवड, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR26',N'सहाय्यक निबंधक, सहकारी संस्था, नांदगांव, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR27',N'सहाय्यक निबंधक, सहकारी संस्था, सटाणा, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR28',N'सहाय्यक निबंधक, सहकारी संस्था, देवळा, जि. नाशिक','AR123',4,11,5,1,21)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR29',N'सहाय्यक निबंधक,सहकारी संस्था (दुग्ध) नाशिक','AR123',4,11,5,1,21)


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR30',N'सहाय्यक निबंधक अधिन जिल्हा उपनिबंधक,स.सं.धुळे','AR123',4,12,5,1,22)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR31',N'सहाय्यक निबंधक, सहकारी संस्था, शिरपुर, जिल्हा धुळे','AR123',4,12,5,1,22)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR32',N'सहाय्यक निबंधक, सहकारी संस्था, सिंदखेडा, जिल्हा धुळे','AR123',4,12,5,1,22)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR33',N'सहाय्यक निबंधक, सहकारी संस्था, साक्री, जिल्हा धुळे','AR123',4,12,5,1,22)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR34',N'सहाय्यक निबंधक,सहकारी संस्था (दुग्ध) धुळे','AR123',4,12,5,1,22)


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR35',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. नंदुरबार','AR123',4,13,5,1,23)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR36',N'सहाय्यक निबंधक, सहकारी संस्था, नंदुरबार, जि. नंदुरबार','AR123',4,13,5,1,23)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR37',N'सहाय्यक निबंधक, सहकारी संस्था,नवापुर, जि. नंदुरबार','AR123',4,13,5,1,23)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR38',N'सहाय्यक निबंधक, सहकारी संस्था,शहादा, जि. नंदुरबार','AR123',4,13,5,1,23)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR39',N'सहाय्यक निबंधक, सहकारी संस्था, तळोदा, जि. नंदुरबार','AR123',4,13,5,1,23)


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR40',N'सहाय्यक निबंधक  (1) अधिन जिल्हा उपनिबंधक, जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR41',N'सहाय्यक निबंधक  (2) अधिन जिल्हा उपनिबंधक, जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR42',N'सहाय्यक निबंधक, सहकारी संस्था, भुसावळ, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR43',N'सहाय्यक निबंधक, सहकारी संस्था, जामनेर, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR44',N'सहाय्यक निबंधक, सहकारी संस्था, मुक्ताईनगर, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR45',N'सहाय्यक निबंधक, सहकारी संस्था, रावेर, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR46',N'सहाय्यक निबंधक, सहकारी संस्था, यावल, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR47',N'सहाय्यक निबंधक, सहकारी संस्था, चोपडा, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR48',N'सहाय्यक निबंधक, सहकारी संस्था, अमळनेर, जि. जळगांव ','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR49',N'सहाय्यक निबंधक, सहकारी संस्था, पारोळा, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR50',N'सहाय्यक निबंधक, सहकारी संस्था, एरंडोल, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR51',N'सहाय्यक निबंधक, सहकारी संस्था, पाचोरा, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR52',N'सहाय्यक निबंधक, सहकारी संस्था, भडगांव, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR53',N'सहाय्यक निबंधक, सहकारी संस्था, चाळीसगांव, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR54',N'सहाय्यक निबंधक,सहकारी संस्था, धरणगांव, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR55',N'सहाय्यक निबंधक, सहकारी संस्था, बोदवड, जि. जळगांव','AR123',4,14,5,1,24)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR56',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) जळगांव','AR123',4,14,5,1,24)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR57',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, अहमदनगर','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR58',N'सहाय्यक निबंधक (2) अधिन जिल्हा उपनिबंधक, अहमदनगर','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR59',N'सहाय्यक निबंधक (3) अधिन जिल्हा उपनिबंधक, अहमदनगर','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR60',N'सहाय्यक निबंधक, सहकारी संस्था, पारनेर, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR61',N'सहाय्यक निबंधक, सहकारी संस्था, श्रीगोंदा, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR62',N'सहाय्यक निबंधक, सहकारी संस्था, कर्जत, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR63',N'सहाय्यक निबंधक, सहकारी संस्था, जामखेड, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR64',N'सहाय्यक निबंधक, सहकारी संस्था, राहुरी, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR65',N'सहाय्यक निबंधक, सहकारी संस्था, शेवगांव, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR66',N'सहाय्यक निबंधक, सहकारी संस्था, नेवासा, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR67',N'सहाय्यक निबंधक, सहकारी संस्था, पाथर्डी, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR68',N'सहाय्यक निबंधक, सहकारी संस्था, श्रीरामपुर, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR69',N'सहाय्यक निबंधक, सहकारी संस्था,कोपरगांव, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR70',N'सहाय्यक निबंधक, सहकारी संस्था, अकोले, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR71',N'सहाय्यक निबंधक, सहकारी संस्था, राहाता, जि.अहमदनगर ','AR123',4,15,5,1,25)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR72',N'सहाय्यक निबंधक, सहकारी  संस्था (दुग्ध) अहमदनगर','AR123',4,15,5,1,25)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR73',N'सहाय्यक निबधक, सहकारी संस्था,  शिरोळ, कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR74',N'सहाय्यक निबधक, सहकारी संस्था, भुदरगड, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR75',N'सहाय्यक निबधक, सहकारी संस्था, करवीर, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR76',N'सहाय्यक निबधक, सहकारी संस्था, पन्हाळा, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR77',N'सहाय्यक निबधक, सहकारी संस्था, राधानगरी, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR78',N'सहाय्यक निबधक, सहकारी संस्था, शाहुवाडी, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR79',N'सहाय्यक निबधक, सहकारी संस्था, गगनबावडा,जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR80',N'सहाय्यक निबधक (1) अधीन जिल्हा उपनिबंधक, कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR81',N'सहाय्यक निबधक (2) अधीन जिल्हा उपनिबंधक, कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR82',N'सहाय्यक निबधक (3) अधीन जिल्हा उपनिबंधक, कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR83',N'सहाय्यक निबधक (4) अधीन जिल्हा उपनिबंधक, कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR84',N'सहाय्यक निबधक, सहकारी संस्था, कागल, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR85',N'सहाय्यक निबधक, सहकारी संस्था, गडहिंग्लज, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR86',N'सहाय्यक निबधक, सहकारी संस्था, आजरा, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR87',N'सहाय्यक निबधक, सहकारी संस्था, चंदगड, जि. कोल्हापूर','AR123',3,8,5,1,18)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR88',N'सहाय्यक निबधक, सहकारी संस्था, (दुग्ध)कोल्हापूर','AR123',3,8,5,1,18)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR89',N'सहाय्यक निबंधक (1) अधीन जिल्हा उपनिबंधक,स.सं.सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR90',N'सहाय्यक निबंधक (2) अधीन जिल्हा उपनिबंधक,स.सं.सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR91',N'सहाय्यक निबंधक (3) अधीन जिल्हा उपनिबंधक,स.सं.सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR92',N'सहाय्यक निबंधक, सहकारी संस्था,कवठे महंकाळ,जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR93',N'सहाय्यक निबंधक, सहकारी संस्था, जत, जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR94',N'सहाय्यक निबंधक, सहकारी संस्था, आटपाडी, जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR95',N'सहाय्यक निबंधक, सहकारी संस्था, विटा, जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR96',N'सहाय्यक निबंधक, सहकारी संस्था, तासगांव, जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR97',N'सहाय्यक निबंधक, सहकारी संस्था, इस्लामपूर, जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR98',N'सहाय्यक निबंधक, सहकारी संस्था, शिराळा, जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR99',N'सहाय्यक निबंधक, सहकारी संस्था, पलुस, जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR100',N'सहाय्यक निबंधक, सहकारी संस्था, कडेगांव, जि. सांगली','AR123',3,10,5,1,20)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR101',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) सांगली','AR123',3,10,5,1,20)


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR102',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR103',N'सहाय्यक निबंधक (2) अधिन जिल्हा उपनिबंधक, सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR104',N'सहाय्यक निबंधक (3) अधिन जिल्हा उपनिबंधक, सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR105',N'सहाय्यक निबंधक, सहकारी संस्था,मेढा ता. जावळी, जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR106',N'सहाय्यक निबंधक, सहकारी संस्था,पाटण, जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR107',N'सहाय्यक निबंधक, सहकारी संस्था,सातारा,जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR108',N'सहाय्यक निबंधक, सहकारी संस्था,वडुज-खटाव, जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR109',N'सहाय्यक निबंधक, सहकारी संस्था,दहीवडी-माण,जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR110',N'सहाय्यक निबंधक, सहकारी संस्था,कोरेगांव,  जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR111',N'सहाय्यक निबंधक, सहकारी संस्था, खंडाळा, जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR112',N'सहाय्यक निबंधक, सहकारी संस्था,फलटण,जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR113',N'सहाय्यक निबंधक, सहकारी संस्था, वाई, जि. सातारा','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR114',N'सहाय्यक निबंधक, सहकारी संस्था , महाबळेश्वर, जि. सातरा ','AR123',3,9,5,1,19)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR115',N'सहाय्यक निबंधक, सहकारी संस्था,(दुग्ध ) सातारा','AR123',3,9,5,1,19)


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR116',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक,स.सं. औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR117',N'सहाय्यक निबंधक, सहकारी संस्था,खुलताबाद,जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR118',N'सहाय्यक निबंधक, सहकारी संस्था,कन्नड, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR119',N'सहाय्यक निबंधक, सहकारी संस्था,गंगापुर, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR120',N'सहाय्यक निबंधक, सहकारी संस्था,सिल्लोड, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR121',N'सहाय्यक निबंधक, सहकारी संस्था, वैजापुर, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR122',N'सहाय्यक निबंधक, सहकारी संस्था, पैठण, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR123',N'सहाय्यक निबंधक, सहकारी संस्था, फुलंब्री, जि. औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR124',N'सहाय्यक उपायुक्त, संलग्न प्रादेशिक उपायुक्त,वस्त्रोद्योग औरंगाबाद','AR123',5,16,5,1,26)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR125',N'सहाय्यक निबंधक, सहकारी संस्था,(दुग्ध) औरंगाबाद','AR123',5,16,5,1,26)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR126',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं.  जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR127',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR128',N'सहाय्यक निबंधक, सहकारी संस्था, भोकरदन, जि.जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR129',N'सहाय्यक निबंधक, सहकारी संस्था,परतुर, जि.जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR130',N'सहाय्यक निबंधक, सहकारी संस्था, अंबड, जि.जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR131',N'सहाय्यक निबंधक, सहकारी संस्था,जाफ्राबाद, जि.जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR132',N'सहाय्यक निबंधक, सहकारी संस्था, बदनापूर, जि.जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR133',N'सहाय्यक निबंधक, सहकारी संस्था, घनसावंगी, जि.जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR134',N'सहाय्यक निबंधक, सहकारी संस्था,मंठा, जिल्हा जालना','AR123',5,17,5,1,27)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR135',N'सहाय्यक निबंधक, सहकारी संस्था, (दूग्ध) जालना','AR123',5,17,5,1,27)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR136',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक,स.सं.,ठाणे','AR123',9,36,5,1,46)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR137',N'सहाय्यक निबंधक (2) अधिन जिल्हा उपनिबंधक,स.सं.,ठाणे','AR123',9,36,5,1,46)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR138',N'सहाय्यक निबंधक, सहकारी संस्था, उल्हासनगर जि.ठाणे','AR123',9,36,5,1,46)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR139',N'सहाय्यक निबंधक, सहकारी संस्था, भिवंडी जि.ठाणे ','AR123',9,36,5,1,46)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR140',N'सहाय्यक निबंधक, सहकारी संस्था, मुरबाड, जि.ठाणे','AR123',9,36,5,1,46)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR141',N'सहाय्यक निबंधक, सहकारी संस्था, शहापुर','AR123',9,36,5,1,46)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR142',N'सहाय्यक निबंधक, सहकारी संस्था, अंबरनाथ ,जि.ठाणे','AR123',9,36,5,1,46)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR143',N'सहाय्यक निबंधक,सहकारी संस्था, (दुग्ध) जि. ठाणे','AR123',9,36,5,1,46)


insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR144',N'सहाय्यक निबंधक अधिन जिल्हा उपनिबंधक,स.सं.पालघर','AR123',9,35,5,1,45)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR145',N'सहाय्यक निबंधक, सहकारी संस्था, पालघर , जि. पालघर','AR123',9,35,5,1,45)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR146',N'सहाय्यक निबंधक, सहकारी संस्था, वाडा, जि. पालघर','AR123',9,35,5,1,45)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR147',N'सहाय्यक निबंधक, सहकारी संस्था, डहाणू , जि. पालघर','AR123',9,35,5,1,45)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR148',N'सहाय्यक निबंधक, सहकारी संस्था, विक्रमगड ,जि. पालघर','AR123',9,35,5,1,45)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR149',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक,स.सं.रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR150',N'सहाय्यक निबंधक, सहकारी संस्था, अलिबाग जि.रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR151',N'सहाय्यक निबंधक, सहकारी संस्था, पेण, जि. रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR152',N'सहाय्यक निबंधक, सहकारी संस्था,पनवेल,जि. रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR153',N'सहाय्यक निबंधक, सहकारी संस्था, उरण जि. रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR154',N'सहाय्यक निबंधक, सहकारी संस्था, कर्जत जि. रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR155',N'सहाय्यक निबंधक, सहकारी संस्था, खालापुर जि. रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR156',N'सहाय्यक निबंधक, सहकारी संस्था, सुधागड पाली जि.रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR157',N'सहाय्यक निबंधक, सहकारी संस्था, मुरुड, जि. रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR158',N'सहाय्यक निबंधक, सहकारी संस्था, माणगांव, जि.रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR159',N'सहाय्यक निबंधक, सहकारी संस्था,महाड,जि.रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR160',N'सहाय्यक निबंधक, सहकारी संस्था,रोहा.जि. रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR161',N'सहाय्यक निबंधक, सहकारी संस्था, तळा, जि. रायगड','AR123',9,38,5,1,48)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR162',N'सहाय्यक निबंधक ,सहकारी संस्था, (दुग्ध) जि. रायगड','AR123',9,38,5,1,48)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR163',N'सहाय्यक निबंधक (1) अधिन जिल्हा उपनिबंधक, रत्नागिरी','AR123',9,37,5,1,47)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR164',N'सहाय्यक निबंधक, सहकारी संस्था रत्नागिरी  तालुका','AR123',9,37,5,1,47)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR165',N'सहाय्यक निबंधक सहकारी संस्था, चिपळुण, जि. रत्नागिरी','AR123',9,37,5,1,47)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR166',N'सहाय्यक निबंधक,सहकारी संस्था देवरुख (संगमेशवर),जि.रत्नागिरी','AR123',9,37,5,1,47)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR167',N'सहाय्यक निबंधक,सहकारी संस्था राजापुर, जि. रत्नागिरी','AR123',9,37,5,1,47)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR168',N'सहाय्यक निबंधक,सहकारी संस्था, दापोली, जि. रत्नागिरी','AR123',9,37,5,1,47)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR169',N'सहाय्यक निबंधक, सहकारी संस्था, खेड, जि.रत्नागिरी','AR123',9,37,5,1,47)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR170',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) जि. रत्नागिरी','AR123',9,37,5,1,47)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR171',N'सहाय्यक निबंधक अधिन जिल्हा उपनिबंधक,स.सं. सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR172',N'सहाय्यक निबंधक,सहकारी संस्था, कणकवली, सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR173',N'सहाय्यक निबंधक,सहकारी संस्था, सावंतवाडी, सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR174',N'सहाय्यक निबंधक,सहकारी संस्था, मालवण, जि. सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR175',N'सहाय्यक निबंधक,सहकारी संस्था, कुडाळ,जि. सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR176',N'सहाय्यक निबंधक,सहकारी संस्था, देवगड, जि.सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR177',N'सहाय्यक निबंधक,सहकारी संस्था, दोडामार्ग, जि. सिंधुदुर्ग','AR123',9,39,5,1,49)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR178
',N'सहाय्यक निबंधक,सहकारी संस्था (दुग्ध) जि. सिंधुदुर्ग','AR123',9,39,5,1,49)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR179',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR180',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR181',N'सहाय्यक निबंधक, सहकारी संस्था, सेलु, जि. परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR182',N'सहाय्यक निबंधक, सहकारी संस्था,गंगाखेड, जि. परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR183',N'सहाय्यक निबंधक, सहकारी संस्था,जिंतुर, जि. परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR184',N'सहाय्यक निबंधक, सहकारी संस्था, सोनपेठ, जि.परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR185',N'सहाय्यक निबंधक, सहकारी संस्था, पालम, जि. परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR186',N'सहाय्यक निबंधक, सहकारी संस्था, मानवत, जि.परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR187',N'सहाय्यक निबंधक, सहकारी संस्था, पूर्णा, जि. परभणी','AR123',5,18,5,1,28)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR188',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध ) परभणी','AR123',5,18,5,1,28)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR189',N'सहाय्यक निंबंधक अधीन जिल्हा उपनिबंधक, स. सं. हिंगोली','AR123',5,19,5,1,29)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR190',N'सहाय्यक निबंधक, सहकारी संस्था, हिंगोली तालुका ','AR123',5,19,5,1,29)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR191',N'सहाय्यक निबंधक, सहकारी संस्था, कळमनुरी, जि.हिंगोली','AR123',5,19,5,1,29)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR192',N'सहाय्यक निबंधक, सहकारी संस्था, वसमत, जि.हिंगोली','AR123',5,19,5,1,29)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR193',N'सहाय्यक निबंधक, सहकारी संस्था,औंढा नागनाथ, जि.हिंगोली','AR123',5,19,5,1,29)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR194',N'सहाय्यक निबंधक, सहकारी संस्था, सेनगांव, जि. हिंगोली','AR123',5,19,5,1,29)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR195',N'विभागीय सहाय्यक निबंधक, सहकारी संस्था, लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR196',N'सहाय्यक निबंधक (प्रशासन) अधीन जिल्हा उपनिबंधक लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR197',N'सहाय्यक निबंधक, सहकारी संस्था,लातुर जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR198',N'सहाय्यक निबंधक, सहकारी संस्था,तालूका औसा, जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR199',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका निलंगा, जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR200',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका अहमदपूर,जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR201',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका उदगीर,जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR202',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका जळकोट,जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR203',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका रेणापूर ,जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR204',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका चाकूर, जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR205',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका शिरुर अनंतपाळ,जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR206',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका  देवणी,जि.लातूर','AR123',6,20,5,1,30)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR207',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) लातूर','AR123',6,20,5,1,30)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR208',N'सहाय्यक निबंधक  अधीन जिल्हा उपनिबंधक, उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR209',N'सहाय्यक निबंधक, सहकारी संस्था, ता. उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR210',N'सहाय्यक निबंधक, सहकारी संस्था, उमरगा, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR211',N'सहाय्यक निबंधक, सहकारी संस्था, तूळजापुर,जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR212',N'सहाय्यक निबंधक, सहकारी संस्था, भूम, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR213',N'सहाय्यक निबंधक, सहकारी संस्था, परांडा, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR214',N'सहाय्यक निबंधक, सहकारी संस्था, कळंब, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR215',N'सहाय्यक निबंधक, सहकारी संस्था, लोहारा, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR216',N'सहाय्यक निबंधक, सहकारी संस्था, वाशी, जि.उस्मानाबाद','AR123',6,21,5,1,31)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR217',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध)उस्मानाबाद','AR123',6,21,5,1,31)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR218',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR219',N'सहाय्यक निबंधक, सहकारी संस्था, गेवराई, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR220',N'सहाय्यक निबंधक, सहकारी संस्था,माजलगाव, जि.बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR221',N'सहाय्यक निबंधक, सहकारी संस्था, केज, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR222',N'सहाय्यक निबंधक, सहकारी संस्था, अंबाजोगाई, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR223',N'सहाय्यक निबंधक, सहकारी संस्था,आष्टी, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR224',N'सहाय्यक निबंधक, सहकारी संस्था  पाटोदा, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR225',N'सहाय्यक निबंधक, सहकारी संस्था, परळी, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR226',N'सहाय्यक निबंधक, सहकारी संस्था, धारुर, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR227',N'सहाय्यक निबंधक, सहकारी संस्था, शिरुर कासार, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR228',N'सहाय्यक निबंधक, सहकारी संस्था, वडवणी, जि. बीड','AR123',6,23,5,1,33)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR229',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) बीड','AR123',6,23,5,1,33)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR230',N'सहाय्यक निबंधक (1) अधीन जिल्हा उपनिबंधक,स.सं. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR231',N'सहाय्यक निबंधक (2) अधीन जिल्हा उपनिबंधक,स.सं. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR232',N'सहाय्यक निबंधक, सहकारी संस्था, कंधार, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR233',N'सहाय्यक निबंधक, सहकारी संस्था, मुखेड, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR234',N'सहाय्यक निबंधक, सहकारी संस्था,भोकर, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR235',N'सहाय्यक निबंधक, सहकारी संस्था, हदगाव, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR236',N'सहाय्यक निबंधक, सहकारी संस्था,देगलुर, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR237',N'सहाय्यक निबंधक, सहकारी संस्था,बिलोली, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR238',N'सहाय्यक निबंधक, सहकारी संस्था,किनवट, जि. नांदेड.','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR239',N'सहाय्यक निबंधक, सहकारी संस्था, मुदखेड, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR240',N'सहाय्यक निबंधक, सहकारी संस्था, अर्धापूर, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR241',N'सहाय्यक निबंधक, सहकारी संस्था, उमरी, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR242',N'सहाय्यक निबंधक, सहकारी संस्था, लोहा, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR243',N'सहाय्यक निबंधक, सहकारी संस्था, माहूर, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR244',N'सहाय्यक निबंधक, सहकारी संस्था, धर्माबाद, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR245',N'सहाय्यक निबंधक, सहकारी संस्था, नायगांव, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR246',N'सहाय्यक निबंधक, सहकारी संस्था, हिमायतनगर, जि. नांदेड','AR123',6,22,5,1,32)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR247',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) नांदेड','AR123',6,22,5,1,32)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR248',N'सहाय्यक निबंधक (1) अधीन जिल्हा उपनिबंधक, अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR249',N'सहाय्यक निबंधक (2) अधीन जिल्हा उपनिबंधक, अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR250',N'सहाय्यक निबंधक, सहकारी संस्था, तिवसा, जि. अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR251',N'सहाय्यक निबंधक, सहकारी संस्था, वरुड, जि. अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR252',N'सहाय्यक निबंधक,सहकारी संस्था अंजनगाव सूर्जी, अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR253',N'सहाय्यक निबंधक, सहकारी संस्था, मोर्शी, जि. अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR254',N'सहाय्यक निबंधक,सहकारी संस्था नांदगाव खंडेश्वर,अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR255',N'सहाय्यक निबंधक, सहकारी संस्था,अचलपुर, जि. अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR256',N'सहाय्यक निबंधक,सहकारी संस्था चांदुर बाजार, अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR257',N'सहाय्यक निबंधक, सहकारी संस्था, दर्यापुर, जि. अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR258',N'सहाय्यक निबंधक,सहकारी संस्था चांदुर रेल्वे, जि. अमरावती','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR259',N'सहाय्यक निबंधक, सहकारी संस्था, (दुग्ध) अमरावती ','AR123',7,24,5,1,34)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR260',N'सहाय्यक निबंधक, सहकारी संस्था,धामणगांव, जि. अमरावती','AR123',7,24,5,1,34)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR261',N'सहाय्यक निबंधक (1) अधीन जिल्हा उपनिबंधक,  यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR262',N'सहाय्यक निबंधक (2) अधीन जिल्हा उपनिबंधक, यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR263',N'सहाय्यक निबंधक, सहकारी संस्था,पांढरकवडा,जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR264',N'सहाय्यक निबंधक, सहकारी संस्था, राळेगाव,जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR265',N'सहाय्यक निबंधक,सहकारी संस्था, यवतमाळ, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR266',N'सहाय्यक निबंधक, सहकारी संस्था, दारव्हा, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR267',N'सहाय्यक निबंधक, सहकारी संस्था, घाटंजी, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR268',N'सहाय्यक निबंधक, सहकारी संस्था, वणी, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR269',N'सहाय्यक निबंधक, सहकारी संस्था, उमरखेड, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR270',N'सहाय्यक निबंधक, सहकारी संस्था, दिग्रस, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR271',N'सहाय्यक निबंधक, सहकारी संस्था, बाभुळगांव, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR272',N'सहाय्यक निबंधक, सहकारी संस्था, पुसद, जि.यवतमाळ ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR273',N'सहाय्यक निबंधक, सहकारी संस्था, झरीझमणी, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR274',N'सहाय्यक निबंधक, सहकारी संस्था, आर्णी, जि.यवतमाळ','AR123',7,27,5,1,37)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR275',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) यवतमाळ','AR123',7,27,5,1,37)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR276',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. अकोला','AR123',7,25,5,1,35)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR277',N'सहाय्यक निबंधक, सहकारी संस्था, अकोट, जि. अकोला','AR123',7,25,5,1,35)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR278',N'सहाय्यक निबंधक, सहकारी संस्था, तेल्हारा, जि. अकोला','AR123',7,25,5,1,35)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR279',N'सहाय्यक निबंधक, सहकारी संस्था, मुर्तीजापुर, जि. अकोला','AR123',7,25,5,1,35)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR280',N'सहाय्यक निबंधक,सहकारी संस्था बार्शी टाकळी, जि. अकोला','AR123',7,25,5,1,35)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR281',N'सहाय्यक निबंधक, सहकारी संस्था, पातूर, जि. अकोला','AR123',7,25,5,1,35)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR282',N'सहाय्यक निबंधक, सहकारी संस्था, बाळापुर, जि. अकोला','AR123',7,25,5,1,35)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR283',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध) अकोला ','AR123',7,25,5,1,35)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR284',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. वाशिम','AR123',7,26,5,1,36)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR285',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका वाशिम','AR123',7,26,5,1,36)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR286',N'सहाय्यक निबंधक, सहकारी संस्था, कारंजा, जि. वाशिम','AR123',7,26,5,1,36)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR287',N'सहाय्यक निबंधक, सहकारी संस्था, मानोरा, जि. वाशिम','AR123',7,26,5,1,36)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR288',N'सहाय्यक निबंधक, सहकारी संस्था,मालेगांव, जि. वाशिम','AR123',7,26,5,1,36)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR289',N'सहाय्यक निबंधक, सहकारी संस्था,रिसोड, जि. वाशिम','AR123',7,26,5,1,36)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR290',N'सहाय्यक निबंधक, सहकारी संस्था,मंगरुळपीर, जि. वाशिम','AR123',7,26,5,1,36)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR291',N'सहाय्यक निबंधक, सहकारी संस्था,चिखली, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR292',N'सहाय्यक निबंधक, सहकारी संस्था, देउळगाव राजा,जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR293',N'सहाय्यक निबंधक, सहकारी संस्था,सिंदखेड राजा,  बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR294',N'सहाय्यक निबंधक, सहकारी संस्था,मोताळा, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR295',N'सहाय्यक निबंधक, सहकारी संस्था,बुलढाणा, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR296',N'सहाय्यक निबंधक, सहकारी संस्था, मलकापुर, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR297',N'सहाय्यक निबंधक, सहकारी संस्था, खामगांव, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR298',N'सहाय्यक निबंधक, सहकारी संस्था,मेहकर, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR299',N'सहाय्यक निबंधक, सहकारी संस्था, जळगाव जामोद, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR300',N'सहाय्यक निबंधक, सहकारी संस्था, शेगांव, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR301',N'सहाय्यक निबंधक, सहकारी संस्था, नांदुरा, जि. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR302',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक,स.सं. बुलडाणा','AR123',7,28,5,1,38)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR303',N'सहाय्यक निबंधक, सहकारी संस्था,(दुग्ध)बुलडाणा','AR123',7,28,5,1,38)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR304',N'सहाय्यक निबंधक (प्रशासन)1 अधीन जिउनिससं. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR305',N'सहाय्यक निबंधक (प्रशासन) 2 अधीन जिउनिससं. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR306',N'सहाय्यक निबंधक (प्रशासन)3 अधीन जिउनिससं. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR307',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR308',N'सहाय्यक निबंधक, सहकारी संस्था, ता. हिंगणा, जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR309',N'सहाय्यक निबंधक, सहकारी संस्था कामठी, जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3010',N'सहाय्यक निबंधक, सहकारी संस्था उमरेड, जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3011',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका कुही,जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3012',N'सहाय्यक निबंधक, सहकारी संस्थ,रामटेक, जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3013',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका पारशिवणी, जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3014',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका मौदा,जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3015',N'सहाय्यक निबंधक, सहकारी संस्था  सावनेर, जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3016',N'सहाय्यक निबंधक, सहकारी संस्था,कळमेश्वर, जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3017',N'सहाय्यक निबंधक, सहकारी संस्था,काटोल तालुका,जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3018',N'सहाय्यक निबंधक, सहकारी संस्था,तालुका नरखेड,जि. नागपूर','AR123',8,29,5,1,39)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR3019',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) नागपूर','AR123',8,29,5,1,39)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR320',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. वर्धा','AR123',8,30,5,1,40)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR321',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका वर्धा','AR123',8,30,5,1,40)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR322',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका देवळी,जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR323',N'सहाय्यक निंबंधक, सहकारी संस्था, ता. हिंगणघाट,जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR324',N'सहाय्यक निबंधक, सहकारी संस्था,ता. समुद्रपुर,जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR325',N'सहाय्यक निबंधक, सहकारी संस्था, ता. सेलु, जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR326',N'सहाय्यक निबंधक, सहकारी संस्था, आर्वी, जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR327',N'सहाय्यक निबंधक, सहकारी संस्था, कारंजा, जिल्हा वर्धा','AR123',8,30,5,1,40)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR328',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) वर्धा','AR123',8,30,5,1,40)





insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR329',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR330',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका चंद्रपूर,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR331',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका मुल, जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR332',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका गोंडपिंपरी, जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR333',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका नागभीड,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR334',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  वरोरा,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR335',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका भद्रावती,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR336',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका राजुरा,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR337',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका ब्रम्हपुरी,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR338',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका चिमुर,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR339',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  सिन्देवाही,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR340',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) चंद्रपुर,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR341',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  कोरपना,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR342',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  पोंभूर्णा,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR343',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका सावली,जि. चंद्रपूर','AR123',8,31,5,1,41)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR344',N'सहाय्यक निबंधक, सहकारी संस्था, तालुका  बल्लारशा,जि. चंद्रपूर','AR123',8,31,5,1,41)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR345',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. भंडारा','AR123',8,32,5,1,42)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR346',N'सहाय्यक निबंधक, सहकारी संस्था, ता. भंडारा','AR123',8,32,5,1,42)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR347',N'सहाय्यक निबंधक, सहकारी संस्था, ता.पवनी, जि.भंडारा','AR123',8,32,5,1,42)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR348',N'सहाय्यक निबंधक, सहकारी संस्था, ता.लाखांदुर,जि.भंडारा','AR123',8,32,5,1,42)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR349',N'सहाय्यक निबंधक, सहकारी संस्था, ता.साकोली,जि.भंडारा','AR123',8,32,5,1,42)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR350',N'सहाय्यक निबंधक, सहकारी संस्था, ता. तुमसर,जि.भंडारा','AR123',8,32,5,1,42)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR351',N'सहाय्यक निबंधक, सहकारी संस्था, ता.मोहाडी,जि.भंडारा','AR123',8,32,5,1,42)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR352',N'सहाय्यक निबंधक, सहकारी संस्था, ता. लाखनी,जि.भंडारा','AR123',8,32,5,1,42)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR353',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) भंडारा','AR123',8,32,5,1,42)




insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR354',N'सहाय्यक निबंधक अधीन जिल्हा उपनिबंधक, स. सं. गोंदीया','AR123',8,33,5,1,43)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR355',N'सहाय्यक निबंधक, सहकारी संस्था, ता. गोंदिया ,जि.गोंदिया','AR123',8,33,5,1,43)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR356',N'सहाय्यक निबंधक, सहकारी संस्था, ता. तिरोडा जि. गोंदिया','AR123',8,33,5,1,43)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR357',N'सहाय्यक निबंधक, सहकारी संस्था, ता. गोरेगांव, जि. गोंदिया','AR123',8,33,5,1,43)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR358',N'सहाय्यक निबंधक, सहकारी संस्था, ता. आमगांव, जि. गोंदिया','AR123',8,33,5,1,43)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR359',N'सहाय्यक निबंधक, सहकारी संस्था, ता. अर्जुनी मोरगांव, जि.गोंदिया ','AR123',8,33,5,1,43)



insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR360',N'सहाय्यक निबंधक (प्रशासन) अधिन जिल्हा उपनिबंधक सहकारी संस्था,गडचिरोली','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR361',N'सहाय्यक निबंधक. सहकारी संस्था, गडचिरोली तालुका','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR362',N'सहाय्यक निबंधक, सहकारी संस्था, ता. चामोर्शी, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR363',N'सहाय्यक निबंधक, सहकारी संस्था, ता. आरमोरी, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR364',N'सहाय्यक निबंधक, सहकारी संस्था, ता. अहेरी, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR365',N'सहाय्यक निबंधक, सहकारी संस्था, ता. भामरागड,जि.गडचिरोली','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR366',N'सहाय्यक निबंधक, सहकारी संस्था, ता. कोरची, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR367',N'सहाय्यक निबंधक, सहकारी संस्था, ता. देसाईगंज वडसा,जि.गडचिरोली','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR368',N'सहाय्यक निबंधक, सहकारी संस्था, ता. मूलचेरी, जि.गडचिरोली','AR123',8,34,5,1,44)
insert into Users(UserName,Name,Password,DivisionId,DistrictId,RoleId,Status,ReportTo) values('AR369',N'सहाय्यक निबंधक, सहकारी संस्था (दुग्ध ) गडचिरोली','AR123',8,34,5,1,44)
go

*/
