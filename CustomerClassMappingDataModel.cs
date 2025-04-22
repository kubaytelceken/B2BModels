using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class CustomerClassMappingDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<CustomerClassMappingModel> DATAS { get; set; }
    }
}
