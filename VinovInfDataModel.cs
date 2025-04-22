using System.Collections.Generic;

namespace B2BEcommerce.Models.Report
{
    public class VinovInfDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<VinovInfModel> DATAS { get; set; }
    }
}
