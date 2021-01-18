using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Models;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class ITController : Controller
    {
        private DocPASEntities db = new DocPASEntities();
        // GET: IT
        
        public ActionResult Index()
        {
            switch (Session["ReportSubDepartment"])
            {
                case 24:
                    return View("Subject24");

                case 25:
                    return View("Subject25");

                case 26:
                    return View("Subject26");

                case 27:
                    return View("Subject27");

                case 28:
                    return View("Subject28");

                case 29:
                    return View("Subject29");
            }
            return View();
        }



        [HttpPost]
        public ActionResult Subject24()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Subject25()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Subject26()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Subject27()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Subject28()
        {
            return View();
        }
    }
}