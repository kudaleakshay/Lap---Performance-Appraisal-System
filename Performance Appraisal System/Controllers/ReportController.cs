using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Models;
using Performance_Appraisal_System.ViewModels;


namespace Performance_Appraisal_System.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        /*[CustomAuthorize("DDR")]*/
        public ActionResult DepartmentWiseReport()
        {
            DocPASEntities db = new DocPASEntities();

            AppraisalReportViewModel reports = new AppraisalReportViewModel();
            reports.Subjects = db.Subjects.Where(x => x.Type == 1).ToList();

            return View(reports);
        }

        [HttpPost]
        public ActionResult SubReports(AppraisalReportViewModel reports)
        {
            DocPASEntities db = new DocPASEntities();
            AppraisalReportViewModel SubReports = new AppraisalReportViewModel();
            SubReports.Month = reports.Month;
            SubReports.Year = reports.Year;
            SubReports.DepartmentId = reports.DepartmentId;
            SubReports.Subjects = db.Subjects.Where(x => x.Type == 2 && x.DepartmentId == SubReports.DepartmentId).ToList();
            return View(SubReports);
        }


        [HttpPost]
        public ActionResult getReportForms(AppraisalReportViewModel reports)
        {
            TempData["ReportData"] = reports;
            switch (reports.DepartmentId)
            {
                case 1:
                    return RedirectToAction("Index", "Establishment");

                case 2:
                    return RedirectToAction("Index", "Krushipat");

                case 3:
                    return RedirectToAction("Index", "IT");

                case 4:
                    return RedirectToAction("Index", "Budget");

                case 5:
                    return RedirectToAction("Index", "Audit");

                case 6:
                    return RedirectToAction("Index", "Law");

                case 7:
                    return RedirectToAction("Index", "Housing");

                case 8:
                    return RedirectToAction("Index", "Credit_Societies");

                case 9:
                    return RedirectToAction("Index", "O_M");

                case 10:
                    return RedirectToAction("Index", "MoneyLending");

            }

            DocPASEntities db = new DocPASEntities();
            AppraisalReportViewModel SubReports = new AppraisalReportViewModel();
            SubReports.Month = reports.Month;
            SubReports.Year = reports.Year;
            SubReports.DepartmentId = reports.DepartmentId;
            SubReports.Subjects = db.Subjects.Where(x => x.Type == 2 && x.DepartmentId == SubReports.DepartmentId).ToList();

            return View(SubReports);
        }



    }
}