namespace B2BEcommerce.Models.Report
{
    public class DetailedSalesReportModel
    {
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        public string BRAND { get; set; }
        public string UNIT_CODE { get; set; }
        public decimal SALES_AMOUNT { get; set; }
        public decimal RETURN_AMOUNT { get; set; }
        public decimal SALES_TOTAL { get; set; }
        public decimal DISCOUNT_TOTAL { get; set; }
        public decimal RETURN_TOTAL { get; set; }
    }
}
