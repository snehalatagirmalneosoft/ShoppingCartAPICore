using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartArchitecture.Data.Models;
using ShoppingCart.BAL.Interfaces;
using ShoppingCart.DTO.DTO;

namespace ShoppingCart.API.Controllers
{
    [Produces("application/json")]
    [Route("api/CategoryAPI")]
    public class CategoryAPIController : Controller
    {
        ICategoryService _categoryService;
        public ShoppingCartOldDBContext Context;
        public CategoryAPIController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("GetCategoryList")]
        public List<Category> GetCategoryList()
        {
            return _categoryService.GetCategoryList();
        }

        [HttpGet("GetCategoryById")]
        public Category GetCategoryById(int CategoryId)
        {
            return _categoryService.GetCategoryById(CategoryId);
        }

        [HttpDelete("DeleteCategory")]
        public string DeleteCategory(int CategoryId)
        {
            int result = _categoryService.DeleteCategory(CategoryId);
            if (result > 0)
            {
                return "Data deleted";
            }
            else
            {
                return "Data not deleted";
            }
        }

        [HttpPost("AddCategory")]
        public string AddCategory([FromBody]CategoryDTO value)
        {
            try
            {
                List<Category> data = this.GetCategoryList();
                if (data.ToList().Any(cat => cat.CategoryName != value.CategoryName))
                {
                    int result = _categoryService.AddCategory(value);
                    if (result > 0)
                    {
                        return "Data saved";
                    }
                    else
                    {
                        return "Data not saved";
                    }
                }
                else
                {
                    return "Data already exist";
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut("UpdateCategory")]
        public string UpdateCategory([FromBody]CategoryDTO value)
        {
            try
            {
                List<Category> data = this.GetCategoryList();
                if (data.ToList().Any(cat => cat.CategoryId == value.CategoryId))
                {
                    int result = _categoryService.UpdateCategory(value);
                    if (result > 0)
                    {
                        return "Data updated";
                    }
                    else
                    {
                        return "Data not updated";
                    }
                }
                else
                {
                    return "Data already exist";
                }
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
    }
}