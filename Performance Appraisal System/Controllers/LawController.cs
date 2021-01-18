using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class LawController : Controller
    {
        // GET: Law
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
    }
}