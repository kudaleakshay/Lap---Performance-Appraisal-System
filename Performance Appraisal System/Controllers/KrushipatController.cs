using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class KrushipatController : Controller
    {
        // GET: Krushipat
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 17:
                    return View("Subject17");

                case 18:
                    return View("Subject18");

                case 19:
                    return View("Subject19");

                case 20:
                    return View("Subject20");

                case 21:
                    return View("Subject21");

                case 22:
                    return View("Subject22");

                case 23:
                    return View("Subject23");
            }
            return View();
        }
    }
}