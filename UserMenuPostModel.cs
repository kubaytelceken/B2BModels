using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.General
{
    public class UserMenuPostModel
    {
        [Required]
        public string FIRMNR { get; set; }
        [Required]
        public Nullable<int> USERREF { get; set; }
    }
}
