using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class CustomerClassMappingSaveModel
    {
        public string FIRMNR { get; set; }
        public string TYPE { get; set; }
        public List<CustomerClassMappingModel> CUSTOMER_CLASS { get; set; }
    }
}
