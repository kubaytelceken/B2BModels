using System.Collections.Generic;

namespace B2BEcommerce.Models.Report
{
    public class OrderTransactionDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<OrderTransactionModel> DATAS { get; set; }
    }
}
