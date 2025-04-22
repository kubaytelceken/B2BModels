using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class SaveItemFilterModel
    {
        public string FIRMNR { get; set; }
        public string B2B_NAME { get; set; }
        public string ITEMREF { get; set; }
        public string CATEGORYREF { get; set; }
        public List<ItemFilterModel2> FILTERVALUES { get; set; }
        public List<ItemImageModel> ITEM_IMAGES { get; set; }
    }
}
