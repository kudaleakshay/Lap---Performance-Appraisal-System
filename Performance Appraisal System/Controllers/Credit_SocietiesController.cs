using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.ViewModels;

namespace Performance_Appraisal_System.Controllers
{
    public class Credit_SocietiesController : Controller
    {
        // GET: Credit_Societies
        public ActionResult Index()
        {
            AppraisalReportViewModel Reports = TempData["ReportData"] as AppraisalReportViewModel;

            switch (Reports.SubSubjectId)
            {
                case 53:
                    return View("Subject53", Reports);

                case 54:
                    return View("Subject54", Reports);

                case 55:
                    return View("Subject55", Reports);

                case 56:
                    return View("Subject56", Reports);

                case 57:
                    return View("Subject57", Reports);

                case 58:
                    return View("Subject58", Reports);

                case 59:
                    return View("Subject59", Reports);
               
            }
            return View();
        }
    }
}