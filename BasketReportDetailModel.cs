using System;

namespace B2BEcommerce.Models.Report
{
    public class BasketReportDetailModel
    {

        public int RECORDREF { get; set; }
        public int USERREF { get; set; }
        public string CLIENT_CODE { get; set; }
        public string CLIENT_NAME { get; set; }
        public string STOCKCODE { get; set; }
        public string STOCKNAME { get; set; }
        public double AMOUNT { get; set; }
        public double DISCOUNT { get; set; }
        public double PRICE { get; set; }
        public string BRAND { get; set; }
        public string BASKET_STATUS { get; set; }
        public DateTime PROCESS_DATE { get; set; }
    }
}
