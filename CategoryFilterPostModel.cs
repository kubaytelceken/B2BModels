using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class CategoryFilterPostModel
    {
        public string FIRMNR { get; set; }
        public List<CategoryFilterModel> FILTERS { get; set; }
    }
}
