using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Order
{
    public class FiltersModel
    {
        public string FILTER_TYPE { get; set; }
        public List<FilterValuesModel> VALUES { get; set; }
    }
}
