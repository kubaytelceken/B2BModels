using System.Collections.Generic;

namespace B2BEcommerce.Models.Report
{
    public class ApprovalHistoryDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<ApprovalHistoryModel> DATAS { get; set; }
    }
}
