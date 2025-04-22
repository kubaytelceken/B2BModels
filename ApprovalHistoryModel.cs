using System;

namespace B2BEcommerce.Models.Report
{
    public class ApprovalHistoryModel
    {
        public string ORDER_NUMBER { get; set; }
        public string REQUEST_USER { get; set; }
        public DateTime REQUEST_DATE { get; set; }
        public string APPROVE_USER { get; set; }
        public DateTime APPROVAL_DATE { get; set; }
        public string STATUS { get; set; }
        public string DESCRIPTION { get; set; }
    }
}
