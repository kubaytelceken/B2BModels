using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class ApprovalMechanismModel
    {
        [Required]
        public Nullable<int> APPROVAL_TYPE { get; set; }
        [Required]
        public Nullable<int> LINE_NO { get; set; }
        [Required]
        public Nullable<int> PARENT_LINE_NO { get; set; }
        [Required]
        public Nullable<int> ORGANIZATIONREF { get; set; }
        [Required]
        public string CAPTION { get; set; }
        public string FIRMNR { get; set; }

    }
}
