using Performance_Appraisal_System.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Performance_Appraisal_System.Controllers
{
    public class UpdateReportsController : Controller
    {
        private readonly ReportController reportController = new ReportController();
        private readonly DocPASEntities db = new DocPASEntities();


        // GET: UpdateReports
        public ActionResult Index()
        {
            return View();
        }





        [HttpPost]
        public ActionResult Subject11(Report11 Reports)
        {
            var SubjectId = 11;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject12(Report12 Reports)
        {
            var SubjectId = 12;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject13(Report13 Reports)
        {
            var SubjectId = 13;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject14(Report14 Reports)
        {
            var SubjectId = 14;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject15(Report15 Reports)
        {
            var SubjectId = 15;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject16(Report16 Reports)
        {
            var SubjectId = 16;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject17(Report17 Reports)
        {
            var SubjectId = 17;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject18(Report18 Reports)
        {
            var SubjectId = 18;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject23(Report23 Reports)
        {
            var SubjectId = 23;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }



        [HttpPost]
        public ActionResult Subject24(Report24 Reports)
        {
            var SubjectId = 24;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject25(Report25 Reports)
        {
            var SubjectId = 25;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject26(Report26 Reports)
        {
            var SubjectId = 26;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject27(Report27 Reports)
        {
            var SubjectId = 27;


            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject28(Report28 Reports)
        {
            var SubjectId = 28;


            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject29(Report29 Reports)
        {

            var SubjectId = 29;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }



        [HttpPost]
        public ActionResult Subject30(Report30 Reports)
        {
            var SubjectId = 30;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject31(Report31 Reports)
        {
            var SubjectId = 31;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;
                var Appraisal_Percentage = (Reports.Appraisal_Marks * 100) / Convert.ToDouble(Session["TotalMarks"]);

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject34(Report34 Reports)
        {
            var SubjectId = 34;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject35(Report35 Reports)
        {
            var SubjectId = 35;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject36(Report36 Reports)
        {
            var SubjectId = 36;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject37(Report37 Reports)
        {
            var SubjectId = 37;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Percentage_Action_Taken, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject38(Report38 Reports)
        {
            var SubjectId = 38;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Percentage_Action_Taken, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject39(Report39 Reports)
        {
            var SubjectId = 39;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Percentage_Action_Taken, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject40(Report40 Reports)
        {
            var SubjectId = 40;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Percentage_Action_Taken, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }




        [HttpPost]
        public ActionResult Subject41(Report41 Reports)
        {
            var SubjectId = 41;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject42(Report42 Reports)
        {
            var SubjectId = 42;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject43(Report43 Reports)
        {
            var SubjectId = 43;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject44(Report44 Reports)
        {
            var SubjectId = 44;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject45(Report45 Reports)
        {
            var SubjectId = 45;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject46(Report46 Reports)
        {
            var SubjectId = 46;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject47(Report47 Reports)
        {
            var SubjectId = 47;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject48(Report48 Reports)
        {
            var SubjectId = 48;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject49(Report49 Reports)
        {
            var SubjectId = 49;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject50(Report50 Reports)
        {
            var SubjectId = 50;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }





        [HttpPost]
        public ActionResult Subject51(Report51 Reports)
        {
            var SubjectId = 51;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Submitted Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject52(Report52 Reports)
        {
            var SubjectId = 52;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }



        [HttpPost]
        public ActionResult Subject53(Report53 Reports)
        {
            var SubjectId = 53;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject54(Report54 Reports)
        {
            var SubjectId = 54;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject56(Report56 Reports)
        {
            var SubjectId = 56;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject57(Report57 Reports)
        {
            var SubjectId = 57;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject58(Report58 Reports)
        {
            var SubjectId = 58;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject59(Report59 Reports)
        {
            var SubjectId = 59;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


    
        [HttpPost]
        public ActionResult Subject60(Report60 Reports)
        {
            var SubjectId = 60;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }


        [HttpPost]
        public ActionResult Subject61(Report61 Reports)
        {
            var SubjectId = 61;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Appraisal_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }



        [HttpPost]
        public ActionResult Subject62(Report62 Reports)
        {
            var SubjectId = 62;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Resolved_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject63(Report63 Reports)
        {
            var SubjectId = 63;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Resolved_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }

        [HttpPost]
        public ActionResult Subject64(Report64 Reports)
        {
            var SubjectId = 64;

            if (ModelState.IsValid)
            {
                Reports.CreatedTime = DateTime.Now;

                SubMasterReport subMasterReport = db.SubMasterReports.Where(r => r.UId == Reports.UId && r.Month == Reports.Month &&
                                                                                 r.Year == Reports.Year && r.SubjectId == SubjectId).FirstOrDefault();

                var Total_Marks = Reports.NotApplicable ? 0 : Convert.ToDouble(Session["TotalMarks"]);
                var Not_Applicable_Marks = Reports.NotApplicable ? Convert.ToDouble(Session["TotalMarks"]) : 0;

                if (UpdateSubMasterReports(subMasterReport, Reports.Appraisal_Marks, Reports.Resolved_Percentage, Total_Marks, Not_Applicable_Marks))
                {
                    db.Entry(Reports).State = EntityState.Modified;
                    db.SaveChanges();

                    TempData["Message"] = "Report Updated Successfully";
                    return RedirectToAction("ViewAppraisalReports", "Report");
                }
                TempData["Error"] = "Something went wrong, Please try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
            else
            {
                TempData["Error"] = "Something went wrong, Please check your input data and try again later";
                return RedirectToAction("ViewAppraisalReports", "Report");
            }
        }



        public Boolean UpdateSubMasterReports(SubMasterReport MasterReport, double? Appraisal_Marks, double? Appraisal_Percentage, double Total_Marks, double Not_Applicable_Marks)
        {

            if (MasterReport != null)
            {
                MasterReport.Appraisal_Marks = Appraisal_Marks;
                MasterReport.Appraisal_Percentage = Appraisal_Percentage;
                MasterReport.Total_Marks = Total_Marks;
                MasterReport.Not_Applicable_Marks = Not_Applicable_Marks;

                db.Entry(MasterReport).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            return false;
        }



    }
}