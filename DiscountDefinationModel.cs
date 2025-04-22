namespace B2BEcommerce.Models.Management
{
    public class DiscountDefinationModel
    {
        public int RECORDREF { get; set; }
        public string BRAND { get; set; }
        public string PRODUCT_TYPE { get; set; }
        public int CUSTOMER_CLASS_ID { get; set; }
        public string CUSTOMER_CLASS { get; set; }
        public string PAYMENT_CODE { get; set; }
        public double DISCOUNT_RATE { get; set; }
        public int STATUS { get; set; }
    }
}
