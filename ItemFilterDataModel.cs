using B2BEcommerce.Models.General;
using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class ItemFilterDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<ItemFilterModel> ITEMFILTERS { get; set; }
    }
}
