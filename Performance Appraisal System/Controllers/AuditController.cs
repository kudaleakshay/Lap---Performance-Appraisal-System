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
    public class AuditController : Controller
    {
        private readonly ReportController reportController = new ReportController();
        private readonly DocPASEntities db = new DocPASEntities();

        public AuditController()
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
                case 35:
                    Report35 record35 = db.Report35
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record35 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }
                    return View("Subject35");

                case 36:
                    Report36 record36 = db.Report36
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record36 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }
                    return View("Subject36");

                case 37:
                    Report37 record37 = db.Report37
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record37 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }
                    return View("Subject37");

                case 38:
                    Report38 record38 = db.Report38
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record38 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }
                    return View("Subject38");

                case 39:
                    Report39 record39 = db.Report39
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record39 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }
                    return View("Subject39");

                case 40:
                    Report40 record40 = db.Report40
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record40 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }
                    return View("Subject40");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Subject35(Report35 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report35.Add(Reports);
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
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
                else
                {
                    //Add Error Handling
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
        public ActionResult Subject36(Report36 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;/*
                Reports.Action_Taken = Reports.Remaining_for_Audit;
                Reports.Current_Month_Remaining_for_Audit = Reports.Eligible_for_Audit - Reports.Current_Month_Audit;*/
                Reports.CreatedTime = DateTime.Now;

                db.Report36.Add(Reports);
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
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
                else
                {
                    //Add Error Handling
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
        public ActionResult Subject37(Report37 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report37.Add(Reports);
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
                    Appraisal_Percentage = Reports.Percentage_Action_Taken,
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
                else
                {
                    //Add Error Handling
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
        public ActionResult Subject38(Report38 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report38.Add(Reports);
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
                    Appraisal_Percentage = Reports.Percentage_Action_Taken,
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
                else
                {
                    //Add Error Handling
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
        public ActionResult Subject39(Report39 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report39.Add(Reports);
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
                    Appraisal_Percentage = Reports.Percentage_Action_Taken,
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
                else
                {
                    //Add Error Handling
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
        public ActionResult Subject40(Report40 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report40.Add(Reports);
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
                    Appraisal_Percentage = Reports.Percentage_Action_Taken,
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
                    return RedirectToAction("DepartmentWiseReport", "Report");
                }
                else
                {
                    //Add Error Handling
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