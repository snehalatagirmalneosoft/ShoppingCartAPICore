using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class Product
    {
        public Product()
        {
            Cart = new HashSet<Cart>();
            Images = new HashSet<Images>();
            OrderDetail = new HashSet<OrderDetail>();
        }

        public int ProductId { get; set; }
        public int? SubCategoryId { get; set; }
        public string ProductName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public bool? IsActive { get; set; }
        public int? Quantity { get; set; }

        public SubCategory SubCategory { get; set; }
        public ICollection<Cart> Cart { get; set; }
        public ICollection<Images> Images { get; set; }
        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
