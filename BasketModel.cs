using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class BasketModel
    {
        public int RECORDREF { get; set; }
        public string BRAND { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public string BASKET_NAME { get; set; }
        public int STOCKREF { get; set; }
        public int MIN_ORDER_QUANTITY { get; set; }
        public string STOCKCODE { get; set; }
        public string STOCKNAME { get; set; }
        public double AMOUNT { get; set; }
        public double DISCOUNT { get; set; }
        public double GROSSPRICE { get; set; }
        public double ONHAND { get; set; }
        public double PRICE { get; set; }
        public double VAT { get; set; }
        public string UOMCODE { get; set; }
        public double DISCPER { get; set; }
        public double PLUS_DISCPER { get; set; }
        public double MINUS_DISCPER { get; set; }
        public string CURRNAME { get; set; }
        public double CURRRATE { get; set; }
        public string PRODUCT_IMAGE { get; set; }
        public int EDIT_BASKET { get; set; }
        public int OFFERREF { get; set; }
    }
}
