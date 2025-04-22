using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class UserClientsModel
    {
        public Nullable<int> RECORDREF { get; set; }
        [Required]
        public Nullable<int> CLIENTREF { get; set; }
        [Required]
        public string PAYMENTCODE { get; set; }
        [Required]
        public Nullable<int> USERREF { get; set; }
        [Required]
        public string CLIENT_CODE { get; set; }
        [Required]
        public string CLIENT_NAME { get; set; }
        [Required]
        public Nullable<int> USE_DEFAULT { get; set; }
    }
}
