using System;

namespace B2BEcommerce.Models.Report
{
    public class DashboardPostModel
    {
        public DateTime BEGDATE { get; set; }
        public DateTime ENDDATE { get; set; }
        public int USERREF { get; set; }
        public string FIRMNR { get; set; }
    }
}
