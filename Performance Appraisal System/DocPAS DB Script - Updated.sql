use DocPAS
go

ALTER TABLE [DocPAS].[dbo].[Report12]
ALTER COLUMN Remarks nvarchar(500);
go


ALTER TABLE [DocPAS].[dbo].[Report13]
ALTER COLUMN Remarks nvarchar(500);
go



ALTER TABLE [DocPAS].[dbo].[Users]
ADD SortKey int;
go



/* Update Sort Key of the users */

update [DocPAS].[dbo].[Users] SET SortKey=1 where UserName='djr_mum'

update [DocPAS].[dbo].[Users] SET SortKey=18 where UserName='djr_pna'

update [DocPAS].[dbo].[Users] SET SortKey=22 where UserName='djr_khpr'

update [DocPAS].[dbo].[Users] SET SortKey=12 where UserName='djr_nsk'

update [DocPAS].[dbo].[Users] SET SortKey=26 where UserName='djr_agd'

update [DocPAS].[dbo].[Users] SET SortKey=31 where UserName='djr_ltr'

update [DocPAS].[dbo].[Users] SET SortKey=36 where UserName='djr_amr'

update [DocPAS].[dbo].[Users] SET SortKey=42 where UserName='djr_ngp'

update [DocPAS].[dbo].[Users] SET SortKey=6 where UserName='djr_kkn'



update [DocPAS].[dbo].[Users] SET SortKey=2 where UserName='ddr_mum1'

update [DocPAS].[dbo].[Users] SET SortKey=3 where UserName='ddr_mum2'

update [DocPAS].[dbo].[Users] SET SortKey=4 where UserName='ddr_mum3'

update [DocPAS].[dbo].[Users] SET SortKey=5 where UserName='ddr_mum4'


update [DocPAS].[dbo].[Users] SET SortKey=19 where UserName='DDR5'

update [DocPAS].[dbo].[Users] SET SortKey=20 where UserName='ddr_puneg'

update [DocPAS].[dbo].[Users] SET SortKey=21 where UserName='ddr_spr'


update [DocPAS].[dbo].[Users] SET SortKey=23 where UserName='ddr_khp'

update [DocPAS].[dbo].[Users] SET SortKey=24 where UserName='ddr_sat'

update [DocPAS].[dbo].[Users] SET SortKey=25 where UserName='ddr_sangli'


update [DocPAS].[dbo].[Users] SET SortKey=13 where UserName='ddr_nsk'

update [DocPAS].[dbo].[Users] SET SortKey=14 where UserName='ddr_dhule'

update [DocPAS].[dbo].[Users] SET SortKey=15 where UserName='ddr_nbr'

update [DocPAS].[dbo].[Users] SET SortKey=16 where UserName='ddr_jlgv'

update [DocPAS].[dbo].[Users] SET SortKey=17 where UserName='ddr_ahngr'


update [DocPAS].[dbo].[Users] SET SortKey=27 where UserName='ddr_argd'

update [DocPAS].[dbo].[Users] SET SortKey=28 where UserName='ddr_jaln'

update [DocPAS].[dbo].[Users] SET SortKey=29 where UserName='ddr_prbn'

update [DocPAS].[dbo].[Users] SET SortKey=30 where UserName='ddr_hng'


update [DocPAS].[dbo].[Users] SET SortKey=32 where UserName='ddr_latur'

update [DocPAS].[dbo].[Users] SET SortKey=33 where UserName='ddr_osm'

update [DocPAS].[dbo].[Users] SET SortKey=34 where UserName='ddr_nnd'

update [DocPAS].[dbo].[Users] SET SortKey=35 where UserName='ddr_bid'


update [DocPAS].[dbo].[Users] SET SortKey=37 where UserName='ddr_amr'

update [DocPAS].[dbo].[Users] SET SortKey=38 where UserName='ddr_akola'

update [DocPAS].[dbo].[Users] SET SortKey=39 where UserName='ddr_wsm'

update [DocPAS].[dbo].[Users] SET SortKey=40 where UserName='ddr_ym'

update [DocPAS].[dbo].[Users] SET SortKey=41 where UserName='ddr_bud'


update [DocPAS].[dbo].[Users] SET SortKey=43 where UserName='ddr_nagpur'

update [DocPAS].[dbo].[Users] SET SortKey=44 where UserName='ddr_wrdh'

update [DocPAS].[dbo].[Users] SET SortKey=45 where UserName='ddr_chdr'

update [DocPAS].[dbo].[Users] SET SortKey=46 where UserName='ddr_bhan'

update [DocPAS].[dbo].[Users] SET SortKey=47 where UserName='ddr_gond'

update [DocPAS].[dbo].[Users] SET SortKey=48 where UserName='ddr_gad'


update [DocPAS].[dbo].[Users] SET SortKey=7 where UserName='ddr_palghar'

update [DocPAS].[dbo].[Users] SET SortKey=8 where UserName='ddr_thn'

update [DocPAS].[dbo].[Users] SET SortKey=9 where UserName='ddr_rtg'

update [DocPAS].[dbo].[Users] SET SortKey=10 where UserName='ddr_rgd'

update [DocPAS].[dbo].[Users] SET SortKey=11 where UserName='ddr_sin'




/* Update Name of the users */

update [DocPAS].[dbo].[Users] SET Name= N'विभागीय सहनिबंधक,सहकारी संस्था, '+ Name Where RoleId=3

update [DocPAS].[dbo].[Users] SET Name= N'जिल्हा उपनिबंधक, सहकारी संस्था, '+ Name Where RoleId=4

update [DocPAS].[dbo].[Users] SET Name= N'सहकार आयुक्त कार्यालय' Where UserName= 'comm1' 

update [DocPAS].[dbo].[Users] SET Name= N'सहकार आयुक्त कार्यालय, Admin' Where UserName= 'admin' 



Update [DocPAS].[dbo].[SubMasterReports]
  Set Appraisal_Percentage = (Appraisal_Marks * 100) / Total_Marks
  where SubjectId=31