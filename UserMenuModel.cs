using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.General
{
    public class UserMenuModel
    {
        public int RECORDREF { get; set; }
        public int PARENT_MENUREF { get; set; }
        public string NAME { get; set; }
        public int PROGRAMREF { get; set; }
        public string URL { get; set; }
        public string ICON { get; set; }
        public int ACTIVE { get; set; }
        public int SIRA { get; set; }
        public List<int> PERMISSION { get; set; }
    }
}
