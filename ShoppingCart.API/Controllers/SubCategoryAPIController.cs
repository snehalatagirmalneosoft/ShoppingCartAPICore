using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.BAL.Interfaces;
using ShoppingCart.Data.Models;
using ShoppingCart.DTO.DTO;
using ShoppingCartArchitecture.Data.Models;

namespace ShoppingCart.API.Controllers
{
    [Produces("application/json")]
    [Route("api/SubCategoryAPI")]
    public class SubCategoryAPIController : Controller
    {
        ISubCategoryService _subCategoryService;
        public ShoppingCartOldDBContext Context;
        public SubCategoryAPIController(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        [HttpGet("GetSubCategoryList")]
        public List<STP_GetAllSubCategories> GetSubCategoryList()
        {
            return _subCategoryService.GetSubCategoryList();
        }

        [HttpGet("GetSubCategoryById")]
        public STP_GetSubCategoryDetails GetSubCategoryById(int SubCategoryId)
        {
            return _subCategoryService.GetSubCategoryById(SubCategoryId);
        }

        [HttpDelete("DeleteSubCategory")]
        public string DeleteSubCategory(int SubCategoryId)
        {
            int result = _subCategoryService.DeleteSubCategory(SubCategoryId);
            if (result > 0)
            {
                return "Data deleted";
            }
            else {
                return "Data not deleted";
            }
        }

        [HttpPost("AddSubCategory")]
        public string AddSubCategory([FromBody]SubCategoryDTO value)
        {
            try
            {
                List<STP_GetAllSubCategories> data = this.GetSubCategoryList();
                if (data.ToList().Any(cat => cat.SubCategoryName != value.SubCategoryName))
                {           
                    int result = _subCategoryService.AddSubCategory(value);
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

        [HttpPut("UpdateSubCategory")]
        public string UpdateSubCategory([FromBody]SubCategoryDTO value)
        {
            try
            {
                List<STP_GetAllSubCategories> data = this.GetSubCategoryList();
                if (data.ToList().Any(cat => cat.SubCategoryId == value.SubCategoryId))
                {
                    int result = _subCategoryService.UpdateSubCategory(value);
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