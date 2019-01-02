using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int? Quantity { get; set; }
        public decimal? Price { get; set; }

        public Product Product { get; set; }
        public UserMaster User { get; set; }
    }
}
