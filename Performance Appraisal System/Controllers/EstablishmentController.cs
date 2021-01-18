using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class EstablishmentController : Controller
    {
        // GET: Establishment
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 11:
                    return View("Subject11");

                case 12:
                    return View("Subject12");

                case 13:
                    return View("Subject13");

                case 14:
                    return View("Subject14");

                case 15:
                    return View("Subject15");

                case 16:
                    return View("Subject16");
            }
            return View();
        }
    }
}