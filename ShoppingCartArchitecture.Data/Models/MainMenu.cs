using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class MainMenu
    {
        public MainMenu()
        {
            SubMenu = new HashSet<SubMenu>();
        }

        public int MainMenuId { get; set; }
        public string MainMenuName { get; set; }

        public ICollection<SubMenu> SubMenu { get; set; }
    }
}
