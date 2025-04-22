using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class BasketSaveModel
    {
        public string FIRMNR { get; set; }
        public int USERREF { get; set; }
        public BasketModel BASKETS { get; set; }
    }
}
