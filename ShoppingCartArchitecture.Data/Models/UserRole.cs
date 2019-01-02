using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            SubMenu = new HashSet<SubMenu>();
            UserMaster = new HashSet<UserMaster>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<SubMenu> SubMenu { get; set; }
        public ICollection<UserMaster> UserMaster { get; set; }
    }
}
