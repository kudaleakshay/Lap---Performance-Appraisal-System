using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class AuditController : Controller
    {
        // GET: Audit
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 35:
                    return View("Subject35");

                case 36:
                    return View("Subject36");

                case 37:
                    return View("Subject37");

                case 38:
                    return View("Subject38");

                case 39:
                    return View("Subject39");

                case 40:
                    return View("Subject40");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Subject35()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subject36()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subject37()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subject38()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subject39()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Subject40()
        {
            return View();
        }

    }
}