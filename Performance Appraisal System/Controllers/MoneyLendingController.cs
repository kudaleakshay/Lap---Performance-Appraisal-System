using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class MoneyLendingController : Controller
    {
        // GET: MoneyLending
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 62:
                    return View("Subject62", Reports);

                case 63:
                    return View("Subject63", Reports);

                case 64:
                    return View("Subject64", Reports);
            }
            return View();
        }
    }
}