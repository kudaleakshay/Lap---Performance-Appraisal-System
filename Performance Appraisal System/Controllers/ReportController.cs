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