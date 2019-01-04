using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Data.Models
{
   public class STP_ProductDetails
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string CreatedBy { get; set; }
        public bool? IsActive { get; set; }
    }
}
