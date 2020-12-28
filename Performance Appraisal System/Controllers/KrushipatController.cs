using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class KrushipatController : Controller
    {
        // GET: Krushipat
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 17:
                    return View("Subject17", Reports);

                case 18:
                    return View("Subject18", Reports);

                case 19:
                    return View("Subject19", Reports);

                case 20:
                    return View("Subject20", Reports);

                case 21:
                    return View("Subject21", Reports);

                case 22:
                    return View("Subject22", Reports);

                case 23:
                    return View("Subject23", Reports);
            }
            return View();
        }
    }
}