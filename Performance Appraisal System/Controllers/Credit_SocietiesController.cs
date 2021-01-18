using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class Credit_SocietiesController : Controller
    {
        // GET: Credit_Societies
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 53:
                    return View("Subject53");

                case 54:
                    return View("Subject54");

                case 55:
                    return View("Subject55");

                case 56:
                    return View("Subject56");

                case 57:
                    return View("Subject57");

                case 58:
                    return View("Subject58");

                case 59:
                    return View("Subject59");
               
            }
            return View();
        }
    }
}