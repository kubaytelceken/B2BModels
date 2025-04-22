using System;

namespace B2BEcommerce.Models.Report
{
    public class WaitOrdersReportModel
    {
        public string ORDER_NUMBER { get; set; }
        public DateTime ORDER_DATE { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        public DateTime DUE_DATE { get; set; }
        public decimal AMOUNT { get; set; }
        public string UNIT_CODE { get; set; }
        public string BRAND { get; set; }
        public string EXPIRY { get; set; }
        public decimal DISCOUNT_RATE { get; set; }
        public decimal DISCOUNT_AMOUNT { get; set; }
        public decimal SHIP_AMOUNT { get; set; }
        public decimal REMAINING_AMOUNT { get; set; }
        public decimal UNIT_PRICE { get; set; }
        public decimal WAIT_TOTAL_VATIND { get; set; }
        public decimal WAIT_TOTAL { get; set; }
    }
}
