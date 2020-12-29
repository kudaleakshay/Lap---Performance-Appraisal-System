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
    public class O_MController : Controller
    {
        // GET: O_M
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 60:
                    return View("Subject60");

                case 61:
                    return View("Subject61", Reports);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Subject60()
        {
            return View();
        }

    }
}