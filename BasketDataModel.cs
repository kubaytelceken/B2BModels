using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class BasketDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<BasketModel> DATAS { get; set; }
        public BasketTotalModel TOTAL { get; set; }
        public List<BasketAlternativePaymentModel> ALTERNATE_PAYMENT { get; set; }
    }
}
