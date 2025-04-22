using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class BannerDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<BannerModel> BANNERLIST { get; set; }
    }
}
