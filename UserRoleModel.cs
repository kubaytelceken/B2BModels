using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class UserRoleModel
    {
        public Nullable<int> RECORDREF { get; set; }
        [Required]
        public Nullable<int> USERREF { get; set; }
        [Required]
        public Nullable<int> ROLEREF { get; set; }
    }
}
