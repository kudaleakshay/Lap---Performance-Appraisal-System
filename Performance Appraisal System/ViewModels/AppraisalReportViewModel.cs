using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Performance_Appraisal_System.Models;

namespace Performance_Appraisal_System.ViewModels
{
    public class AppraisalReportViewModel
    {
        [Required(ErrorMessage = "कृपया महिना आवश्यक आहे")]
        [DisplayName("महिना")]
        public int Month { get; set; }

        [Required(ErrorMessage = "कृपया वर्ष आवश्यक आहे")]
        [DisplayName("वर्ष")]
        public int Year { get; set; }

        public int DepartmentId { get; set; }

        public int SubSubject { get; set; }

        public IEnumerable<Subject> Subjects { get; set; }

    }
}