using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Performance_Appraisal_System.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Username can't be blank")]
        [DisplayName("वापरकर्त्याचे नाव")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
        [DisplayName("पासवर्ड")]
        public string Password { get; set; }
    }
}