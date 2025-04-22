using System.Collections.Generic;

namespace B2BEcommerce.Models.Order
{
    public class OrdersListDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<OrdersListModel> DATAS { get; set; }
    }
}
