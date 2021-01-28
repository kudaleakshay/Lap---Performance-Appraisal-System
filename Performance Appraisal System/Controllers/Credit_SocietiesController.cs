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
    public class Credit_SocietiesController : Controller
    {
        private readonly ReportController reportController = new ReportController();
        private readonly DocPASEntities db = new DocPASEntities();

        public Credit_SocietiesController()
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

            switch (Session["ReportSubDepartment"])
            {
                case 53:
                    Report53 record53 = db.Report53
                                         .Where(u => u.Month == Month && u.Year == Year)
                                         .FirstOrDefault();

                    if (record53 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }

                    return View("Subject53");

                case 54:
                    Report54 record54 = db.Report54
                                     .Where(u => u.Month == Month && u.Year == Year)
                                     .FirstOrDefault();

                    if (record54 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }

                    return View("Subject54");


                case 56:
                    Report56 record56 = db.Report56
                                         .Where(u => u.Month == Month && u.Year == Year)
                                         .FirstOrDefault();

                    if (record56 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }

                    return View("Subject56");

                case 57:
                    Report57 record57 = db.Report57
                                         .Where(u => u.Month == Month && u.Year == Year)
                                         .FirstOrDefault();

                    if (record57 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }

                    return View("Subject57");

                case 58:
                    Report58 record58 = db.Report58
                                         .Where(u => u.Month == Month && u.Year == Year)
                                         .FirstOrDefault();

                    if (record58 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }

                    return View("Subject58");

                case 59:
                    Report59 record59 = db.Report59
                                         .Where(u => u.Month == Month && u.Year == Year)
                                         .FirstOrDefault();

                    if (record59 != null)
                    {
                        ViewBag.isReportSubmitted = true;
                    }

                    return View("Subject59");
               
            }
            return View();
        }


        [HttpPost]
        public ActionResult Subject53(Report53 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report53.Add(Reports);
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
        public ActionResult Subject54(Report54 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report54.Add(Reports);
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
        public ActionResult Subject56(Report56 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report56.Add(Reports);
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
        public ActionResult Subject57(Report57 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report57.Add(Reports);
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
        public ActionResult Subject58(Report58 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report58.Add(Reports);
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
        public ActionResult Subject59(Report59 Reports)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();

                User user = (User)HttpContext.Session["User"];

                Reports.UId = user.UId;
				Reports.CreatedTime = DateTime.Now;

                db.Report59.Add(Reports);
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