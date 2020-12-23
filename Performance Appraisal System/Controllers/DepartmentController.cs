using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Performance_Appraisal_System.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ShowSubReports()
        {
            return View();
        }


    }
}