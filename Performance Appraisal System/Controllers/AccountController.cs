using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Infrastructure;
using Performance_Appraisal_System.Models;
using Performance_Appraisal_System.ViewModels;
using System.Web.Security;
using System.Text;
using System.Security.Cryptography;
using System.IO;

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
            var Password = Encrypt(model.Password.ToLower());

            if (ModelState.IsValid)
            {
                using (var context = new DocPASEntities())
                {
                    User user = context.Users
                                       .Where(u => u.UserName == model.UserName && u.Password == Password && u.Status ==1)
                                       .FirstOrDefault();

                    if (user != null)
                    {
                        Session["User"] = user;
                        Session["AppraisalType"] = user.AppraisalType;
                        Session["UserName"] = user.UserName;
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ModelState.AddModelError("Error", "Invalid User Name or Password");
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
            user.Password = Encrypt(user.Password.ToLower());

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
            if (RoleId == 5 || RoleId == 6)
            {
                UserList = db.Users.Where(x => x.DistrictId == SearchId && x.RoleId == 4).ToList();
            }
            if (RoleId == 4)
            {
                UserList = db.Users.Where(x => x.DivisionId == SearchId && x.RoleId == 3).ToList();
            }
            if (RoleId == 3)
            {
                UserList = db.Users.Where(x => x.RoleId == 2).ToList();
            }

            ViewBag.UserList = new SelectList(UserList, "UID", "Name");
            return PartialView("DisplayReportingList");
        }

        public ActionResult Logout()
        {
            Session.Contents.RemoveAll();
            return RedirectToAction("Index", "Home");
        }


        public string Encrypt(string clearText)
        {
            Console.WriteLine("Normal" + clearText);

            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            Console.WriteLine("Encrypted"+ clearText);
            return clearText;
        }


        public string Decrypt(string cipherText)
        {

            Console.WriteLine("Normal" + cipherText);

            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            Console.WriteLine("Decrpt" + cipherText);

            return cipherText;
        }


    }
}