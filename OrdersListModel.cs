using System;

namespace B2BEcommerce.Models.Order
{
    public class OrdersListModel
    {
        public int RECORDREF { get; set; }
        public string ORDER_NUMBER { get; set; }
        public DateTime ORDER_DATE { get; set; }
        public string PAYMENT_CODE { get; set; }
        public string TITLE { get; set; }
        public string STATU { get; set; }
        public double ORDER_TOTAL { get; set; }
        public string OFFER_EXCEL { get; set; }
        public string OFFER_PDF { get; set; }
    }
}
