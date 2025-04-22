using System;

namespace B2BEcommerce.Models.Report
{ 
    public class ShipmentInfModel
    {
        public string FICHENO { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public DateTime DATE_ { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string ITEM_NAME { get; set; }
        public string ITEM_CODE { get; set; }
        public double AMOUNT { get; set; }
        public string BRAND { get; set; }
        public string UNIT_CODE { get; set; }
    }
}
