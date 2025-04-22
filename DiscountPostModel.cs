using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class DiscountPostModel
    {
        public string FIRMNR { get; set; }
        public List<DiscountDefinationModel> DISCOUNTS { get; set; }
    }
}
