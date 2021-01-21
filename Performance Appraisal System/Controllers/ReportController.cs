using System;
using System.Collections.Generic;
using System.Globalization;
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

        public ReportController()
        {
            var Current_Month = Convert.ToString(DateTime.Now.Month-1);
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

        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        /*[CustomAuthorize("DDR")]*/
        public ActionResult DepartmentWiseReport()
        {
            User user = (User)HttpContext.Session["User"];

            AppraisalReportViewModel reports = new AppraisalReportViewModel();
            reports.Subjects = (from s in db.Subjects
                                join d in db.DepartmentMappings
                                on s.DepartmentId equals d.DId
                                where d.Type3 == 1
                                && s.Type == 1
                                select s).ToList();

            switch (user.AppraisalType)
            {
                case 1:
                    reports.Subjects = (from s in db.Subjects
                                        join d in db.DepartmentMappings
                                        on s.DepartmentId equals d.DId
                                        where d.Type1 == 1
                                        && s.Type == 1
                                        select s).ToList();
                    break;

                case 2:
                    reports.Subjects = (from s in db.Subjects
                                        join d in db.DepartmentMappings
                                        on s.DepartmentId equals d.DId
                                        where d.Type2 == 1
                                        && s.Type == 1
                                        select s).ToList();
                    break;
            }
           
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

            SetAppraisalMarks(reports.SubSubjectId, Convert.ToInt32(Session["AppraisalType"]));

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

        public ActionResult OfficeReportSelection()
        {
            return View();
        }

        public JsonResult GetDJROfficeData()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = db.Users.Where(x => x.RoleId == 3).ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDDROfficeData()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = db.Users.Where(x => x.RoleId == 4).ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAROfficeData()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = db.Users.Where(x => x.RoleId == 5).ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
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

        public Boolean SaveSubMasterReports(SubMasterReport Report, int? RoleId)
        {
            Report.Remarks = getRemark(RoleId);
            db.SubMasterReports.Add(Report);
            db.SaveChanges();
            return true;
        }


        public string getRemark(int? RoleId)
        {
            if (RoleId != null)
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

        public void SetAppraisalMarks(int SId, int AppraisalType){
            Subjects_MarksMapping Marks = db.Subjects_MarksMapping.Where(x => x.SId == SId && x.AType == AppraisalType).FirstOrDefault(); ;
            Session["TotalMarks"] = Marks.Marks;
        }

    }
}