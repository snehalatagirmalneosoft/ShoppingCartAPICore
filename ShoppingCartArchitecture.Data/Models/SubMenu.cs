using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class SubMenu
    {
        public int SubMenuId { get; set; }
        public string SubMenuName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public int? MainMenuId { get; set; }
        public int? RoleId { get; set; }

        public MainMenu MainMenu { get; set; }
        public UserRole Role { get; set; }
    }
}
