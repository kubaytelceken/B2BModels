using System;

namespace B2BEcommerce.Models.Management
{
    public class BannerModel
    {
        public Nullable<int> RECORDREF { get; set; }
        public string DEFINATION { get; set; }
        public string BANNER { get; set; }
        public Nullable<int> ORDER_NO { get; set; }
        public string URL { get; set; }
        public int STATUS { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }
    }
}
