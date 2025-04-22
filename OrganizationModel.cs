using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class OrganizationModel
    {
        [Required]
        public Nullable<int> RECORDREF { get; set; }
        [Required]
        public Nullable<int> PARENT_ORGREF { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public Nullable<int> ACTIVE { get; set; }
        [Required]
        public string FIRMNR { get; set; }
    }
}
