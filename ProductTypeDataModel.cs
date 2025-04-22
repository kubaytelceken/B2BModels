using BT_B2BApi.Model.MasterData;
using System.Collections.Generic;

namespace B2BEcommerce.Models.General
{
    public class ProductTypeDataModel
    {
        public int STATU { get; set; }
        public string MSG { get; set; }
        public int DATA_COUNT { get; set; }
        public List<ProductTypeModel> DATAS { get; set; }
    }
}
