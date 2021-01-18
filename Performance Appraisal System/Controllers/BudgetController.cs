using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class BudgetController : Controller
    {
        // GET: Budget
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 30:
                    return View("Subject30");

                case 31:
                    return View("Subject31");

                case 32:
                    return View("Subject32");

                case 33:
                    return View("Subject33");

                case 34:
                    return View("Subject34");
            }
            return View();
        }
    }
}