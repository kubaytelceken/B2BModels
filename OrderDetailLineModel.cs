namespace B2BEcommerce.Models.Order
{
    public class OrderDetailLineModel
    {
        public int RECORDREF { get; set; }
        public int MASTERREF { get; set; }
        public int STOCKREF { get; set; }
        public string BRAND { get; set; }
        public string STOCKCODE { get; set; }
        public string STOCKNAME { get; set; }
        public decimal DISCOUNT { get; set; }
        public decimal AMOUNT { get; set; }
        public decimal GROSS_PRICE { get; set; }
        public decimal PRICE { get; set; }
        public decimal VAT { get; set; }
        public string UOMCODE { get; set; }
        public string CURRNAME { get; set; }
        public decimal RATE { get; set; }
    }
}
