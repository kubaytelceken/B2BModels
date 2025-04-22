using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class ProductModel
    {
        public int PRODUCT_REF { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string UNIT_CODE { get; set; }
        public double ONHAND { get; set; }
        public double PRICE { get; set; }
        public double DISCOUNT_RATE { get; set; }
        public double DISCOUNT_PRICE { get; set; }
        public double MIN_ORDER_QUANTITY { get; set; }
        public double VAT { get; set; }
        public string PAYMENTCODE { get; set; }
        public string PRODUCT_IMAGE { get; set; }
        public string BRAND { get; set; }
        public string CURRENCY { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public int SHOW_LOT { get; set; }
        public int CATEGORYREF { get; set; }

        public List<string> FILTERREFS { get; set; }
    }
}
