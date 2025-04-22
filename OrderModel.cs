using BT_B2BApi.Model.MasterData;
using System.Collections.Generic;
using System;

namespace B2BEcommerce.Models.Order
{
    public class OrderModel
    {
        public int RECORDREF { get; set; }
        public string ORDER_NUMBER { get; set; }
        public DateTime ORDER_DATE { get; set; }
        public int CLIENTREF { get; set; }
        public int SALESMANREF { get; set; }
        public int TYPE_ { get; set; } // 1 - Sipariş, 2 - Teklif
        public int USERREF { get; set; }
        public string PAYMENT_CODE { get; set; }
        public string ORDER_DESC { get; set; }
        public int OFFERREF { get; set; }
        public ShipModel SHIPINFO { get; set; }
        public List<OrderLineModel> ORDERLINES { get; set; }
    }
}
