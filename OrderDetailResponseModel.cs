namespace B2BEcommerce.Models.Order
{
    public class OrderDetailResponseModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public OrderDetailModel ORDER { get; set; }
    }
}
