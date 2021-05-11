using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Infrastructure;
using Performance_Appraisal_System.Models;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    [CustomAuthenticationFilter]
    public class BudgetController : Controller
    {
        private readonly ReportController reportController = new ReportController();
        private readonly DocPASEntities db = new DocPASEntities();

        public BudgetController()
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


            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year -2, 10).Select(x =>
               new SelectListItem()
               {
                   Text = x.ToString(),
                   Value = x.ToString()
               }), "Value", "Text", Current_Year);

        }

        public ActionResult Index()
        {
            var Month = Convert.ToInt32(System.Web.HttpContext.Current.Session["ReportMonth"]);
            var Year = Convert.ToInt32(System.Web.HttpContext.Current.Session["ReportYear"]);

            User user = (User)HttpContext.Session["User"];

            switch (Session["ReportSubDepartment"])
            {
                case 30:
                    Report30 record30 = db.Report30
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record30 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month +"/"+ Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject30");

                case 31:
                    Report31 record31 = db.Report31
                                      .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record31 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject31");

               
                case 34:
                    Report34 record34 = db.Report34
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record34 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject34");
            }
            return View();
        }


        [HttpPost]
        public ActionResult Subject30(Report30 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report30.Add(Reports);
                db.SaveChanges();

                SubMasterReport SubReport = new SubMasterReport
                {
                    UId = Reports.UId,
                    Rid = Reports.RId,
                    Month = Reports.Month,
                    Year = Reports.Year,
                    DepartmentId = Convert.ToInt32(Session["ReportDepartment"]),
                    SubjectId = Convert.ToInt32(Session["ReportSubDepartment"]),
                    Total_Marks = Reports.NotApplicable ? 0 :Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
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
                return View();
            }
        }


        [HttpPost]
        public ActionResult Subject31(Report31 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report31.Add(Reports);
                db.SaveChanges();

                SubMasterReport SubReport = new SubMasterReport
                {
                    UId = Reports.UId,
                    Rid = Reports.RId,
                    Month = Reports.Month,
                    Year = Reports.Year,
                    DepartmentId = Convert.ToInt32(Session["ReportDepartment"]),
                    SubjectId = Convert.ToInt32(Session["ReportSubDepartment"]),
                    Total_Marks = Reports.NotApplicable ? 0 :Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    /*Appraisal_Percentage = Reports.Appraisal_Percentage,*/
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
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
                return View();
            }
        }


        [HttpPost]
        public ActionResult Subject34(Report34 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report34.Add(Reports);
                db.SaveChanges();

                SubMasterReport SubReport = new SubMasterReport
                {
                    UId = Reports.UId,
                    Rid = Reports.RId,
                    Month = Reports.Month,
                    Year = Reports.Year,
                    DepartmentId = Convert.ToInt32(Session["ReportDepartment"]),
                    SubjectId = Convert.ToInt32(Session["ReportSubDepartment"]),
                    Total_Marks = Reports.NotApplicable ? 0 :Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
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
                return View();
            }
        }
    }
}