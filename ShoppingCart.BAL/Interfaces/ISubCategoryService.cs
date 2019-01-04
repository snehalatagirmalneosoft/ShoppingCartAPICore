using ShoppingCart.Data.Models;
using ShoppingCart.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.Interfaces
{
   public interface ISubCategoryService
    {
        List<STP_GetAllSubCategories> GetSubCategoryList();
        STP_GetSubCategoryDetails GetSubCategoryById(int SubCategoryId);
        int DeleteSubCategory(int SubCategoryId);
        int AddSubCategory(SubCategoryDTO model);
        int UpdateSubCategory(SubCategoryDTO model);
    }
}
