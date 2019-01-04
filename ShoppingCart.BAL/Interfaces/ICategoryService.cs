using ShoppingCart.DTO.DTO;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.Interfaces
{
    public interface ICategoryService
    {
        List<Category> GetCategoryList();
        Category GetCategoryById(int CategoryId);
        int DeleteCategory(int CategoryId);
        int AddCategory(CategoryDTO model);
        int UpdateCategory(CategoryDTO model);
    }
}
