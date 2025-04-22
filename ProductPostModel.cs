using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class ProductPostModel
    {
        public int TYPE { get; set; }
        public string VALUE_ { get; set; }
        public string FIRMNR { get; set; }
        public string CLIENTREF { get; set; }
        public int USERREF { get; set; }
    }
}
