using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using Performance_Appraisal_System.Infrastructure;
using Performance_Appraisal_System.Models;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class O_MController : Controller
    {
        ReportController reportController = new ReportController();

        public O_MController()
        {
            var Current_Month = Convert.ToString(DateTime.Now.Month);
            var Current_Year = Convert.ToString(DateTime.Now.Year);

            if(System.Web.HttpContext.Current.Session["ReportMonth"] != null)
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


            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year, 10).Select(x =>
               new SelectListItem()
               {
                   Text = x.ToString(),
                   Value = x.ToString()
               }), "Value", "Text", Current_Year);

        }

        // GET: O_M
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 60:
                    return View("Subject60");

                case 61:
                    return View("Subject61");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Subject60(Sub60 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

                db.Sub60.Add(Reports);
                db.SaveChanges();

                if (reportController.SaveSubMasterReports(PrepareSubMasterReport(Reports), user.RoleId))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }



            }
            else
            {
                ModelState.AddModelError("Error", "Invalid Data");
                return View();
            }
        }


        [HttpPost]
        public ActionResult Subject61()
        {
            return View();
        }

        public SubMasterReport PrepareSubMasterReport(Sub60 Current_Report)
        {
            SubMasterReport Report = new SubMasterReport();
            Report.UId = Current_Report.UId;
            Report.Rid = Current_Report.RId;
            Report.Month = Current_Report.Month;
            Report.Year = Current_Report.Month;
            Report.DepartmentId = 9;
            Report.Appraisal_Marks = Current_Report.Appraisal_Marks;

            return Report;
        }

    }
}