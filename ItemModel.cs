using System.Collections.Generic;

namespace B2BEcommerce.Models.Management
{
    public class ItemModel
    {
        public int RECORDREF { get; set; }
        public int ITEMREF { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string B2B_NAME { get; set; }
        public string UNIT_CODE { get; set; }
        public string BARCODE { get; set; }
        public double SELLVAT { get; set; }
        public double MIN_ORDER_QUANTITY { get; set; }
        public int ACTIVE { get; set; }
        public int CATEGORYREF { get; set; }
        public string CATEGORY_NAME { get; set; }
        public int FILTERVALREF { get; set; }
        public double PRICE { get; set; }
        public string CURRENCY { get; set; }
        public List<ItemImageModel> ITEM_IMAGES { get; set; }
    }
}
