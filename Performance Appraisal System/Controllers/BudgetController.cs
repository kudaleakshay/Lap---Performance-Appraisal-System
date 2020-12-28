using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class BudgetController : Controller
    {
        // GET: Budget
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 30:
                    return View("Subject30", Reports);

                case 31:
                    return View("Subject31", Reports);

                case 32:
                    return View("Subject32", Reports);

                case 33:
                    return View("Subject33", Reports);

                case 34:
                    return View("Subject34", Reports);
            }
            return View();
        }
    }
}