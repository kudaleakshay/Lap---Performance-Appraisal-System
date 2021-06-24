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
    [CustomAuthenticationFilter]
    public class O_MController : Controller
    {
        private readonly ReportController reportController = new ReportController();
        private readonly DocPASEntities db = new DocPASEntities();

        public O_MController()
        {
            var Current_Month = Convert.ToString(DateTime.Now.Month - 1);
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

        // GET: O_M
        public ActionResult Index()
        {
            var Month = Convert.ToInt32(System.Web.HttpContext.Current.Session["ReportMonth"]);
            var Year = Convert.ToInt32(System.Web.HttpContext.Current.Session["ReportYear"]);

            User user = (User)HttpContext.Session["User"];

            switch (Session["ReportSubDepartment"])
            {
                case 60:
                    Report60 record60 = db.Report60
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record60 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject60");

                case 61:
                    Report61 record61 = db.Report61
                                           .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record61 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject61");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Subject60(Report60 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
                Reports.CreatedTime = DateTime.Now;


                SubMasterReport SubReport = new SubMasterReport
                {
                    UId = Reports.UId,
                    Rid = Reports.RId,
                    Month = Reports.Month,
                    Year = Reports.Year,
                    DepartmentId = Convert.ToInt32(Session["ReportDepartment"]),
                    SubjectId = Convert.ToInt32(Session["ReportSubDepartment"]),
                    Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {

                    db.Report60.Add(Reports);
                    db.SaveChanges();
                    TempData["Message"] = "Report Submitted Successfully";
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
                else
                {
                    //Add Error Handling
                    TempData["Error"] = "Something went wrong, Please try again later";
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Invalid Data");
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("DepartmentWiseReport", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject61(Report61 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
                Reports.CreatedTime = DateTime.Now;


                SubMasterReport SubReport = new SubMasterReport
                {
                    UId = Reports.UId,
                    Rid = Reports.RId,
                    Month = Reports.Month,
                    Year = Reports.Year,
                    DepartmentId = Convert.ToInt32(Session["ReportDepartment"]),
                    SubjectId = Convert.ToInt32(Session["ReportSubDepartment"]),
                    Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToInt32(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {

                    db.Report61.Add(Reports);
                    db.SaveChanges();
                    TempData["Message"] = "Report Submitted Successfully";
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
                else
                {
                    //Add Error Handling
                    TempData["Error"] = "Something went wrong, Please try again later";
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Invalid Data");
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("DepartmentWiseReport", "Report");
            }
        }


    }
}