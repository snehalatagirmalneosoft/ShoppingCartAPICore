using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Data.Models
{
   public class STP_GetAllSubCategories
    {
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
