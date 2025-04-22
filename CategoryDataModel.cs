using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class CategoryDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<CategoryModel> CATEGORYLIST { get; set; }
    }
}
