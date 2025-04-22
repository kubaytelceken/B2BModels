using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class ProductListModel
    {
        public List<FiltersModel> FILTERS { get; set; }
        public List<ProductModel> PRODUCTS { get; set; }
    }
}
