using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Authentication
{
    public class FirmaListPostModel
    {
        [Required]
        public string EMAIL { get; set; }
    }
}
