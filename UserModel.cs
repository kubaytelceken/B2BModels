using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class UserModel
    {
        public Nullable<int> RECORDREF { get; set; }
        [Required]
        public string NAME { get; set; }
        [Required]
        public string SURNAME { get; set; }
        [Required]
        public string EMAIL { get; set; }
        [Required]
        public string PASSWORD { get; set; }
        [Required]
        public Nullable<int> ACTIVE { get; set; }
        [Required]
        public string PHONE { get; set; }
        public int SALESMANREF { get; set; }
        public string SALESMAN_NAME { get; set; }
        [Required]
        public Nullable<int> USER_TYPE { get; set; }
        public Nullable<int> ORDER_MIN_BASKET_CONTROL { get; set; }
        [Required]
        public Nullable<int> ORG_REF { get; set; }
        [Required]
        public Nullable<double> BASKET_TOTAL { get; set; }
        public Nullable<double> MIN_BASKET_TOTAL { get; set; }
        public Nullable<double> MINUS_DISCOUNT_RATE { get; set; }
        [Required]
        public Nullable<int> CUSTOMER_CLASS { get; set; }
        [Required]
        public string FIRMNR { get; set; }
        [Required]
        public List<UserClientsModel> USERCLIENTS { get; set; }
        [Required]
        public List<UserRoleModel> ROLES { get; set; }
        [Required]
        public List<UserWareHouseModel> USERWAREHOUSES { get; set; }

    }
}
