using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class CategoryModel
    {
        public int RECORDREF { get; set; }
        public int PARENTREF { get; set; }
        public string NAME { get; set; }
        public int STATU { get; set; }
        public string CATEGORY_IMAGE { get; set; }
        public bool SHOW_LOT { get; set; }
        public string FIRMNR { get; set; }
        public List<CategoryFilterDetailModel> CATEGORYFILTERS { get; set; }
    }
}
