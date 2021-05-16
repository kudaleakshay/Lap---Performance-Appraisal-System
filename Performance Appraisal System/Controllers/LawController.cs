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
    public class LawController : Controller
    {
        private readonly ReportController reportController = new ReportController();
        private readonly DocPASEntities db = new DocPASEntities();

        public LawController()
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
                case 41:
                    Report41 record41 = db.Report41
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record41 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject41");

                case 42:
                    Report42 record42 = db.Report42
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record42 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject42");

                case 43:
                    Report43 record43 = db.Report43
                                      .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record43 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject43");

                case 44:
                    Report44 record44 = db.Report44
                                      .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record44 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject44");

                case 45:
                    Report45 record45 = db.Report45
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record45 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject45");

                case 46:
                    Report46 record46 = db.Report46
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record46 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject46");

                case 47:
                    Report47 record47 = db.Report47
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record47 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject47");

                case 48:
                    Report48 record48 = db.Report48
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record48 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject48");

                case 49:
                    Report49 record49 = db.Report49
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record49 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject49");

                case 50:
                    Report50 record50 = db.Report50
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record50 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }
                    return View("Subject50");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Subject41(Report41 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report41.Add(Reports);
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
        public ActionResult Subject42(Report42 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report42.Add(Reports);
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
        public ActionResult Subject43(Report43 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report43.Add(Reports);
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
        public ActionResult Subject44(Report44 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report44.Add(Reports);
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
        public ActionResult Subject45(Report45 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report45.Add(Reports);
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
        public ActionResult Subject46(Report46 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report46.Add(Reports);
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
        public ActionResult Subject47(Report47 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report47.Add(Reports);
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
        public ActionResult Subject48(Report48 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report48.Add(Reports);
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
        public ActionResult Subject49(Report49 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report49.Add(Reports);
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
        public ActionResult Subject50(Report50 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report50.Add(Reports);
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