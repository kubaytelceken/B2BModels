using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class CustomerClassDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<CustomerClassModel> CUSTOMERCLASSLIST { get; set; }
    }
}
