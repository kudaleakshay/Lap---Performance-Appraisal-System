using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class ITController : Controller
    {
        // GET: IT
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 24:
                    return View("Subject24", Reports);

                case 25:
                    return View("Subject25", Reports);

                case 26:
                    return View("Subject26", Reports);

                case 27:
                    return View("Subject27", Reports);

                case 28:
                    return View("Subject28", Reports);

                case 29:
                    return View("Subject29", Reports);
            }
            return View();
        }
    }
}