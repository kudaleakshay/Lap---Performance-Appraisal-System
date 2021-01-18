using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Models;

namespace Performance_Appraisal_System.Controllers
{
    public class ReportViewController : Controller
    {
        private DocPASEntities db = new DocPASEntities();

        public ReportViewController()
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


            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year-2, 10).Select(x =>
               new SelectListItem()
               {
                   Text = x.ToString(),
                   Value = x.ToString()
               }), "Value", "Text", Current_Year);

        }

        // GET: ReportView
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult GetDepartmentReportView(int DepartmentId, int SubjectId)
        {
            ViewBag.DepartmentId = DepartmentId;
            ViewBag.SubjectId = SubjectId;

            switch (DepartmentId)
            {
                case 1:
                    switch (SubjectId)
                    {
                        case 11:
                            return View("Report11");

                        case 12:
                            return View("Report12");

                        case 13:
                            return View("Report13");

                        case 14:
                            return View("Report14");

                        case 15:
                            return View("Report15");

                        case 16:
                            return View("Report16");
                    }
                    return View();

                case 2:
                    switch (SubjectId)
                    {
                        case 17:
                            return View("Report17");

                        case 18:
                            return View("Report18");

                        case 19:
                            return View("Report19");

                        case 20:
                            return View("Report20");

                        case 21:
                            return View("Report21");

                        case 22:
                            return View("Report22");

                        case 23:
                            return View("Report23");
                    }
                    return View();

                case 3:
                    switch (SubjectId)
                    {
                        case 24:
                            return View("Report24");

                        case 25:
                            return View("Report25");

                        case 26:
                            return View("Report26");

                        case 27:
                            return View("Report27");

                        case 28:
                            return View("Report28");

                        case 29:
                            return View("Report29");
                    }
                    return View();

                case 4:
                    switch (SubjectId)
                    {
                        case 30:
                            return View("Report30");

                        case 31:
                            return View("Report31");

                        case 32:
                            return View("Report32");

                        case 33:
                            return View("Report33");

                        case 34:
                            return View("Report34");
                    }
                    return View();

                case 5:
                    switch (SubjectId)
                    {
                        case 35:
                            return View("Report35");

                        case 26:
                            return View("Report36");

                        case 37:
                            return View("Report37");

                        case 38:
                            return View("Report38");

                        case 39:
                            return View("Report39");

                        case 40:
                            return View("Report40");
                    }
                    return View();

                case 6:
                    switch (SubjectId)
                    {
                        case 41:
                            return View("Report41");

                        case 42:
                            return View("Report42");

                        case 43:
                            return View("Report43");

                        case 44:
                            return View("Report44");

                        case 45:
                            return View("Report45");

                        case 46:
                            return View("Report46");

                        case 47:
                            return View("Report47");

                        case 48:
                            return View("Report48");

                        case 49:
                            return View("Report49");

                        case 50:
                            return View("Report50");
                    }
                    return View();

                case 7:
                    switch (SubjectId)
                    {
                        case 51:
                            return View("Report51");

                        case 52:
                            return View("Report52");
                    }
                    return View();

                case 8:
                    switch (SubjectId)
                    {
                        case 53:
                            return View("Report53");

                        case 54:
                            return View("Report54");

                        case 55:
                            return View("Report55");

                        case 56:
                            return View("Report56");

                        case 57:
                            return View("Report57");

                        case 58:
                            return View("Report58");

                        case 59:
                            return View("Report59");
                    }
                    return View();

                case 9:
                    switch (SubjectId)
                    {
                        case 60:
                            return View("Report60");

                        case 61:
                            return View("Report61");
                    }
                    return View();

                case 10:
                    switch (SubjectId)
                    {
                        case 62:
                            return View("Report62");

                        case 63:
                            return View("Report63");

                        case 64:
                            return View("Report64");
                    }
                    return View();
            }

            return View();
        }



        public JsonResult GetDepartmentReportData(int DepartmentId, int SubjectId, int Month, int Year)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = (from s in db.Sub60
                           join u in db.Users
                           on s.UId equals u.UId
                           where s.Month == Month
                           select new
                           {
                               report = s,
                               UserName = u.Name,
                           }).ToList();



            switch (DepartmentId)
            {
                case 1:
                    switch (SubjectId)
                    {
                        case 11:
                            break;

                        case 12:
                            break;

                        case 13:
                            break;

                        case 14:
                            break;

                        case 15:
                            break;

                        case 16:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 2:
                    switch (SubjectId)
                    {
                        case 17:
                            break;

                        case 18:
                            break;

                        case 19:
                            break;

                        case 20:
                            break;

                        case 21:
                            break;

                        case 22:
                            break;

                        case 23:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 3:
                    switch (SubjectId)
                    {
                        case 24:
                            break;

                        case 25:
                            break;

                        case 26:
                            break;

                        case 27:
                            break;

                        case 28:
                            break;

                        case 29:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 4:
                    switch (SubjectId)
                    {
                        case 30:
                            break;

                        case 31:
                            break;

                        case 32:
                            break;

                        case 33:
                            break;

                        case 34:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 5:
                    switch (SubjectId)
                    {
                        case 35:
                            break;

                        case 26:
                            break;

                        case 37:
                            break;

                        case 38:
                            break;

                        case 39:
                            break;

                        case 40:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 6:
                    switch (SubjectId)
                    {
                        case 41:
                            break;

                        case 42:
                            break;

                        case 43:
                            break;

                        case 44:
                            break;

                        case 45:
                            break;

                        case 46:
                            break;

                        case 47:
                            break;

                        case 48:
                            break;

                        case 49:
                            break;

                        case 50:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 7:
                    switch (SubjectId)
                    {
                        case 51:
                            break;

                        case 52:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 8:
                    switch (SubjectId)
                    {
                        case 53:
                            break;

                        case 54:
                            break;

                        case 55:
                            break;

                        case 56:
                            break;

                        case 57:
                            break;

                        case 58:
                            break;

                        case 59:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 9:
                    switch (SubjectId)
                    {
                        case 60:
                            reports = (from s in db.Sub60
                                       join u in db.Users
                                       on s.UId equals u.UId
                                       where s.Month == Month
                                             && s.Year == Year
                                       orderby s.UId
                                       select new
                                       {
                                           report = s,
                                           UserName = u.Name,
                                       }).ToList();

                            break;

                        case 61:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);

                case 10:
                    switch (SubjectId)
                    {
                        case 62:
                            break;

                        case 63:
                            break;

                        case 64:
                            break;
                    }
                    return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
            }

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetOfficeReportView(int UId)
        {
            User user = db.Users
                                       .Where(u => u.UId == UId)
                                       .FirstOrDefault();
            ViewBag.UserName = user.Name;
            ViewBag.UId = UId;
            return View();
        }


        public JsonResult GetOfficeReportData(int UId, int Month, int Year)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = (from s in db.SubMasterReports
                           join d in db.Departments
                           on s.DepartmentId equals d.Id
                           where s.Month == Month
                                 && s.Year == Year
                                 && s.UId == UId
                           orderby s.DepartmentId
                           select new
                           {
                               report = s,
                               Department = d.DepartmentName,
                           }).ToList();

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }
    }
}