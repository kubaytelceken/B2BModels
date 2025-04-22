using System.Collections.Generic;

namespace B2BEcommerce.Models.General
{
    public class CityDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<CityModel> DATAS { get; set; }
    }
}
