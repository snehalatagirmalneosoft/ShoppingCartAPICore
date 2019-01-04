using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShoppingCartArchitecture.Data.Models;
using ShoppingCart.BAL.Interfaces;
using ShoppingCart.DTO.DTO;
using ShoppingCart.Data.Models;

namespace ShoppingCart.API.Controllers
{
    [Produces("application/json")]
    [Route("api/ProductAPI")]
    public class ProductAPIController : Controller
    {
        IProductService _productService;
        public ShoppingCartOldDBContext Context;
        public ProductAPIController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetProductList")]
        public List<STP_ShowAllProductList> GetProductList()
        {
            return _productService.GetProductList();
        }

        [HttpGet("GetProductById")]
        public STP_ProductDetails GetProductById(int ProductId)
        {
            return _productService.GetProductById(ProductId);
        }

        [HttpDelete("DeleteProduct")]
        public string DeleteProduct(int ProductId)
        {
            int result = _productService.DeleteProduct(ProductId);
            if (result > 0)
            {
                return "Data deleted";
            }
            else
            {
                return "Data not deleted";
            }
        }

        [HttpPost("AddProduct")]
        public string AddProduct([FromBody]ProductDTO value)
        {
            try
            {
                List<STP_ShowAllProductList> data = this.GetProductList();
                if (data.ToList().Any(cat => cat.ProductName != value.ProductName))
                {
                    int result = _productService.AddProduct(value);
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

        [HttpPut("UpdateProduct")]
        public string UpdateProduct([FromBody]ProductDTO value)
        {
            try
            {
                List<STP_ShowAllProductList> data = this.GetProductList();
                if (data.ToList().Any(cat => cat.ProductId == value.ProductId))
                {
                    int result = _productService.UpdateProduct(value);
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