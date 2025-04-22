namespace B2BEcommerce.Models.Order
{
    public class BasketAlternativePaymentModel
    {
        public string CLIENTREF { get; set; }
        public string PAYMENT_CODE { get; set; }
        public double ORDER_AMOUNT { get; set; }
        public bool SELECT_ALTERNATE { get; set; }
    }
}
