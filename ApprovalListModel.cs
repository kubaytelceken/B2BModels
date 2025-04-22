namespace B2BEcommerce.Models.Order
{  
    public class ApprovalListModel
    {
        public int ORDERREF { get; set; }
        public string ORDER_NUMBER { get; set; }
        public string REQUEST_USER { get; set; }
        public string REQUEST_DATE { get; set; }
        public string CUSTOMER_TITLE { get; set; }
        public string ORDER_DESC { get; set; }
        public double ORDER_TOTAL { get; set; }
        public string CURRNAME { get; set; }
        public string PAYMENT_CODE { get; set; }
    }
}
