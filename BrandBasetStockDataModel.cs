using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class BrandBasetStockDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<BrandBasedStockModel> STOCKDEF { get; set; }
    }
}
