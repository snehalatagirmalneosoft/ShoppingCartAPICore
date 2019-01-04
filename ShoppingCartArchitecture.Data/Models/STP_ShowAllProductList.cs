using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Data.Models
{
   public class STP_ShowAllProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int SubCategoryId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
