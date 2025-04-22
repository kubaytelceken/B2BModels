using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class ParamsModel
    {
        public Nullable<int> RECORDREF { get; set; }
        public Nullable<int> LOGGED_IN_TIME { get; set; }
        public Nullable<int> RESET_PASSWORD_DAY { get; set; }
        public string DELETE_BASKET_TIME { get; set; }
        public string SMS_USERNAME { get; set; }
        public string SMS_PASSWORD { get; set; }
        public Nullable<int> SMTP_PORT { get; set; }
        public string SMTP_HOSTING { get; set; }
        public string SMTP_USERNAME { get; set; }
        public string SMTP_PASSWORD { get; set; }
        public Nullable<int> OFFICE_365 { get; set; }
        public string FIRMA_LOGO { get; set; }
        public string MAIL_SIGNATURE_URL { get; set; }
        public string FIRMNR { get; set; }
        

        public double MIN_BASKET_TOTAL { get; set; }
        public int ORDER_MIN_BASKET_CONTROL { get; set; }
        public int WEBSITE_ACTIVE { get; set; }
        public int PRODUCT_LIST_TYPE { get; set; }
        public bool BRAND { get; set; }
        public bool PRODUCT_CODE { get; set; }
        public bool PRODUCT_NAME { get; set; }
        public bool PAYMENT_CODE { get; set; }
        public bool DISCOUNT_RATE { get; set; }
        public bool UNIT_PRICE { get; set; }
        public bool DISCOUNT_PRICE { get; set; }
        public bool DISCOUNT_RATES { get; set; }
        public bool STOCK_AMOUNT { get; set; }

        public int BASKET_REZERV_TIME { get; set; }
        public int DECIMAL_CNT { get; set; }
        public int USE_BASKET_AMOUNT { get; set; }
        public int BANNER_CYCLE_TIME { get; set; }


    }
}
