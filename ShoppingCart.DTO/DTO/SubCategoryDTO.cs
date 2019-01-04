using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.DTO.DTO
{
   public class SubCategoryDTO
    {
        public SubCategoryDTO()
        {
            Product = new HashSet<Product>();
        }

        public int SubCategoryId { get; set; }
        public int? CategoryId { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public string SubCategoryName { get; set; }

        public Category Category { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
