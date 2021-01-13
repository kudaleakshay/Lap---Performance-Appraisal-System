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

        private DocPASEntities db = new DocPASEntities();

        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        /*[CustomAuthorize("DDR")]*/
        public ActionResult DepartmentWiseReport()
        {
            AppraisalReportViewModel reports = new AppraisalReportViewModel();
            reports.Subjects = db.Subjects.Where(x => x.Type == 1).ToList();
            return View(reports);
        }

        [HttpPost]
        public ActionResult SubReports(AppraisalReportViewModel reports)
        {
            DateTime date = new DateTime(2020, reports.Month, 1);

            AppraisalReportViewModel SubReports = new AppraisalReportViewModel();
            SubReports.DepartmentId = reports.DepartmentId;

            Session["ReportMonth"] = reports.Month;
            Session["ReportMonthName"] = date.ToString("MMMM");
            Session["ReportYear"] = reports.Year;
            Session["ReportDepartment"] = reports.DepartmentId;

            
            

            SubReports.Subjects = db.Subjects.Where(x => x.Type == 2 && x.DepartmentId == SubReports.DepartmentId).ToList();

            Session["ReportDepartmentName"] = SubReports.Subjects.FirstOrDefault().Department.DepartmentName;

            return View(SubReports);
        }



        [HttpPost]
        public ActionResult GetReportForms(AppraisalReportViewModel reports)
        {
            Session["ReportSubDepartment"] = reports.SubSubjectId;

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

            return View();
        }


        public ActionResult ViewAppraisalReports()
        {
            return View();
        }

        public ActionResult DepartmentReportSelection()
        {
            List<Department> DepartmentList = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(DepartmentList, "Id", "DepartmentName");
            return View();
        }

        public ActionResult ViewOfficeWiseReport()
        {
            return View();
        }

        public JsonResult GetDepartmentWiseSubjects(int? DepartmentId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = db.Subjects.Where(x => x.DepartmentId == DepartmentId && x.Type == 2).ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSubjects()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = db.Subjects.Where(x => x.Type == 2).ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTalukaWiseReport()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = db.Users.ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }



        public Boolean SaveSubMasterReports(SubMasterReport Report, int? RoleId)
        {
            Report.Remarks = getRemark(RoleId);
            db.SubMasterReports.Add(Report);
            db.SaveChanges();
            return true;
        }


        public string getRemark(int? RoleId)
        {
            if(RoleId != null)
            {
                if (!IsReportInTime(RoleId))
                    return "Late";
            }
            return "";
        }


        public Boolean IsReportInTime(int? RoleId)
        {
            int Current_Date = DateTime.Now.Day;

            switch (RoleId)
            {
                case 3:
                    return (Current_Date < 15);

                case 4:
                    return (Current_Date < 10);

                case 5:
                    return (Current_Date < 5);
            }
            return true;
        }
    }
}