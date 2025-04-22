using System;

namespace B2BEcommerce.Models.Report
{
    public class DailyProcessReportModel
    {
        public string FICHENO { get; set; }
        public DateTime DATE_ { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string ITEM_CODE { get; set; }
        public string ITEM_NAME { get; set; }
        public string UNIT_CODE { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal UNIT_PRICE { get; set; }
        public string ENTRY_USER { get; set; }
        public string APPROVE_USER { get; set; }
        public string APPROVE_COMMENT { get; set; }
        public string STATU { get; set; }
    }
}
