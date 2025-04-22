using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class BasketDeleteModel
    {
        public int RECORDREF { get; set; }
        public string BASKET_NAME { get; set; }
        public string FIRMNR { get; set; }
        public int TYPE { get; set; }
    }
}
