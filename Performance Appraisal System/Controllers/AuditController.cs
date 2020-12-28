using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class AuditController : Controller
    {
        // GET: Audit
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 35:
                    return View("Subject35", Reports);

                case 36:
                    return View("Subject36", Reports);

                case 37:
                    return View("Subject37", Reports);

                case 38:
                    return View("Subject38", Reports);

                case 39:
                    return View("Subject39", Reports);

                case 40:
                    return View("Subject40", Reports);
            }
            return View();
        }
    }
}