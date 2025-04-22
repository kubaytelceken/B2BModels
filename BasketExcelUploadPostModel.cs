using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Report
{
    public class BasketExcelUploadPostModel
    {
        public string FIRMNR { get; set; }
        public string BASKET_NAME { get; set; }
        public int CLIENTREF { get; set; }
        public int USERREF { get; set; }
        public List<BasketExcelUploadModel> PRODUCTS { get; set; }
    }
}
