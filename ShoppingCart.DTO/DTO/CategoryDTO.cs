using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCartArchitecture.Data.Models;

namespace ShoppingCart.DTO.DTO
{
   public class CategoryDTO
    {
        public CategoryDTO()
        {
            SubCategory = new HashSet<SubCategory>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? ModifiedBy { get; set; }
        public bool IsActive { get; set; }

        public ICollection<SubCategory> SubCategory { get; set; }
    }
}
