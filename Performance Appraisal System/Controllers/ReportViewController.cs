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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 12:
                            return Json(new
                            {
                                data = (from s in db.Report12
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 13:
                            return Json(new
                            {
                                data = (from s in db.Report13
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 14:
                            return Json(new
                            {
                                data = (from s in db.Report14
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 15:
                            return Json(new
                            {
                                data = (from s in db.Report15
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 16:
                            return Json(new
                            {
                                data = (from s in db.Report16
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 18:
                            return Json(new
                            {
                                data = (from s in db.Report18
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 23:
                            return Json(new
                            {
                                data = (from s in db.Report23
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 25:
                            return Json(new
                            {
                                data = (from s in db.Report25
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 26:
                            return Json(new
                            {
                                data = (from s in db.Report26
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 27:
                            return Json(new
                            {
                                data = (from s in db.Report27
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 28:
                            return Json(new
                            {
                                data = (from s in db.Report28
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 29:
                            return Json(new
                            {
                                data = (from s in db.Report29
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 31:
                            return Json(new
                            {
                                data = (from s in db.Report31
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 34:
                            return Json(new
                            {
                                data = (from s in db.Report34
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 36:
                            return Json(new
                            {
                                data = (from s in db.Report36
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 37:
                            return Json(new
                            {
                                data = (from s in db.Report37
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 38:
                            return Json(new
                            {
                                data = (from s in db.Report38
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 39:
                            return Json(new
                            {
                                data = (from s in db.Report39
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 40:
                            return Json(new
                            {
                                data = (from s in db.Report40
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 42:
                            return Json(new
                            {
                                data = (from s in db.Report42
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 43:
                            return Json(new
                            {
                                data = (from s in db.Report43
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 44:
                            return Json(new
                            {
                                data = (from s in db.Report44
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 45:
                            return Json(new
                            {
                                data = (from s in db.Report45
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 46:
                            return Json(new
                            {
                                data = (from s in db.Report46
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 47:
                            return Json(new
                            {
                                data = (from s in db.Report47
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 48:
                            return Json(new
                            {
                                data = (from s in db.Report48
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 49:
                            return Json(new
                            {
                                data = (from s in db.Report49
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 50:
                            return Json(new
                            {
                                data = (from s in db.Report50
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 52:
                            return Json(new
                            {
                                data = (from s in db.Report52
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 54:
                            return Json(new
                            {
                                data = (from s in db.Report54
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 56:
                            return Json(new
                            {
                                data = (from s in db.Report56
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 57:
                            return Json(new
                            {
                                data = (from s in db.Report57
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 58:
                            return Json(new
                            {
                                data = (from s in db.Report58
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 59:
                            return Json(new
                            {
                                data = (from s in db.Report59
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);



                        case 61:
                            return Json(new
                            {
                                data = (from s in db.Report61
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 63:
                            return Json(new
                            {
                                data = (from s in db.Report63
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
                                        }).ToList()
                            }, JsonRequestBehavior.AllowGet);


                        case 64:
                            return Json(new
                            {
                                data = (from s in db.Report64
                                        join u in db.Users
                                        on s.UId equals u.UId
                                        where s.Month == Month
                                              && s.Year == Year
                                        orderby s.UId
                                        select new
                                        {
                                            report = s,
                                            UserName = u.Name,
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
            return View();
        }

        public ActionResult GetSubReportView(int UId, int DepartmentId)
        {
            Department department = db.Departments.Where(u => u.Id == DepartmentId)
                                       .FirstOrDefault();

            ViewBag.DepartmentName = department.DepartmentName;

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
                               Appraisal_Marks = r.Appraisal_Marks,
                               Appraisal_Percentage = r.Appraisal_Percentage,
                               DepartmentId = r.DepartmentId,
                               UId = r.UId,
                               Department = d.DepartmentName,
                           }).ToList();

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
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

        public JsonResult GetStateReportData(int Month, int Year)
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
                           select new
                           {
                               Appraisal_Marks = GroupReport.Sum(x => x.Appraisal_Marks).ToString().Trim(),
                               Appraisal_Percentage = Math.Round( (Double)((GroupReport.Sum(x => x.Appraisal_Marks) * 100) / GroupReport.Sum(x => x.Total_Marks)), 2),  
                               /*Appraisal_Percentage = ((GroupReport.Sum(x => x.Appraisal_Marks) * 100) / GroupReport.Sum(x => x.Total_Marks)),*/
                               Total_Marks = (GroupReport.Sum(x => x.Total_Marks) - GroupReport.Sum(x => x.Not_Applicable_Marks)),
                               Name = u.Name.Trim(),
                               UId = u.UId,

                           }).ToList();

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }


    }
}