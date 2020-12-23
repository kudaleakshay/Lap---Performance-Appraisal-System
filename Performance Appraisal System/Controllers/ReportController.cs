using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Models;

namespace Performance_Appraisal_System.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            return View();
        }

        /*[CustomAuthorize("DDR")]*/
        public ActionResult DepartmentWiseReport()
        {
            DocPASEntities db = new DocPASEntities();
            List<Subject> SubjectList = db.Subjects.Where(x => x.Type == 1).ToList();
            return View(SubjectList);
        }

        public ActionResult SubReports(string departmentId, string month, string year)
        {
            DocPASEntities db = new DocPASEntities();
            List<Subject> SubjectList = db.Subjects.Where(x => x.Type == 2 && x.DepartmentId.ToString() == departmentId).ToList();
            return View(SubjectList);
        }
    }
}