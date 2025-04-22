using BT_B2BApi.Model.MasterData;
using System.Collections.Generic;
using System;

namespace B2BEcommerce.Models.Order
{
    public class OrderDetailModel
    {
        public int RECORDREF { get; set; }
        public string ORDER_NUMBER { get; set; }
        public DateTime ORDER_DATE { get; set; }
        public int CUSTOMER_ID { get; set; }
        public string CUSTOMER_CODE { get; set; }
        public string CUSTOMER_TITLE { get; set; }
        public int SHIPINFOREF { get; set; }
        public int ORDER_USERREF { get; set; }
        public ShipDetailModel SHIPINFO { get; set; }
        public string SALESMANCODE { get; set; }
        public string PAYMENT_CODE { get; set; }
        public int STATU { get; set; }
        public string STATU_STR { get; set; }
        public string ORDER_DESC { get; set; }
        public int? APPROVE_STATUS { get; set; }
        public int? APPROVE_USERREF { get; set; }
        public string APPROVE_COMMENT { get; set; }
        public List<OrderDetailLineModel> LINES { get; set; }
        public OrderSummaryModel ORDER_SUMMARY { get; set; }
    }
}
