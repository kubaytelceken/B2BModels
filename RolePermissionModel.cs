using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class RolePermissionModel
    {
        public Nullable<int> RECORDREF { get; set; }
        [Required]
        public Nullable<int> ROLEREF { get; set; }
        [Required]
        public Nullable<int> PROGRAMREF { get; set; }
        [Required]
        public Nullable<int> PERMISSIONREF { get; set; }
         
    }
}
