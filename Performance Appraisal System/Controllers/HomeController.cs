using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Infrastructure;
using Performance_Appraisal_System.Models;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{

    [CustomAuthenticationFilter]
    public class HomeController : Controller
    {
        private readonly DocPASEntities db = new DocPASEntities();

        public ActionResult Index()
        {
            User user = (User)HttpContext.Session["User"];

            List<Departments_MarksMapping> departments_MarksMapping = db.Departments_MarksMapping.ToList();
            Session["departments_MarksMapping"] = departments_MarksMapping;

            ViewBag.UserRole = user.RoleId;
            return View();
        }

       
        /*[CustomAuthorize("Admin", "SuperAdmin")]*/
        public ActionResult ViewAppraisalReport()
        {
            return View();
        }


        public ActionResult Downloads()
        {
            return View();
        }


        public ActionResult Contact()
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