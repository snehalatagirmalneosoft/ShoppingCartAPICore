using System;
using System.Collections.Generic;

namespace ShoppingCartArchitecture.Data.Models
{
    public partial class SubCategory
    {
        public SubCategory()
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
