using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class BrandBasedSaveModel
    {
        public string FIRMNR { get; set; }
        public List<BrandBasedStockModel> BRANDBASED { get; set; }
    }
}
