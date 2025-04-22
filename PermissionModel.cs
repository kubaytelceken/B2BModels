using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B2BEcommerce.Models.Management
{
    public class PermissionModel
    {
        public int RECORDREF { get; set; }
        public int PARENT_MENUREF { get; set; }
        public string NAME { get; set; }
        public int PROGRAMREF { get; set; }
        public int PLOGICALREF { get; set; }
        public int PERMISSIONREF { get; set; }
    }
}
