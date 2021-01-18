using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class HousingController : Controller
    {
        // GET: Housing
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 51:
                    return View("Subject51");

                case 52:
                    return View("Subject52");
            }
            return View();
        }
    }
}