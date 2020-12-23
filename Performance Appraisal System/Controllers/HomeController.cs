using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Infrastructure;
using Performance_Appraisal_System.Models;

namespace Performance_Appraisal_System.Controllers
{

    [CustomAuthenticationFilter]
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            User user = (User)HttpContext.Session["User"];

            ViewBag.UserRole = user.RoleId;
            return View();
        }

       
        /*[CustomAuthorize("Admin", "SuperAdmin")]*/
        public ActionResult ViewAppraisalReport()
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