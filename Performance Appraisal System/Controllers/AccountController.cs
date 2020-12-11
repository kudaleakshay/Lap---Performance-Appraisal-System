using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Infrastructure;
using Performance_Appraisal_System.Models;
using Performance_Appraisal_System.ViewModels;
using System.Web.Security;

namespace Performance_Appraisal_System.Controllers
{

    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var context = new DocPASEntities())
                {
                    User user = context.Users
                                       .Where(u => u.UserName == model.UserName && u.Password == model.Password)
                                       .FirstOrDefault();

                    if (user != null)
                    {
                        Session["User"] = user;
                        Session["UserName"] = user.UserName;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid User Name or Password");
                        return View(model);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("Error", "Invalid Data");
                return View();
            }

        }

        /*[CustomAuthenticationFilter]*/
        /*[CustomAuthorize("Admin")]*/
        public ActionResult Register()
        {
            DocPASEntities db = new DocPASEntities();
            List<Role> RoleList = db.Roles.ToList();
            ViewBag.RoleList = new SelectList(RoleList, "Id", "RoleName");
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                DocPASEntities db = new DocPASEntities();


                db.Users.Add(user);
                db.SaveChanges();

                Session["User"] = user;
                Session["UserName"] = user.UserName;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Error", "Invalid Data");
                return View();
            }
        }

        public ActionResult GetDistrictList(int DivisionId)
        {
            DocPASEntities db = new DocPASEntities();
            List<District> DistrictList = db.Districts.Where(x => x.DivisionId == DivisionId).ToList();
            ViewBag.DistrictList = new SelectList(DistrictList, "Id", "DistrictName");
            return PartialView("DisplayDistricts");
        }

        public ActionResult GetReportingList(int SearchId, int RoleId)
        {
            DocPASEntities db = new DocPASEntities();
            List<User> UserList = new List<User>();
            if (RoleId == 4|| RoleId==5 || RoleId==6)
            {
                UserList = db.Users.Where(x => x.DistrictId == SearchId && x.RoleId == RoleId).ToList();
            }
            if (RoleId == 3)
            {
                 UserList = db.Users.Where(x => x.DivisionId == SearchId && x.RoleId == RoleId).ToList();
            }

            ViewBag.UserList = new SelectList(UserList, "UID", "Name");
            return PartialView("DisplayReportingList");
        }

        public ActionResult GetDivisionList()
        {
            DocPASEntities db = new DocPASEntities();
            List<Division> DivisionList = db.Divisions.ToList();
            ViewBag.DivisionList = new SelectList(DivisionList, "Id", "DivisionName");
            return PartialView("DisplayDivisions");
        }

        public ActionResult Logout()
        {
            Session.Contents.RemoveAll();

            return RedirectToAction("Index", "Home");
        }

    }
}