﻿using System;
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
    public class EstablishmentController : Controller
    {
        private readonly ReportController reportController = new ReportController();
        private readonly DocPASEntities db = new DocPASEntities();

        public EstablishmentController()
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

        public ActionResult Index()
        {
            var Month = Convert.ToInt32(System.Web.HttpContext.Current.Session["ReportMonth"]);
            var Year = Convert.ToInt32(System.Web.HttpContext.Current.Session["ReportYear"]);

            User user = (User)HttpContext.Session["User"];

            switch (Session["ReportSubDepartment"])
            {
                case 11:
                    Report11 record11 = db.Report11
                                          .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record11 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject11");

                case 12:
                    Report12 record12 = db.Report12
                                      .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record12 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject12");

                case 13:
                    Report13 record13 = db.Report13
                                      .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record13 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject13");

                case 14:
                    Report14 record14 = db.Report14
                                      .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record14 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject14");

                case 15:
                    Report15 record15 = db.Report15
                                      .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault(); ;

                    if (record15 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject15");

                case 16:
                    Report16 record16 = db.Report16
                                      .Where(u => u.Month == Month && u.Year == Year && u.UId == user.UId)
                                          .FirstOrDefault();

                    if (record16 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                        TempData["Error"] = "You already submitted report for this month- " + Month + "/" + Year;
                        return RedirectToAction("DepartmentWiseReport", "Report");
                    }

                    return View("Subject16");
            }
            return View();
        }


        [HttpPost]
        public ActionResult Subject11(Report11 Reports)
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

                    db.Report11.Add(Reports);
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
        public ActionResult Subject12(Report12 Reports)
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

                    db.Report12.Add(Reports);
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
        public ActionResult Subject13(Report13 Reports)
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

                    db.Report13.Add(Reports);
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
        public ActionResult Subject14(Report14 Reports)
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

                    db.Report14.Add(Reports);
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
        public ActionResult Subject15(Report15 Reports)
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

                    db.Report15.Add(Reports);
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
        public ActionResult Subject16(Report16 Reports)
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

                    db.Report16.Add(Reports);
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