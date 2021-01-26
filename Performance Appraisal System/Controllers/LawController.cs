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
                case 41:
                    return View("Subject41");

                case 42:
                    return View("Subject42");

                case 43:
                    return View("Subject43");

                case 44:
                    return View("Subject44");

                case 45:
                    return View("Subject45");

                case 46:
                    return View("Subject46");

                case 47:
                    return View("Subject47");

                case 48:
                    return View("Subject48");

                case 49:
                    return View("Subject49");

                case 50:
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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject42(Report42 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject43(Report43 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject44(Report44 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject45(Report45 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject46(Report46 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject47(Report47 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject48(Report48 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject49(Report49 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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
        public ActionResult Subject50(Report50 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;

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
                    Total_Marks = Convert.ToDouble(Session["TotalMarks"]),
                    Appraisal_Marks = Reports.Appraisal_Marks,
                    Appraisal_Percentage = Reports.Appraisal_Percentage,
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