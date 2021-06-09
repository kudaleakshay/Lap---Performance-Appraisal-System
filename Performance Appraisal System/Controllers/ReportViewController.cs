using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Infrastructure;
using Performance_Appraisal_System.Models;

namespace Performance_Appraisal_System.Controllers
{
    [CustomAuthenticationFilter]
    public class ReportViewController : Controller
    {
        private readonly DocPASEntities db = new DocPASEntities();

        public ReportViewController()
        {
            var Current_Month = Convert.ToString(DateTime.Now.Month);
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

        // GET: ReportView
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetDepartmentReportView(int DepartmentId, int SubjectId)
        {
            ViewBag.DepartmentId = DepartmentId;
            ViewBag.SubjectId = SubjectId;

            switch (DepartmentId)
            {
                case 1:
                    switch (SubjectId)
                    {
                        case 11:
                            return View("Report11");

                        case 12:
                            return View("Report12");

                        case 13:
                            return View("Report13");

                        case 14:
                            return View("Report14");

                        case 15:
                            return View("Report15");

                        case 16:
                            return View("Report16");
                    }
                    return View();

                case 2:
                    switch (SubjectId)
                    {
                        case 17:
                            return View("Report17");

                        case 18:
                            return View("Report18");

                        case 19:
                            return View("Report19");

                        case 20:
                            return View("Report20");

                        case 21:
                            return View("Report21");

                        case 22:
                            return View("Report22");

                        case 23:
                            return View("Report23");
                    }
                    return View();

                case 3:
                    switch (SubjectId)
                    {
                        case 24:
                            return View("Report24");

                        case 25:
                            return View("Report25");

                        case 26:
                            return View("Report26");

                        case 27:
                            return View("Report27");

                        case 28:
                            return View("Report28");

                        case 29:
                            return View("Report29");
                    }
                    return View();

                case 4:
                    switch (SubjectId)
                    {
                        case 30:
                            return View("Report30");

                        case 31:
                            return View("Report31");

                        case 32:
                            return View("Report32");

                        case 33:
                            return View("Report33");

                        case 34:
                            return View("Report34");
                    }
                    return View();

                case 5:
                    switch (SubjectId)
                    {
                        case 35:
                            return View("Report35");

                        case 36:
                            return View("Report36");

                        case 37:
                            return View("Report37");

                        case 38:
                            return View("Report38");

                        case 39:
                            return View("Report39");

                        case 40:
                            return View("Report40");
                    }
                    return View();

                case 6:
                    switch (SubjectId)
                    {
                        case 41:
                            return View("Report41");

                        case 42:
                            return View("Report42");

                        case 43:
                            return View("Report43");

                        case 44:
                            return View("Report44");

                        case 45:
                            return View("Report45");

                        case 46:
                            return View("Report46");

                        case 47:
                            return View("Report47");

                        case 48:
                            return View("Report48");

                        case 49:
                            return View("Report49");

                        case 50:
                            return View("Report50");
                    }
                    return View();

                case 7:
                    switch (SubjectId)
                    {
                        case 51:
                            return View("Report51");

                        case 52:
                            return View("Report52");
                    }
                    return View();

                case 8:
                    switch (SubjectId)
                    {
                        case 53:
                            return View("Report53");

                        case 54:
                            return View("Report54");

                        case 55:
                            return View("Report55");

                        case 56:
                            return View("Report56");

                        case 57:
                            return View("Report57");

                        case 58:
                            return View("Report58");

                        case 59:
                            return View("Report59");
                    }
                    return View();

                case 9:
                    switch (SubjectId)
                    {
                        case 60:
                            return View("Report60");

                        case 61:
                            return View("Report61");
                    }
                    return View();

                case 10:
                    switch (SubjectId)
                    {
                        case 62:
                            return View("Report62");

                        case 63:
                            return View("Report63");

                        case 64:
                            return View("Report64");
                    }
                    return View();
            }

            return View();
        }


        public JsonResult GetDepartmentReportData(int DepartmentId, int SubjectId, int Month, int Year)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;


            switch (DepartmentId)
            {
                case 1:
                    switch (SubjectId)
                    {
                        case 11:
                            return Json(new
                            {
                                data = (from s in db.Report11
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 12:
                            return Json(new
                            {
                                data = (from s in db.Report12
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 13:
                            return Json(new
                            {
                                data = (from s in db.Report13
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 14:
                            return Json(new
                            {
                                data = (from s in db.Report14
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 15:
                            return Json(new
                            {
                                data = (from s in db.Report15
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 16:
                            return Json(new
                            {
                                data = (from s in db.Report16
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                    }
                    break;

                case 2:
                    switch (SubjectId)
                    {
                        case 17:
                            return Json(new
                            {
                                data = (from s in db.Report17
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 18:
                            return Json(new
                            {
                                data = (from s in db.Report18
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 23:
                            return Json(new
                            {
                                data = (from s in db.Report23
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 3:
                    switch (SubjectId)
                    {
                        case 24:
                            return Json(new
                            {
                                data = (from s in db.Report24
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 25:
                            return Json(new
                            {
                                data = (from s in db.Report25
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 26:
                            return Json(new
                            {
                                data = (from s in db.Report26
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 27:
                            return Json(new
                            {
                                data = (from s in db.Report27
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 28:
                            return Json(new
                            {
                                data = (from s in db.Report28
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 29:
                            return Json(new
                            {
                                data = (from s in db.Report29
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 4:
                    switch (SubjectId)
                    {
                        case 30:
                            return Json(new
                            {
                                data = (from s in db.Report30
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 31:
                            return Json(new
                            {
                                data = (from s in db.Report31
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 34:
                            return Json(new
                            {
                                data = (from s in db.Report34
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 5:
                    switch (SubjectId)
                    {
                        case 35:
                            return Json(new
                            {
                                data = (from s in db.Report35
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 36:
                            return Json(new
                            {
                                data = (from s in db.Report36
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 37:
                            return Json(new
                            {
                                data = (from s in db.Report37
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 38:
                            return Json(new
                            {
                                data = (from s in db.Report38
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 39:
                            return Json(new
                            {
                                data = (from s in db.Report39
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 40:
                            return Json(new
                            {
                                data = (from s in db.Report40
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 6:
                    switch (SubjectId)
                    {
                        case 41:
                            return Json(new
                            {
                                data = (from s in db.Report41
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 42:
                            return Json(new
                            {
                                data = (from s in db.Report42
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 43:
                            return Json(new
                            {
                                data = (from s in db.Report43
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 44:
                            return Json(new
                            {
                                data = (from s in db.Report44
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 45:
                            return Json(new
                            {
                                data = (from s in db.Report45
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 46:
                            return Json(new
                            {
                                data = (from s in db.Report46
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 47:
                            return Json(new
                            {
                                data = (from s in db.Report47
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 48:
                            return Json(new
                            {
                                data = (from s in db.Report48
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 49:
                            return Json(new
                            {
                                data = (from s in db.Report49
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 50:
                            return Json(new
                            {
                                data = (from s in db.Report50
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 7:
                    switch (SubjectId)
                    {
                        case 51:
                            return Json(new
                            {
                                data = (from s in db.Report51
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 52:
                            return Json(new
                            {
                                data = (from s in db.Report52
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 8:
                    switch (SubjectId)
                    {
                        case 53:
                            return Json(new
                            {
                                data = (from s in db.Report53
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 54:
                            return Json(new
                            {
                                data = (from s in db.Report54
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 56:
                            return Json(new
                            {
                                data = (from s in db.Report56
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 57:
                            return Json(new
                            {
                                data = (from s in db.Report57
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 58:
                            return Json(new
                            {
                                data = (from s in db.Report58
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 59:
                            return Json(new
                            {
                                data = (from s in db.Report59
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 9:
                    switch (SubjectId)
                    {
                        case 60:
                            return Json(new
                            {
                                data = (from s in db.Report60
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 61:
                            return Json(new
                            {
                                data = (from s in db.Report61
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 10:
                    switch (SubjectId)

                    {
                        case 62:
                            return Json(new
                            {
                                data = (from s in db.Report62
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 63:
                            return Json(new
                            {
                                data = (from s in db.Report63
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 64:
                            return Json(new
                            {
                                data = (from s in db.Report64
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year && s.NotApplicable == false
                                        orderby u.SortKey ascending
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                            RoleId = u.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;
            }

            return Json(new { data = "" }, JsonRequestBehavior.AllowGet);

        }


        public ActionResult PendingReportListView(String SubjectName, int? DepartmentId, int? SubjectId, int? Month, int? Year)
        {
            var Current_Month = Convert.ToString(DateTime.Now.Month - 1);
            var Current_Year = Convert.ToString(DateTime.Now.Year);

            if (Month != null)
            {
                Current_Month = Convert.ToString(Month);
            }
            if (Year != null)
            {
                Current_Month = Convert.ToString(Year);
            }

            if (System.Web.HttpContext.Current.Session["ReportMonth"] != null)
            {
                Current_Month = Convert.ToString(System.Web.HttpContext.Current.Session["ReportMonth"]);
                Current_Year = Convert.ToString(System.Web.HttpContext.Current.Session["ReportYear"]);
            }
            else if (DateTime.Now.Month == 1)
            {
                Current_Month = Convert.ToString(12);
                Current_Year = Convert.ToString(DateTime.Now.Year - 1);
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

            ViewBag.DepartmentId = DepartmentId;
            ViewBag.SubjectName = SubjectName;
            ViewBag.SubjectId = SubjectId;


            return View();
        }


        public ActionResult DetailReportView(String UserName, int? UId, int? Month, int? Year)
        {
            var Current_Month = Convert.ToString(DateTime.Now.Month - 1);
            var Current_Year = Convert.ToString(DateTime.Now.Year);

            if (Month != null)
            {
                Current_Month = Convert.ToString(Month);
            }
            if (Year != null)
            {
                Current_Month = Convert.ToString(Year);
            }

            if (System.Web.HttpContext.Current.Session["ReportMonth"] != null)
            {
                Current_Month = Convert.ToString(System.Web.HttpContext.Current.Session["ReportMonth"]);
                Current_Year = Convert.ToString(System.Web.HttpContext.Current.Session["ReportYear"]);
            }
            else if (DateTime.Now.Month == 1)
            {
                Current_Month = Convert.ToString(12);
                Current_Year = Convert.ToString(DateTime.Now.Year - 1);
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

            db.Configuration.ProxyCreationEnabled = false;
            var reports = (from r in db.DepartmentMasterReports
                           where r.Month == Month
                                && r.Year == Year && r.UId == UId
                           group r by r.UId into GroupReport
                           select new
                           {
                               Appraisal_Marks = GroupReport.Sum(x => x.Appraisal_Marks).ToString().Trim(),
                               Total_Marks = (100 - GroupReport.Sum(x => x.Not_Applicable_Marks)),
                               Appraisal_Percentage = Math.Round((Double)((GroupReport.Sum(x => x.Appraisal_Marks) * 100) / (100 - GroupReport.Sum(x => x.Not_Applicable_Marks))), 2),

                           }).ToList();

            ViewBag.UId = UId;
            ViewBag.UserName = UserName;
            ViewBag.Total = reports[0].Total_Marks;
            ViewBag.AppraisalMarks = reports[0].Appraisal_Marks;
            ViewBag.Appraisal_Percentage = reports[0].Appraisal_Percentage;

            return View();
        }


        public JsonResult GetDetailReportData(int? UId, int? Month, int? Year)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;

            var reports = (from r in db.SubMasterReports
                           join s in db.Subjects
                           on r.SubjectId equals s.SId
                           where r.Month == Month
                                 && r.Year == Year
                                 && r.UId == UId
                                 && r.Not_Applicable_Marks == 0
                                 && s.Type == 2
                           orderby r.DepartmentId
                           select new
                           {
                               report = r,
                               DepartmentName = r.Department.DepartmentName,
                               Appraisal_Percentage = Math.Round((Double)((r.Appraisal_Marks * 100) / r.Total_Marks), 2),
                               Subject = s.SubjectName,
                           }).ToList();

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetPendingReportData(String DepartmentName, int DepartmentId, int SubjectId, int Month, int Year)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;

            var AvailableUsers = db.Users.Where(u => u.Status == 1 && u.RoleId != 2).ToList();

            switch (DepartmentId)
            {
                case 1:
                    switch (SubjectId)
                    {

                        case 11:

                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report11.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 12:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report12.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 13:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report13.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 14:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report14.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 15:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report15.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 16:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report16.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 2:

                    AvailableUsers = db.Users.Where(u => u.AppraisalType != 1 && u.Status == 1 && u.RoleId != 2).ToList();

                    switch (SubjectId)
                    {
                        case 17:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report17.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 18:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report18.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 23:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report23.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 3:
                    switch (SubjectId)
                    {
                        case 24:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report24.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 25:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report25.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 26:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report26.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 27:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report27.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 28:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report28.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 29:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report29.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 4:
                    switch (SubjectId)
                    {
                        case 30:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report30.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 31:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report31.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 34:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report34.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 5:
                    switch (SubjectId)
                    {
                        case 35:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report35.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 36:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report36.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 37:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report37.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 38:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report38.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 39:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report39.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 40:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report40.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 6:
                    switch (SubjectId)
                    {
                        case 41:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report41.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 42:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report42.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 43:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report43.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 44:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report44.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 45:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report45.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 46:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report46.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 47:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report47.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 48:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report48.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 49:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report49.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 50:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report50.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 7:

                    AvailableUsers = db.Users.Where(u => u.AppraisalType != 2 && u.Status == 1 && u.RoleId != 2).ToList();

                    switch (SubjectId)
                    {
                        case 51:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report51.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 52:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report52.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 8:
                    switch (SubjectId)
                    {
                        case 53:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report53.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 54:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report54.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 56:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report56.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 57:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report57.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 58:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report58.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 59:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report59.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 9:
                    switch (SubjectId)
                    {
                        case 60:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report60.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 61:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report61.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 10:
                    switch (SubjectId)

                    {
                        case 62:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report62.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 63:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report63.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 64:
                            return Json(new
                            {
                                data = (from User in AvailableUsers
                                        where !db.Report64.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;
            }

            return Json(new { data = "" }, JsonRequestBehavior.AllowGet);

        }


        public JsonResult GetNotApplicableReportData(String DepartmentName, int DepartmentId, int SubjectId, int Month, int Year)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;


            switch (DepartmentId)
            {
                case 1:
                    switch (SubjectId)
                    {
                        case 11:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report11.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 12:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report12.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 13:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report13.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 14:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report14.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 15:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report15.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 16:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report16.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                    }
                    break;

                case 2:
                    switch (SubjectId)
                    {
                        case 17:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report17.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 18:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report18.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 23:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report23.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 3:
                    switch (SubjectId)
                    {
                        case 24:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report24.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 25:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report25.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 26:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report26.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 27:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report27.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 28:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report28.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 29:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report29.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 4:
                    switch (SubjectId)
                    {
                        case 30:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report30.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 31:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report31.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 34:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report34.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 5:
                    switch (SubjectId)
                    {
                        case 35:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report35.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 36:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report36.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 37:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report37.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 38:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report38.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 39:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report39.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 40:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report40.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 6:
                    switch (SubjectId)
                    {
                        case 41:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report41.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 42:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report42.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 43:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report43.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 44:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report44.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 45:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report45.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 46:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report46.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 47:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report47.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 48:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report48.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 49:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report49.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 50:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report50.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 7:
                    switch (SubjectId)
                    {
                        case 51:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report51.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 52:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report52.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 8:
                    switch (SubjectId)
                    {
                        case 53:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report53.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 54:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report54.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 56:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report56.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 57:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report57.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 58:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report58.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 59:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report59.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 9:
                    switch (SubjectId)
                    {
                        case 60:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report60.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 61:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report61.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;

                case 10:
                    switch (SubjectId)

                    {
                        case 62:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report62.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 63:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report63.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);

                        case 64:
                            return Json(new
                            {
                                data = (from User in db.Users
                                        where db.Report64.Any(f => f.UId == User.UId && f.Month == Month && f.Year == Year && f.NotApplicable == true)
                                        orderby User.SortKey ascending
                                        select new
                                        {
                                            UserName = User.Name,
                                            RoleId = User.RoleId,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);
                    }
                    break;
            }

            return Json(new { data = "" }, JsonRequestBehavior.AllowGet);

        }


        public ActionResult GetOfficeReportView(int UId)
        {
            User user = db.Users
                                       .Where(u => u.UId == UId)
                                       .FirstOrDefault();
            ViewBag.UserName = user.Name;
            ViewBag.UId = UId;
            return View();
        }


        public ActionResult GetStateReportView()
        {
            List<Division> DivisionList = db.Divisions.ToList();
            ViewBag.DivisionList = new SelectList(DivisionList, "Id", "DivisionName");

            return View();
        }

        public ActionResult GetSubReportView(int UId, int DepartmentId)
        {
            Department department = db.Departments.Where(u => u.Id == DepartmentId)
                                       .FirstOrDefault();

            ViewBag.DepartmentName = department.DepartmentName;

 
            User user = db.Users.Where(u => u.UId == UId)
                                       .FirstOrDefault();

            ViewBag.UserName = user.Name;
            
            User LoggedInUser = (User)HttpContext.Session["User"];
            ViewBag.UserRole = LoggedInUser.RoleId;
            
            ViewBag.UId = UId;
            
            ViewBag.DepartmentId = DepartmentId;
            return View();
        }

        public JsonResult GetOfficeReportData(int UId, int Month, int Year)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;

            var reports = (from r in db.DepartmentMasterReports
                           join d in db.Departments
                           on r.DepartmentId equals d.Id
                           where r.Month == Month
                                 && r.Year == Year
                                 && r.UId == UId
                           orderby r.DepartmentId
                           select new
                           {
                               Total_Marks = r.Total_Marks - r.Not_Applicable_Marks,
                               /*Appraisal_Marks = r.Appraisal_Marks,
                               Appraisal_Percentage = r.Appraisal_Percentage,*/
                               Appraisal_Marks = Math.Round((Double) r.Appraisal_Marks,2),
                               Appraisal_Percentage = Math.Round((Double) r.Appraisal_Percentage, 2),
                               DepartmentId = r.DepartmentId,
                               UId = r.UId,
                               Department = d.DepartmentName,
                           }).ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetRemainingBranchData(int UId, int Month, int Year)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;

            User user = db.Users.Where(u => u.UId == UId)
                                       .FirstOrDefault();

            var DepartmentList = db.Departments.ToList();

            switch (user.AppraisalType)
            {
                case 1:
                    //As Department 2 not in the Appraisal type 1 so remove it from the list
                    DepartmentList = db.Departments.Where(u => u.Id != 2).ToList();
                    break;

                case 2:

                    //As Department 7 not in the Appraisal type 2 so remove it from the list
                    DepartmentList = db.Departments.Where(u => u.Id != 7).ToList();
                    break;
            }

            var reports = (from Departments in DepartmentList
                           where !db.DepartmentMasterReports.Any(f => f.UId == UId && f.Month == Month && f.Year == Year && f.DepartmentId == Departments.Id)
                           select new
                           {
                               Department = Departments.DepartmentName,
                           }).ToList();

            return Json(new
            {
                data = reports
            }, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetRemainingSubjectsData(int? UId, int? Month, int? Year, int? DepartmentId)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;

            var SubjectList = db.Subjects.Where(s => s.Type ==2 && s.DepartmentId == DepartmentId).ToList();

            var SubMasterReportsList = db.SubMasterReports.Where(f => f.UId == UId && f.Month == Month && f.Year == Year && f.DepartmentId == DepartmentId).ToList();

            var reports = (from Subjects in SubjectList
                           where !SubMasterReportsList.Any(f => f.UId == UId && f.Month == Month && f.Year == Year && f.SubjectId == Subjects.SId)
                           select new
                           {
                               Subject = Subjects.SubjectName,
                           }).ToList();

            return Json(new
            {
                data = reports
            }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DetailNASubjectsData(int? UId, int? Month, int? Year)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;

            var reports = (from r in db.SubMasterReports
                           join s in db.Subjects
                           on r.SubjectId equals s.SId
                           where r.Month == Month
                                 && r.Year == Year
                                 && r.UId == UId
                                 && r.Not_Applicable_Marks != 0 
                                 && s.Type == 2
                           orderby r.DepartmentId
                           select new
                           {
                               DepartmentName = r.Department.DepartmentName,
                               Subject = s.SubjectName,
                           }).ToList();

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }


        public JsonResult DetailRemainingSubjectsData(int? UId, int? Month, int? Year)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;

            User user = db.Users.Where(u => u.UId == UId)
                                       .FirstOrDefault();

            var SubjectList = db.Subjects.Where(s => s.Type == 2).ToList();

            switch (user.AppraisalType)
            {
                case 1:
                    //As Department 2 not in the Appraisal type 1 so remove it from the list
                    SubjectList = db.Subjects.Where(s => s.Type == 2 && s.DepartmentId !=2).ToList();
                    break;

                case 2:

                    //As Department 7 not in the Appraisal type 2 so remove it from the list
                    SubjectList = db.Subjects.Where(s => s.Type == 2 && s.DepartmentId != 7).ToList();
                    break;
            }

            var SubMasterReportsList = db.SubMasterReports.Where(f => f.UId == UId && f.Month == Month && f.Year == Year).ToList();

            var reports = (from Subjects in SubjectList
                           where !SubMasterReportsList.Any(f => f.UId == UId && f.Month == Month && f.Year == Year && f.SubjectId == Subjects.SId)
                           select new
                           {
                               Subject = Subjects.SubjectName,
                               DepartmentId = Subjects.DepartmentId,
                           }).ToList();

            return Json(new
            {
                data = reports
            }, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetSubReportData(int UId, int Month, int Year, int DepartmentId)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;
            var reports = (from r in db.SubMasterReports
                           join s in db.Subjects
                           on r.SubjectId equals s.SId
                           where r.Month == Month
                                 && r.Year == Year
                                 && r.UId == UId
                                 && r.Not_Applicable_Marks == 0
                                 && r.DepartmentId == DepartmentId
                                 && s.Type == 2
                           orderby r.DepartmentId
                           select new
                           {
                               report = r,
                               Subject = s.SubjectName,
                           }).ToList();

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetStateReportData(int Month, int Year, int? DivisionId)
        {
            Session["ReportMonth"] = Month;
            Session["ReportYear"] = Year;

            db.Configuration.ProxyCreationEnabled = false;
            var reports = (from r in db.DepartmentMasterReports
                           where r.Month == Month
                                && r.Year == Year
                           group r by r.UId into GroupReport
                           join u in db.Users
                           on GroupReport.FirstOrDefault().UId equals u.UId
                           orderby u.SortKey ascending
                           select new
                           {
                               Appraisal_Marks = GroupReport.Sum(x => x.Appraisal_Marks).ToString().Trim(),
                               /*Appraisal_Percentage = Math.Round( (Double)((GroupReport.Sum(x => x.Appraisal_Marks) * 100) / GroupReport.Sum(x => x.Total_Marks)), 2),*/
                               Appraisal_Percentage = Math.Round((Double)((GroupReport.Sum(x => x.Appraisal_Marks) * 100) / (100 - GroupReport.Sum(x => x.Not_Applicable_Marks))), 2),
                               Total_Marks = (100 - GroupReport.Sum(x => x.Not_Applicable_Marks)),
                               Name = u.Name.Trim(),
                               UId = u.UId,
                               RoleId = u.RoleId,

                           }).ToList();


            if (DivisionId != null)
            {
                db.Configuration.ProxyCreationEnabled = false;
                reports = (from r in db.DepartmentMasterReports
                               where r.Month == Month
                                    && r.Year == Year
                               group r by r.UId into GroupReport
                               join u in db.Users
                               on GroupReport.FirstOrDefault().UId equals u.UId
                               where u.DivisionId == DivisionId
                               orderby u.SortKey ascending
                               select new
                               {
                                   Appraisal_Marks = GroupReport.Sum(x => x.Appraisal_Marks).ToString().Trim(),
                                   /*Appraisal_Percentage = Math.Round( (Double)((GroupReport.Sum(x => x.Appraisal_Marks) * 100) / GroupReport.Sum(x => x.Total_Marks)), 2),*/
                                   Appraisal_Percentage = Math.Round((Double)((GroupReport.Sum(x => x.Appraisal_Marks) * 100) / (100 - GroupReport.Sum(x => x.Not_Applicable_Marks))), 2),
                                   Total_Marks = (100 - GroupReport.Sum(x => x.Not_Applicable_Marks)),
                                   Name = u.Name.Trim(),
                                   UId = u.UId,
                                   RoleId = u.RoleId,

                               }).ToList();

            }


            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

    }
}