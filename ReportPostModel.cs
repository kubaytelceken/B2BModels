using System;

namespace B2BEcommerce.Models.Report
{
    public class ReportPostModel
    {
        public DateTime BEGDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public int USERREF { get; set; }
        public string FIRMNR { get; set; }
        public int STATUS { get; set; }
        public int CLIENTREF { get; set; }
    }
}
