using System.Collections.Generic;

namespace B2BEcommerce.Models.Report
{
    public class DailyProcessReportDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<DailyProcessReportModel> DATAS { get; set; }
    }
}
