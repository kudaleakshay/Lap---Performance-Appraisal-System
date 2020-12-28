using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class LawController : Controller
    {
        // GET: Law
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 41:
                    return View("Subject41", Reports);

                case 42:
                    return View("Subject42", Reports);

                case 43:
                    return View("Subject43", Reports);

                case 44:
                    return View("Subject44", Reports);

                case 45:
                    return View("Subject45", Reports);

                case 46:
                    return View("Subject46", Reports);

                case 47:
                    return View("Subject47", Reports);

                case 48:
                    return View("Subject48", Reports);

                case 49:
                    return View("Subject49", Reports);

                case 50:
                    return View("Subject50", Reports);
            }
            return View();
        }
    }
}