using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class UserDeleteModel
    {
        [Required]
        public int USERREF { get; set; }
        [Required]
        public string FIRMNR { get; set; }
       
    }
}
