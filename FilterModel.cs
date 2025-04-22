using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class FilterModel
    {
        public int RECORDREF { get; set; }
        public string VALUE_ { get; set; }
        public int STATU { get; set; }
        public int USE_DISCOUNT { get; set; }
        public int USE_PLUS_DISCOUNT { get; set; }
        public int USE_MINUS_DISCOUNT { get; set; }
        public List<FilterValuesModel> VALUES { get; set; }
    }
}
