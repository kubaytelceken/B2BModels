using B2BEcommerce.Models.Order;
using System.Collections.Generic;

namespace B2BEcommerce.Models.Report
{
    public class AccountStatementReportDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<AccountStatementReportModel> DATAS { get; set; }
    }
}
