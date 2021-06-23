using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Globalization;
using Performance_Appraisal_System.Models;

namespace Performance_Appraisal_System.Controllers
{
    public class ReadOnlyReportsController : Controller
    {
        private readonly DocPASEntities db = new DocPASEntities();

        // GET: ReadOnlyReports
        public ReadOnlyReportsController()
        {
            var Current_Month = Convert.ToString(DateTime.Now.Month);
            var Current_Year = Convert.ToString(DateTime.Now.Year);

            if (System.Web.HttpContext.Current.Session["ReportMonth"] != null)
            {
                Current_Month = Convert.ToString(System.Web.HttpContext.Current.Session["ReportMonth"]);
                Current_Year = Convert.ToString(System.Web.HttpContext.Current.Session["ReportYear"]);
            }

            ViewBag.Months = new SelectList(Enumerable.Range(1, 12).Select(x =>
               new SelectListItem()
               {
                   Text = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[x - 1],
                   Value = x.ToString()
               }), "Value", "Text", Current_Month);


            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year - 2, 10).Select(x =>
                 new SelectListItem()
                 {
                     Text = x.ToString(),
                     Value = x.ToString()
                 }), "Value", "Text", Current_Year);

        }


        public ActionResult ReadOnlyReportView(int UId, int DepartmentId, int SubjectId, int Month, int Year)
        {
            DateTime date = new DateTime(Year, Month, 1);

            Session["ReportMonth"] = Month;
            Session["DisplayMonth"] = date.ToString("MMMM");
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;

           /* Report24 report24 = db.Report24.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();

            var DepartmentData = db.Departments.Where(d => d.Id == DepartmentId).FirstOrDefault();

            ViewBag.Department = DepartmentData.DepartmentName;
            if (report24 == null)
            {
                TempData["Error"] = "No data available, Please try after sometime";
                return RedirectToAction("Index", "Home");
            }

            return View("ReadonlyReport24", report24);*/

             var DepartmentData = db.Departments.Where(d => d.Id == DepartmentId).FirstOrDefault();
             ViewBag.Department = DepartmentData.DepartmentName;

             switch (DepartmentId)
             {
                 case 1:
                     switch (SubjectId)
                     {

                         case 11:

                             Report11 report11 = db.Report11.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();

            				if(report11 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}			

                             ViewBag.SubmitTime = report11.CreatedTime;
                             return View("ReadonlyReport11", report11);

                         case 12:

                             Report12 report12 = db.Report12.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();

                             if(report12 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report12.CreatedTime;
                             return View("ReadonlyReport12", report12);

                         case 13:

                             Report13 report13 = db.Report13.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();

                             if(report13 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report13.CreatedTime;
                             return View("ReadonlyReport13", report13);

                         case 14:

                             Report14 report14 = db.Report14.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report14 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report14.CreatedTime;
                             return View("ReadonlyReport14", report14);

                         case 15:

                             Report15 report15 = db.Report15.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report15 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report15.CreatedTime;
                             return View("ReadonlyReport15", report15);

                         case 16:

                             Report16 report16 = db.Report16.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report16 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report16.CreatedTime;
                             return View("ReadonlyReport16", report16);
                     }
                     break;

                 case 2:
                     switch (SubjectId)
                     {
                         case 17:

                             Report17 report17 = db.Report17.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report17 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report17.CreatedTime;

                             return View("ReadonlyReport17", report17);

                         case 18:

                             Report18 report18 = db.Report18.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report18 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report18.CreatedTime;

                             return View("ReadonlyReport18", report18);

                         case 23:

                             Report23 report23 = db.Report23.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report23 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report23.CreatedTime;

                             return View("ReadonlyReport23", report23);
                     }
                     break;

                 case 3:
                     switch (SubjectId)
                     {
                         case 24:

                             Report24 report24 = db.Report24.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report24 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report24.CreatedTime;

                             return View("ReadonlyReport24", report24);

                         case 25:

                             Report25 report25 = db.Report25.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report25 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report25.CreatedTime;

                             return View("ReadonlyReport25", report25);

                         case 26:

                             Report26 report26 = db.Report26.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report26 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report26.CreatedTime;

                             return View("ReadonlyReport26", report26);

                         case 27:

                             Report27 report27 = db.Report27.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report27 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report27.CreatedTime;

                             return View("ReadonlyReport27", report27);

                         case 28:

                             Report28 report28 = db.Report28.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report28 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report28.CreatedTime;

                             return View("ReadonlyReport28", report28);

                         case 29:

                             Report29 report29 = db.Report29.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report29 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report29.CreatedTime;

                             return View("ReadonlyReport29", report29);
                     }
                     break;

                 case 4:
                     switch (SubjectId)
                     {
                         case 30:

                             Report30 report30 = db.Report30.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report30 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report30.CreatedTime;

                             return View("ReadonlyReport30", report30);

                         case 31:

                             Report31 report31 = db.Report31.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report31 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report31.CreatedTime;

                             return View("ReadonlyReport31", report31);


                         case 34:

                             Report34 report34 = db.Report34.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report34 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report34.CreatedTime;

                             return View("ReadonlyReport34", report34);
                     }
                     break;

                 case 5:
                     switch (SubjectId)
                     {

                         case 35:

                             Report35 report35 = db.Report35.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report35 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report35.CreatedTime;

                             return View("ReadonlyReport35", report35);

                         case 36:

                             Report36 report36 = db.Report36.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report36 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report36.CreatedTime;

                             return View("ReadonlyReport36", report36);

                         case 37:

                             Report37 report37 = db.Report37.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report37 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report37.CreatedTime;

                             return View("ReadonlyReport37", report37);

                         case 38:

                             Report38 report38 = db.Report38.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report38 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report38.CreatedTime;

                             return View("ReadonlyReport38", report38);

                         case 39:

                             Report39 report39 = db.Report39.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report39 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report39.CreatedTime;

                             return View("ReadonlyReport39", report39);

                         case 40:

                             Report40 report40 = db.Report40.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report40 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report40.CreatedTime;

                             return View("ReadonlyReport40", report40);
                     }
                     break;

                 case 6:
                     switch (SubjectId)
                     {
                         case 41:

                             Report41 report41 = db.Report41.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report41 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report41.CreatedTime;

                             return View("ReadonlyReport41", report41);

                         case 42:

                             Report42 report42 = db.Report42.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report42 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report42.CreatedTime;

                             return View("ReadonlyReport42", report42);

                         case 43:

                             Report43 report43 = db.Report43.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report43 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report43.CreatedTime;

                             return View("ReadonlyReport43", report43);

                         case 44:

                             Report44 report44 = db.Report44.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report44 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report44.CreatedTime;

                             return View("ReadonlyReport44", report44);

                         case 45:

                             Report45 report45 = db.Report45.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report45 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report45.CreatedTime;

                             return View("ReadonlyReport45", report45);

                         case 46:

                             Report46 report46 = db.Report46.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report46 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report46.CreatedTime;

                             return View("ReadonlyReport46", report46);

                         case 47:

                             Report47 report47 = db.Report47.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report47 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report47.CreatedTime;

                             return View("ReadonlyReport47", report47);

                         case 48:

                             Report48 report48 = db.Report48.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report48 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report48.CreatedTime;

                             return View("ReadonlyReport48", report48);

                         case 49:

                             Report49 report49 = db.Report49.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report49 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report49.CreatedTime;

                             return View("ReadonlyReport49", report49);

                         case 50:

                             Report50 report50 = db.Report50.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report50 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report50.CreatedTime;

                             return View("ReadonlyReport50", report50);
                     }
                     break;

                 case 7:
                     switch (SubjectId)
                     {
                         case 51:

                             Report51 report51 = db.Report51.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report51 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report51.CreatedTime;

                             return View("ReadonlyReport51", report51);

                         case 52:

                             Report52 report52 = db.Report52.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report52 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report52.CreatedTime;

                             return View("ReadonlyReport52", report52);

                     }
                     break;

                 case 8:
                     switch (SubjectId)
                     {
                         case 53:

                             Report53 report53 = db.Report53.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report53 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report53.CreatedTime;

                             return View("ReadonlyReport53", report53);

                         case 54:

                             Report54 report54 = db.Report54.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report54 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report54.CreatedTime;

                             return View("ReadonlyReport54", report54);


                         case 56:

                             Report56 report56 = db.Report56.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report56 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report56.CreatedTime;

                             return View("ReadonlyReport56", report56);

                         case 57:

                             Report57 report57 = db.Report57.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report57 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report57.CreatedTime;

                             return View("ReadonlyReport57", report57);

                         case 58:

                             Report58 report58 = db.Report58.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report58 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report58.CreatedTime;

                             return View("ReadonlyReport58", report58);

                         case 59:

                             Report59 report59 = db.Report59.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report59 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report59.CreatedTime;

                             return View("ReadonlyReport59", report59);
                     }
                     break;

                 case 9:
                     switch (SubjectId)
                     {
                         case 60:

                             Report60 report60 = db.Report60.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report60 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report60.CreatedTime;

                             return View("ReadonlyReport60", report60);

                         case 61:

                             Report61 report61 = db.Report61.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report61 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report61.CreatedTime;

                             return View("ReadonlyReport61", report61);
                     }
                     break;

                 case 10:
                     switch (SubjectId)
                     {
                         case 62:

                             Report62 report62 = db.Report62.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report62 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report62.CreatedTime;

                             return View("ReadonlyReport62", report62);

                         case 63:

                             Report63 report63 = db.Report63.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report63 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report63.CreatedTime;

                             return View("ReadonlyReport63", report63);

                         case 64:

                             Report64 report64 = db.Report64.Where(r => r.UId == UId && r.Month == Month && r.Year == Year).FirstOrDefault();
                             if(report64 == null)
            				{
            					//Add Error Handling if no data available
                    			TempData["Error"] = "No data available, Please try after sometime";
                    			return RedirectToAction("Index", "Home");
            				}
                             ViewBag.SubmitTime = report64.CreatedTime;

                             return View("ReadonlyReport64", report64);
                     }
                     break;
             }

             return View();
        }
    }
}