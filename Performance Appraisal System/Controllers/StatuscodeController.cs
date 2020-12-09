using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Performance_Appraisal_System.Controllers
{
    public class StatuscodeController : Controller
    {
        // GET: Statuscode
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult BadRequest()
        {
            return View();
        }
        public ActionResult NotFound(string aspxerrorpath)
        {
            if (!string.IsNullOrWhiteSpace(aspxerrorpath))
                return RedirectToAction("NotFound");

            return View();
        }
        public ActionResult InternalError()
        {
            return View();
        }

    }
}