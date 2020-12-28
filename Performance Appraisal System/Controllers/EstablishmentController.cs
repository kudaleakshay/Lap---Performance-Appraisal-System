using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class EstablishmentController : Controller
    {
        // GET: Establishment
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 11:
                    return View("Subject11", Reports);

                case 12:
                    return View("Subject12", Reports);

                case 13:
                    return View("Subject13", Reports);

                case 14:
                    return View("Subject14", Reports);

                case 15:
                    return View("Subject15", Reports);

                case 16:
                    return View("Subject16", Reports);
            }
            return View();
        }
    }
}