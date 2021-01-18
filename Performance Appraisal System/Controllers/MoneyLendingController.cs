using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class MoneyLendingController : Controller
    {
        // GET: MoneyLending
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 62:
                    return View("Subject62");

                case 63:
                    return View("Subject63");

                case 64:
                    return View("Subject64");
            }
            return View();
        }
    }
}