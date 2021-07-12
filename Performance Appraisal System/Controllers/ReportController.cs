using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Performance_Appraisal_System.Infrastructure;
using Performance_Appraisal_System.Models;
using Performance_Appraisal_System.ViewModels;


namespace Performance_Appraisal_System.Controllers
{
    [CustomAuthenticationFilter]
    public class ReportController : Controller
    {

        private readonly DocPASEntities db = new DocPASEntities();

        public ReportController()
        {
            var Current_Month = Convert.ToString(DateTime.Now.Month - 1);
            var Current_Year = Convert.ToString(DateTime.Now.Year);

            if (System.Web.HttpContext.Current.Session["ReportMonth"] != null)
            {
                Current_Month = Convert.ToString(System.Web.HttpContext.Current.Session["ReportMonth"]);
                Current_Year = Convert.ToString(System.Web.HttpContext.Current.Session["ReportYear"]);
            }
            else if (DateTime.Now.Month == 1)
            {
                Current_Month = Convert.ToString(12);
                Current_Year = Convert.ToString(DateTime.Now.Year - 1);
            }

            ViewBag.Months = new SelectList(Enumerable.Range(1, 12).Select(x =>
               new SelectListItem()
               {
                   Text = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[x - 1],
                   Value = x.ToString()
               }), "Value", "Text", Current_Month);


            ViewBag.Years = new SelectList(Enumerable.Range(DateTime.Today.Year - 2, 10).Select(x =>
                 new SelectListItem()
                 {
                     Text = x.ToString(),
                     Value = x.ToString()
                 }), "Value", "Text", Current_Year);

        }

        // GET: Report
        public ActionResult Index()
        {
            User user = (User)HttpContext.Session["User"];

            ViewBag.UserRole = user.RoleId;

            return View();
        }

        /*[CustomAuthorize("DDR")]*/
        public ActionResult DepartmentWiseReport()
        {
            User user = (User)HttpContext.Session["User"];
            AppraisalReportViewModel reports = new AppraisalReportViewModel();

            reports.Month = DateTime.Now.Month - 1;
            reports.Year = DateTime.Now.Year;

            if (System.Web.HttpContext.Current.Session["ReportMonth"] != null)
            {
                reports.Month = Convert.ToInt32(System.Web.HttpContext.Current.Session["ReportMonth"]);
                reports.Year = Convert.ToInt32(System.Web.HttpContext.Current.Session["ReportYear"]);
            }
            else if (DateTime.Now.Month == 1)
            {
                reports.Month = 12;
                reports.Year = (DateTime.Now.Year - 1);
            }

            Session["ReportMonth"] = reports.Month;
            Session["ReportYear"] = reports.Year;

            switch (user.AppraisalType)
            {
                case 1:
                    reports.Subjects = (from s in db.Subjects
                                        join d in db.DepartmentMappings
                                        on s.DepartmentId equals d.DId
                                        where d.Type1 == 1
                                        && s.Type == 1
                                        select s).ToList();
                    break;

                case 2:
                    reports.Subjects = (from s in db.Subjects
                                        join d in db.DepartmentMappings
                                        on s.DepartmentId equals d.DId
                                        where d.Type2 == 1
                                        && s.Type == 1
                                        select s).ToList();
                    break;

                case 3:
                    reports.Subjects = (from s in db.Subjects
                                        join d in db.DepartmentMappings
                                        on s.DepartmentId equals d.DId
                                        where d.Type3 == 1
                                        && s.Type == 1
                                        select s).ToList();
                    break;
            }


            return View(reports);
        }

        [HttpPost]
        public ActionResult SubReports(AppraisalReportViewModel reports)
        {
            User user = (User)HttpContext.Session["User"];

            AppraisalReportViewModel SubReports = new AppraisalReportViewModel
            {
                DepartmentId = reports.DepartmentId
            };

            Session["ReportMonth"] = reports.Month;
            Session["ReportYear"] = reports.Year;
            Session["ReportDepartment"] = reports.DepartmentId;

            SubReports.Subjects = db.Subjects.Where(x => x.Type == 2 && x.DepartmentId == SubReports.DepartmentId).ToList();

            Session["ReportDepartmentName"] = SubReports.Subjects.FirstOrDefault().Department.DepartmentName;
            ViewBag.UserRole = user.RoleId;

            return View(SubReports);
        }


        [HttpPost]
        public ActionResult GetReportForms(AppraisalReportViewModel reports, string ActionType)
        {
            Session["ReportSubDepartment"] = reports.SubSubjectId;

            if (ActionType == "NotApp-btn")
            {
                return RedirectToAction("PerformDepartmentNA", "Report", reports);
            }

            SetAppraisalMarks(reports.SubSubjectId, Convert.ToInt32(Session["AppraisalType"]));

            Session["ReportDepartment"] = reports.DepartmentId;
            switch (reports.DepartmentId)
            {
                case 1:
                    Session["ReportDepartmentName"] = "आस्थापना / संवका/लेखा/कायदा व वैधानिक";
                    return RedirectToAction("Index", "Establishment");

                case 2:
                    Session["ReportDepartmentName"] = "कृषीपतपुरवठा व भूविकास";
                    return RedirectToAction("Index", "Krushipat");

                case 3:
                    Session["ReportDepartmentName"] = "माहिती व तंत्रज्ञान / दक्षता";
                    return RedirectToAction("Index", "IT");

                case 4:
                    Session["ReportDepartmentName"] = "अंदाज व नियोजन";
                    return RedirectToAction("Index", "Budget");

                case 5:
                    Session["ReportDepartmentName"] = "लेखापरीक्षण";
                    return RedirectToAction("Index", "Audit");

                case 6:
                    Session["ReportDepartmentName"] = "कायदा व वैधानिक";
                    return RedirectToAction("Index", "Law");

                case 7:
                    Session["ReportDepartmentName"] = "गृहनिर्माण";
                    return RedirectToAction("Index", "Housing");

                case 8:
                    Session["ReportDepartmentName"] = "पतसंस्था";
                    return RedirectToAction("Index", "Credit_Societies");

                case 9:
                    Session["ReportDepartmentName"] = "संघटना व कार्यपध्दती";
                    return RedirectToAction("Index", "O_M");

                case 10:
                    Session["ReportDepartmentName"] = "सावकारी";
                    return RedirectToAction("Index", "MoneyLending");
            }

            return View();
        }


        public ActionResult OpenReportForms(int DepartmentId,int SubjectId)
        {
            Session["ReportSubDepartment"] = SubjectId;
            Session["ReportDepartment"] = DepartmentId;
            
            SetAppraisalMarks(SubjectId, Convert.ToInt32(Session["AppraisalType"]));

            switch (DepartmentId)
            {
                case 1:
                    Session["ReportDepartmentName"] = "आस्थापना / संवका/लेखा/कायदा व वैधानिक";
                    return RedirectToAction("Index", "Establishment");

                case 2:
                    Session["ReportDepartmentName"] = "कृषीपतपुरवठा व भूविकास";
                    return RedirectToAction("Index", "Krushipat");

                case 3:
                    Session["ReportDepartmentName"] = "माहिती व तंत्रज्ञान / दक्षता";
                    return RedirectToAction("Index", "IT");

                case 4:
                    Session["ReportDepartmentName"] = "अंदाज व नियोजन";
                    return RedirectToAction("Index", "Budget");

                case 5:
                    Session["ReportDepartmentName"] = "लेखापरीक्षण";
                    return RedirectToAction("Index", "Audit");

                case 6:
                    Session["ReportDepartmentName"] = "कायदा व वैधानिक";
                    return RedirectToAction("Index", "Law");

                case 7:
                    Session["ReportDepartmentName"] = "गृहनिर्माण";
                    return RedirectToAction("Index", "Housing");

                case 8:
                    Session["ReportDepartmentName"] = "पतसंस्था";
                    return RedirectToAction("Index", "Credit_Societies");

                case 9:
                    Session["ReportDepartmentName"] = "संघटना व कार्यपध्दती";
                    return RedirectToAction("Index", "O_M");

                case 10:
                    Session["ReportDepartmentName"] = "सावकारी";
                    return RedirectToAction("Index", "MoneyLending");
            }

            return View();
        }


        public ActionResult PerformDepartmentNA(AppraisalReportViewModel reports)
        {
            var DepartmentId = reports.DepartmentId;

            var Subjects = db.Subjects.Where(s => s.DepartmentId == DepartmentId && s.Type == 2).ToList();

            User user = (User)HttpContext.Session["User"];

            var UId = user.UId;
            var Month = Convert.ToInt32(Session["ReportMonth"]);
            var Year = Convert.ToInt32(Session["ReportYear"]);
            var AType = Convert.ToInt32(Session["AppraisalType"]);

            foreach (var s in Subjects)
            {

                var ifDataExist = db.SubMasterReports.Where(r => r.UId == UId && r.Month == Month && r.Year == Year
                                                              && r.DepartmentId == DepartmentId
                                                              && r.SubjectId == s.SId).FirstOrDefault();
                if (ifDataExist == null)
                {

                    Subjects_MarksMapping Marks_Mapping = db.Subjects_MarksMapping.Where(x => x.SId == s.SId && x.AType == AType).FirstOrDefault();

                    SubMasterReport SubReport = new SubMasterReport
                    {
                        UId = UId,
                        Month = Month,
                        Year = Year,
                        DepartmentId = DepartmentId,
                        SubjectId = s.SId,
                        Total_Marks = 0,
                        Appraisal_Marks = 0,
                        Appraisal_Percentage = 0,
                        Not_Applicable_Marks = Marks_Mapping.Marks,
                    };


                    switch (s.SId)
                    {
                        case 11:
                            Report11 report11 = new Report11()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Inquiry_C = 0,
                                Inquiry_D = 0,
                                Inquiry_Total = 0,
                                Inquiry_Target_C = 0,
                                Inquiry_Target_D = 0,
                                Inquiry_Total_Target = 0,
                                Inquiry_Achieved_C = 0,
                                Inquiry_Achieved_D = 0,
                                Inquiry_Total_Achieved = 0,
                                Inquiry_Remaining_C = 0,
                                Inquiry_Remaining_D = 0,
                                Inquiry_Total_Remaining = 0,
                            };
                            db.Report11.Add(report11);
                            break;

                        case 12:
                            Report12 report12 = new Report12()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Officer_Count = 0,
                                Retired_Officer_Count = 0,
                                Retirement_Benefits_Target = 0,
                                Retirement_Benefits_Achieved = 0,
                                Retirement_Benefits_Pendig = 0,
                                Remarks = "0",

                            };
                            db.Report12.Add(report12);
                            break;

                        case 13:
                            Report13 report13 = new Report13()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Service_Books_Total = 0,
                                Service_Books_Updation_Target = 0,
                                Service_Books_Updation_Achieved = 0,
                                Service_Books_Updation_Pending = 0,
                                Remarks = "0",

                            };
                            db.Report13.Add(report13);
                            break;

                        case 14:
                            Report14 report14 = new Report14()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Available_Applications = 0,
                                Current_Month_Aim = 0,
                                Last_Month_Classification_Achieved = 0,
                                Current_Month_Classification_Achieved = 0,
                                Total_Classification_Achieved = 0,
                                Current_Month_Percentage = 0,
                            };
                            db.Report14.Add(report14);
                            break;

                        case 15:
                            Report15 report15 = new Report15()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Pending_Inspection_Count = 0,
                                Submitted_Compliance = 0,
                                Accepted_Compliance = 0,
                                Target = 0,
                                Pending_Paragraph_Count = 0,
                                Current_Month_Aim = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,
                                Current_Month_Percentage = 0,

                            };
                            db.Report15.Add(report15);
                            break;

                        case 16:
                            Report16 report16 = new Report16()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Cases_Target = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,
                            };
                            db.Report16.Add(report16);
                            break;

                        case 17:
                            Report17 report17 = new Report17()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Loan_Allocation_Target = 0,
                                Last_Month_Loan_Allocation = 0,
                                Current_Month_Loan_Allocation = 0,
                                Total_Loan_Allocation = 0,

                            };
                            db.Report17.Add(report17);
                            break;

                        case 18:
                            Report18 report18 = new Report18()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Loan_Allocation_Target = 0,
                                Last_Month_Loan_Allocation = 0,
                                Current_Month_Loan_Allocation = 0,
                                Total_Loan_Allocation = 0,

                            };
                            db.Report18.Add(report18);
                            break;

                        case 23:
                            Report23 report23 = new Report23()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Eligible_Members_Aim = 0,
                                Last_Month_Members_Increase = 0,
                                Current_Month_Members_Increase = 0,
                                Total_Members = 0,

                            };
                            db.Report23.Add(report23);
                            break;

                        case 24:
                            Report24 report24 = new Report24()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Aim = 0,
                                Achieved = 0,

                            };
                            db.Report24.Add(report24);
                            break;

                        case 25:
                            Report25 report25 = new Report25()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Aim = 0,
                                Achieved = 0,

                            };
                            db.Report25.Add(report25);
                            break;

                        case 26:
                            Report26 report26 = new Report26()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Aim = 0,
                                Achieved = 0,

                            };
                            db.Report26.Add(report26);
                            break;

                        case 27:
                            Report27 report27 = new Report27()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Aim = 0,
                                Achieved = 0,

                            };
                            db.Report27.Add(report27);
                            break;

                        case 28:
                            Report28 report28 = new Report28()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Aim = 0,
                                Achieved = 0,

                            };
                            db.Report28.Add(report28);
                            break;

                        case 29:
                            Report29 report29 = new Report29()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                CM_Last_Month_Pending_Complaints = 0,
                                CM_Current_Month_Received_Complaints = 0,
                                CM_Total_Complaints = 0,
                                CM_Current_Month_Resolved_Complaints = 0,
                                CM_Pending_Complaints = 0,
                                PM_Last_Month_Pending_Complaints = 0,
                                PM_Current_Month_Received_Complaints = 0,
                                PM_Total_Complaints = 0,
                                PM_Current_Month_Resolved_Complaints = 0,
                                PM_Pending_Complaints = 0,

                            };
                            db.Report29.Add(report29);
                            break;

                        case 30:
                            Report30 report30 = new Report30()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                BDS_Funds_Aim = 0,
                                Last_Month_Achieved_Expenses = 0,
                                Current_Month_Achieved_Expenses = 0,
                                Total_Expenses = 0,
                                Balance_Amount = 0,
                            };
                            db.Report30.Add(report30);
                            break;

                        case 31:
                            Report31 report31 = new Report31()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Marks = 0,

                                Aim = 31,
                                Last_Month_Report_Submitted = 31,
                                Current_Month_Report_Submitted = 31,

                            };
                            db.Report31.Add(report31);
                            break;

                        case 34:
                            Report34 report34 = new Report34()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Yearly_Recovery_Aim = 0,
                                Last_Month_Recovery = 0,
                                Current_Month_Recovery = 0,
                                Total_Recovery = 0,

                            };
                            db.Report34.Add(report34);
                            break;

                        case 35:
                            Report35 report35 = new Report35()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Total_Target = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,
                            };
                            db.Report35.Add(report35);
                            break;

                        case 36:
                            Report36 report36 = new Report36()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Eligible_for_Audit = 0,
                                Current_Month_Audit = 0,
                                Current_Month_Remaining_for_Audit = 0,
                                Action_Taken = 0,
                                Percentage_Action_Taken = 0,
                                Marks_Action_Taken = 0,

                            };
                            db.Report36.Add(report36);
                            break;

                        case 37:
                            Report37 report37 = new Report37()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Marks = 0,

                                Last_Year_Pending = 0,
                                Last_Month_Reports = 0,
                                Current_Month_Reports = 0,
                                Total_Reports = 0,
                                Last_Month_Action_Taken = 0,
                                Current_Month_Action_Taken = 0,
                                Total_Action_Taken = 0,
                                Action_Pending_Reports = 0,
                                Percentage_Action_Taken = 0,

                            };
                            db.Report37.Add(report37);
                            break;

                        case 38:
                            Report38 report38 = new Report38()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Marks = 0,

                                Last_Year_Pending = 0,
                                Last_Month_Reports = 0,
                                Current_Month_Reports = 0,
                                Total_Reports = 0,
                                Last_Month_Action_Taken = 0,
                                Current_Month_Action_Taken = 0,
                                Total_Action_Taken = 0,
                                Action_Pending_Reports = 0,
                                Percentage_Action_Taken = 0,

                            };
                            db.Report38.Add(report38);
                            break;

                        case 39:
                            Report39 report39 = new Report39()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Marks = 0,

                                Last_Year_Remaining = 0,
                                Last_Month_Remaining = 0,
                                Current_Month_Remaining = 0,
                                Total_Remaining = 0,
                                Last_Month_Action_Taken = 0,
                                Current_Month_Action_Taken = 0,
                                Total_Action_Taken = 0,
                                Action_Pending_Reports = 0,
                                Percentage_Action_Taken = 0,

                            };
                            db.Report39.Add(report39);
                            break;

                        case 40:
                            Report40 report40 = new Report40()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Marks = 0,

                                Last_Year_Received = 0,
                                Last_Month_Received = 0,
                                Current_Month_Received = 0,
                                Total_Received = 0,
                                Last_Month_Action_Taken = 0,
                                Current_Month_Action_Taken = 0,
                                Total_Action_Taken = 0,
                                Action_Pending_Reports = 0,
                                Percentage_Action_Taken = 0,

                            };
                            db.Report40.Add(report40);
                            break;

                        case 41:
                            Report41 report41 = new Report41()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Society_Cancellation = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,

                            };
                            db.Report41.Add(report41);
                            break;

                        case 42:
                            Report42 report42 = new Report42()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Society_Cancellation = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,

                            };
                            db.Report42.Add(report42);
                            break;

                        case 43:
                            Report43 report43 = new Report43()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Aim = 0,
                                Last_Month_Remaining = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,

                            };
                            db.Report43.Add(report43);
                            break;

                        case 44:
                            Report44 report44 = new Report44()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Aim1 = 0,
                                Aim2 = 0,
                                Total_Annual_Aim = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,

                            };
                            db.Report44.Add(report44);
                            break;

                        case 45:
                            Report45 report45 = new Report45()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Annual_aim = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,

                            };
                            db.Report45.Add(report45);
                            break;

                        case 46:
                            Report46 report46 = new Report46()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Last_Month_Received_Cases = 0,
                                Current_Month_Received_Cases = 0,
                                Total_Cases = 0,
                                Target = 0,
                                Achieved = 0,

                            };
                            db.Report46.Add(report46);
                            break;

                        case 47:
                            Report47 report47 = new Report47()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Last_Month_Received_Cases = 0,
                                Current_Month_Received_Cases = 0,
                                Total_Cases = 0,
                                Target = 0,
                                Achieved = 0,

                            };
                            db.Report47.Add(report47);
                            break;

                        case 48:
                            Report48 report48 = new Report48()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Last_Month_Received_Cases = 0,
                                Current_Month_Received_Cases = 0,
                                Total_Cases = 0,
                                Target = 0,
                                Achieved = 0,

                            };
                            db.Report48.Add(report48);
                            break;

                        case 49:
                            Report49 report49 = new Report49()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Last_Month_Received_Cases = 0,
                                Current_Month_Received_Cases = 0,
                                Total_Cases = 0,
                                Target = 0,
                                Achieved = 0,

                            };
                            db.Report49.Add(report49);
                            break;

                        case 50:
                            Report50 report50 = new Report50()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Last_Month_Received_Cases = 0,
                                Current_Month_Received_Cases = 0,
                                Total_Cases = 0,
                                Target = 0,
                                Achieved = 0,

                            };
                            db.Report50.Add(report50);
                            break;

                        case 51:
                            Report51 report51 = new Report51()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Last_Month_Pending_Cases = 0,
                                Current_Month_Received_Cases = 0,
                                Total_Cases = 0,
                                Last_Month_Cases_Aim = 0,
                                Current_Month_Cases_Aim = 0,
                                Total_Cases_Aim = 0,
                                Last_Month_Disposed_Cases = 0,
                                Current_Month_Disposed_Cases = 0,
                                Total_Disposed_Cases = 0,

                            };
                            db.Report51.Add(report51);
                            break;

                        case 52:
                            Report52 report52 = new Report52()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Last_Month_Pending_Cases = 0,
                                Current_Month_Received_Cases = 0,
                                Total_Cases = 0,
                                Last_Month_Cases_Aim = 0,
                                Current_Month_Cases_Aim = 0,
                                Total_Cases_Aim = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,

                            };
                            db.Report52.Add(report52);
                            break;

                        case 53:
                            Report53 report53 = new Report53()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Annual_Target = 0,
                                Total_Achieved = 0,
                                Current_Month_Percentage = 0,

                            };
                            db.Report53.Add(report53);
                            break;

                        case 54:
                            Report54 report54 = new Report54()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Annual_Target = 0,
                                Total_Achieved = 0,
                                Current_Month_Percentage = 0,

                            };
                            db.Report54.Add(report54);
                            break;


                        case 56:
                            Report56 report56 = new Report56()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Annual_Target = 0,
                                Current_Month_Aim_Count = 0,
                                Current_Month_Aim_Amount = 0,
                                Last_Month_Achieved_Count = 0,
                                Last_Month_Achieved_Amount = 0,
                                Current_Month_Achieved_Count = 0,
                                Current_Month_Achieved_Amount = 0,
                                Total_Count = 0,
                                Total_Amount = 0,
                                Current_Month_Percentage = 0,

                            };
                            db.Report56.Add(report56);
                            break;

                        case 57:
                            Report57 report57 = new Report57()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Annual_Target = 0,
                                Current_Month_Aim_Count = 0,
                                Current_Month_Aim_Amount = 0,
                                Last_Month_Achieved_Count = 0,
                                Last_Month_Achieved_Amount = 0,
                                Current_Month_Achieved_Count = 0,
                                Current_Month_Achieved_Amount = 0,
                                Total_Count = 0,
                                Total_Amount = 0,
                                Current_Month_Percentage = 0,

                            };
                            db.Report57.Add(report57);
                            break;

                        case 58:
                            Report58 report58 = new Report58()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Annual_Target = 0,
                                Current_Month_Aim_Count = 0,
                                Current_Month_Aim_Amount = 0,
                                Last_Month_Achieved_Count = 0,
                                Last_Month_Achieved_Amount = 0,
                                Current_Month_Achieved_Count = 0,
                                Current_Month_Achieved_Amount = 0,
                                Total_Count = 0,
                                Total_Amount = 0,
                                Current_Month_Percentage = 0,

                            };
                            db.Report58.Add(report58);
                            break;

                        case 59:
                            Report59 report59 = new Report59()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Annual_Target = 0,
                                Current_Month_Aim_Count = 0,
                                Current_Month_Aim_Amount = 0,
                                Last_Month_Achieved_Count = 0,
                                Last_Month_Achieved_Amount = 0,
                                Current_Month_Achieved_Count = 0,
                                Current_Month_Achieved_Amount = 0,
                                Total_Count = 0,
                                Total_Amount = 0,
                                Current_Month_Percentage = 0,

                            };
                            db.Report59.Add(report59);
                            break;

                        case 60:
                            Report60 report60 = new Report60()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Officer_Count = 0,
                                Staff_Count = 0,
                                Total_Staff = 0,
                                Officer_Target = 0,
                                Staff_Target = 0,
                                Total_Target = 0,
                                Current_Month_Aim = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,
                                Current_Month_Percentage = 0,
                            };
                            db.Report60.Add(report60);
                            break;

                        case 61:
                            Report61 report61 = new Report61()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Percentage = 0,
                                Appraisal_Marks = 0,

                                Total_Target = 0,
                                Current_Month_Aim = 0,
                                Last_Month_Achieved = 0,
                                Current_Month_Achieved = 0,
                                Total_Achieved = 0,
                                Current_Month_Percentage = 0,
                            };
                            db.Report61.Add(report61);
                            break;

                        case 62:
                            Report62 report62 = new Report62()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Marks = 0,

                                Total_Complaint = 0,
                                Resolved_Complaint = 0,
                                Resolved_Percentage = 0,
                            };
                            db.Report62.Add(report62);
                            break;

                        case 63:
                            Report63 report63 = new Report63()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Marks = 0,

                                Total_Application = 0,
                                Resolved_Application = 0,
                                Resolved_Percentage = 0,

                            };
                            db.Report63.Add(report63);
                            break;

                        case 64:
                            Report64 report64 = new Report64()
                            {
                                UId = UId,
                                Month = Month,
                                Year = Year,
                                CreatedTime = DateTime.Now,
                                NotApplicable = true,
                                Appraisal_Marks = 0,

                                Total_Appeal = 0,
                                Resolved_Appeal = 0,
                                Resolved_Percentage = 0,

                            };
                            db.Report64.Add(report64);
                            break;

                    }

                    try
                    {
                        if (SaveSubMasterReports(SubReport, user.RoleId))
                        {
                            db.SaveChanges();
                            TempData["Message"] = "Report Submitted Successfully";
                        }
                        else
                        {
                            TempData["Error"] = "Something went wrong, Please try again later";
                        }
                    }
                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                                    ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }

                }
            }


            return RedirectToAction("DepartmentWiseReport", "Report");
        }


        public ActionResult ViewAppraisalReports()
        {

            User user = (User)HttpContext.Session["User"];

            switch (user.RoleId)
            {
                case 1:
                    return View();


                case 2:
                    return View();


                case 3:
                    return RedirectToAction("GetDivisionReportView", "ReportView");


                case 4:
                    return RedirectToAction("OfficeReportSelection", "Report");

            }

            return View();
        }


        public ActionResult DepartmentReportSelection()
        {
            List<Department> DepartmentList = db.Departments.ToList();
            ViewBag.DepartmentList = new SelectList(DepartmentList, "Id", "DepartmentName");
            return View();
        }

        public ActionResult OfficeReportSelection()
        {
            return View();
        }

        public JsonResult GetDJROfficeData()
        {
            db.Configuration.ProxyCreationEnabled = false;
            User user = (User)HttpContext.Session["User"];

            var reports = db.Users.Where(x => x.RoleId == 3 && x.UId == user.UId).ToList();

            if (user.RoleId == 1 || user.RoleId == 2)
            {
                reports = db.Users.Where(x => x.RoleId == 3 && x.Status == 1).ToList();
            }
            if (user.RoleId == 3)
            {
                reports = db.Users.Where(x => x.RoleId == 3 && x.UId == user.UId).ToList();
            }

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDDROfficeData()
        {
            db.Configuration.ProxyCreationEnabled = false;

            User user = (User)HttpContext.Session["User"];
            var reports = db.Users.Where(x => x.RoleId == 4 && x.Status == 1).ToList();

            if (user.RoleId == 1 || user.RoleId == 2)
            {
                reports = db.Users.Where(x => x.RoleId == 4 && x.Status == 1).ToList();
            }
            if (user.RoleId == 3)
            {
                reports = db.Users.Where(x => x.RoleId == 4 && x.Status == 1 && x.ReportTo == user.UId).ToList();
            }
            if (user.RoleId == 4)
            {
                reports = db.Users.Where(x => x.RoleId == 4 && x.Status == 1 && x.UId == user.UId).ToList();
            }

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetAROfficeData()
        {
            db.Configuration.ProxyCreationEnabled = false;

            User user = (User)HttpContext.Session["User"];
            var reports = db.Users.Where(x => x.RoleId == 5 && x.UId == user.UId).ToList();

            if (user.RoleId == 1 || user.RoleId == 2)
            {
                reports = db.Users.Where(x => x.RoleId == 5 && x.Status == 1).ToList();
            }
            if (user.RoleId == 3)
            {
                reports = db.Users.Where(x => x.RoleId == 5 && x.Status == 1 && x.DivisionId == user.DivisionId).ToList();
            }
            if (user.RoleId == 4)
            {
                reports = db.Users.Where(x => x.RoleId == 5 && x.Status == 1 && x.ReportTo == user.UId).ToList();
            }
            if (user.RoleId == 5)
            {
                reports = db.Users.Where(x => x.RoleId == 5 && x.Status == 1 && x.UId == user.UId).ToList();
            }

            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetDepartmentWiseSubjects(int? DepartmentId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = db.Subjects.Where(x => x.DepartmentId == DepartmentId && x.Type == 2).ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSubjects()
        {
            db.Configuration.ProxyCreationEnabled = false;
            var reports = db.Subjects.Where(x => x.Type == 2).ToList();
            return Json(new { data = reports }, JsonRequestBehavior.AllowGet);
        }

        public Boolean SaveSubMasterReports(SubMasterReport Report, int? RoleId)
        {
            Report.Remarks = getRemark(RoleId);

            var ifDataExist = db.SubMasterReports.Where(r => r.UId == Report.UId && r.Month == Report.Month && r.Year == Report.Year
                                                               && r.DepartmentId == Report.DepartmentId
                                                               && r.SubjectId == Report.SubjectId).FirstOrDefault();

            try
            {
                if (ifDataExist == null)
                {
                    db.SubMasterReports.Add(Report);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        public string getRemark(int? RoleId)
        {
            if (RoleId != null)
            {
                if (!IsReportInTime(RoleId))
                    return "Late";
            }
            return "";
        }


        public Boolean IsReportInTime(int? RoleId)
        {
            int Current_Date = DateTime.Now.Day;

            switch (RoleId)
            {
                case 3:
                    return (Current_Date < 15);

                case 4:
                    return (Current_Date < 10);

                case 5:
                    return (Current_Date < 5);
            }
            return true;
        }

        public void SetAppraisalMarks(int SId, int AppraisalType)
        {
            Subjects_MarksMapping Marks = db.Subjects_MarksMapping.Where(x => x.SId == SId && x.AType == AppraisalType).FirstOrDefault(); ;
            Session["TotalMarks"] = Marks.Marks;
        }

    }
}