using System;

namespace B2BEcommerce.Models.Order
{
    public class OrdersListPostModel
    {
        public string FIRMNR { get; set; }
        public int USERREF { get; set; }
        public int TYPE_ { get; set; }
        public DateTime BEGDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public int STATUS { get; set; }
    }
}
