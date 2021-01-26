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
    public class MoneyLendingController : Controller
    {
        private readonly ReportController reportController = new ReportController();
        private readonly DocPASEntities db = new DocPASEntities();

        public MoneyLendingController()
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


            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year, 10).Select(x =>
               new SelectListItem()
               {
                   Text = x.ToString(),
                   Value = x.ToString()
               }), "Value", "Text", Current_Year);

        }

        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 62:
                    return View("Subject62");

                case 63:
                    return View("Subject63");

                case 64:
                    return View("Subject64");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Subject62(Report62 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

                db.Report62.Add(Reports);
                db.SaveChanges();

                SubMasterReport SubReport = new SubMasterReport
                {
                    UId = Reports.UId,
                    Rid = Reports.RId,
                    Month = Reports.Month,
                    Year = Reports.Year,
                    DepartmentId = Convert.ToInt32(Session["ReportDepartment"]),
                    SubjectId = Convert.ToInt32(Session["ReportSubDepartment"]),
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    /*Appraisal_Percentage = Reports.Appraisal_Percentage,*/
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //Add Error Handling
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
        public ActionResult Subject63(Report63 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

                db.Report63.Add(Reports);
                db.SaveChanges();

                SubMasterReport SubReport = new SubMasterReport
                {
                    UId = Reports.UId,
                    Rid = Reports.RId,
                    Month = Reports.Month,
                    Year = Reports.Year,
                    DepartmentId = Convert.ToInt32(Session["ReportDepartment"]),
                    SubjectId = Convert.ToInt32(Session["ReportSubDepartment"]),
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    /*Appraisal_Percentage = Reports.Appraisal_Percentage,*/
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //Add Error Handling
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
        public ActionResult Subject64(Report64 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

                db.Report64.Add(Reports);
                db.SaveChanges();

                SubMasterReport SubReport = new SubMasterReport
                {
                    UId = Reports.UId,
                    Rid = Reports.RId,
                    Month = Reports.Month,
                    Year = Reports.Year,
                    DepartmentId = Convert.ToInt32(Session["ReportDepartment"]),
                    SubjectId = Convert.ToInt32(Session["ReportSubDepartment"]),
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    /*Appraisal_Percentage = Reports.Appraisal_Percentage,*/
                    Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0,
                };

                if (reportController.SaveSubMasterReports(SubReport, user.RoleId))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    //Add Error Handling
                    return RedirectToAction("Index", "Home");
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