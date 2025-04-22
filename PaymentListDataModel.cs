using System.Collections.Generic;

namespace B2BEcommerce.Models.General
{
    public class PaymentListDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<PaymentModel> DATAS { get; set; }
    }
}
