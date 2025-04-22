using System;

namespace B2BEcommerce.Models.Report
{
    public class AccountStatementReportModel
    {
        public int LINENR { get; set; }
        public DateTime DATE_ { get; set; }
        public DateTime DUE_DATE { get; set; }
        public string FICHETYPE { get; set; }
        public string DOCNUMBER { get; set; }
        public string FICHENO { get; set; }
        public string DESC { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public double DEBIT { get; set; }
        public double CREDIT { get; set; }
        public double BALANCE { get; set; }
        public string TYPE_ { get; set; }
    }
}
