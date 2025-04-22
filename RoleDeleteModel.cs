using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class RoleDeleteModel
    {
        [Required]
        public Nullable<int> ROLEREF { get; set; }
        [Required]
        public string  FIRMNR { get; set; }
    }
}
