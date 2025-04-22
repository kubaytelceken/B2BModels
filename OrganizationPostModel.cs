using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class OrganizationPostModel
    {
        [Required]
        public string FIRMNR { get; set; }
        public Nullable<int> ORGREF { get; set; }
    }
}
