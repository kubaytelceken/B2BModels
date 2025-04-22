namespace B2BEcommerce.Models.Order
{
    public class BasketTotalModel
    {
        public double ORDER_AMOUNT { get; set; }
        public double DISCOUNT { get; set; }
        public double NET_AMOUNT { get; set; }
        public double VAT_AMOUNT { get; set; }
        public double TOTAL_AMOUNT { get; set; }
    }
}
