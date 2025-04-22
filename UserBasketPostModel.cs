using System.Collections.Generic;

namespace B2BEcommerce.Models.Report
{
    public class UserBasketPostModel
    {
        public int STATUS { get; set; }
        public List<int> BASKETREFS { get; set; }
        public string FIRMNR { get; set; }
    }
}
