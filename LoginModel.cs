using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Authentication
{
    public class LoginModel
    {
        [Required]
        public string EMAIL { get; set; }
        [Required]
        public string PASSWORD { get; set; }
        [Required]
        public string FIRMNR { get; set; }

        public string GUID { get; set; }
        public string captcha { get; set; }
    }
}
