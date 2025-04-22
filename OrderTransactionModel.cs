using System;

namespace B2BEcommerce.Models.Report
{ 
    public class OrderTransactionModel
    {
        public DateTime DATE_ { get; set; }
        public string FICHENO { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        public string BRAND { get; set; }
        public double AMOUNT { get; set; }
        public string UNIT_CODE { get; set; }
        public double UNIT_PRICE { get; set; }
        public double DISCOUNT_RATE { get; set; }
        public double NETTOTAL { get; set; }
        public double TOTAL { get; set; }
    }
}
