namespace B2BEcommerce.Models.Order
{
    public class OrderSummaryModel
    {
        public decimal ORDER_AMOUNT { get; set; }
        public decimal DISCOUNT { get; set; }
        public decimal NET_AMOUNT { get; set; }
        public decimal VAT_AMOUNT { get; set; }
        public decimal TOTAL_AMOUNT { get; set; }
    }
}
