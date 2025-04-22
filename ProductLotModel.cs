using System.Collections.Generic;

namespace B2BEcommerce.Models.Order
{
    public class ProductLotModel
    {
        public int PRODUCT_REF { get; set; }
        public int ITEM_ERP_REF { get; set; }
        public string PRODUCT_CODE { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string UNIT_CODE { get; set; }
        public decimal ONHAND { get; set; }
        public decimal PRICE { get; set; }
        public decimal DISCOUNT_RATE { get; set; }
        public decimal DISCOUNT_PRICE { get; set; }
        public decimal MIN_ORDER_QUANTITY { get; set; }
        public decimal VAT { get; set; }
        public string PAYMENTCODE { get; set; }
        public string CURRENCY { get; set; }
        public string PRODUCT_IMAGE { get; set; }
        public string BRAND { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public int SHOW_LOT { get; set; }
        public int CATEGORYREF { get; set; }
        public double LOT_CODE { get; set; }
        public decimal LOT_AMOUNT { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
        public decimal PLUS_DISCOUNT { get; set; }

        public List<string> FILTERREFS { get; set; }
    }
}
