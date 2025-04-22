using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class BasketPostModel
    {
        public string FIRMNR { get; set; }
        public string BASKET_NAME { get; set; }
        public string CLIENTREF { get; set; }
        public int USERREF { get; set; }
        public string PAYMENT_CODE { get; set; }
    }
}
