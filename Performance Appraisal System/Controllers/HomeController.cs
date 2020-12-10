using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Infrastructure;

namespace Performance_Appraisal_System.Controllers
{

    [CustomAuthenticationFilter]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            ViewBag.UserRole = HttpContext.Session["RoleId"];
                      
            return View();
        }

       
        /*[CustomAuthorize("Admin", "SuperAdmin")]*/
        public ActionResult ViewAppraisalReport()
        {
            return View();
        }

        /*[CustomAuthorize("DDR")]*/
        public ActionResult FillAppraisalReport()
        {
            return View();
        }

        public ActionResult UnAuthorized()
        {
            ViewBag.Message = "Un Authorized Page!";

            return View();
        }



    }
}