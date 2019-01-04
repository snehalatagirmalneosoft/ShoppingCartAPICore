using System;
using System.Collections.Generic;
using System.Text;
using ShoppingCart.DTO.DTO;
using ShoppingCartArchitecture.Data.Models;
using ShoppingCart.Data.Models;

namespace ShoppingCart.BAL.Interfaces
{
   public interface IProductService
    {
        List<STP_ShowAllProductList> GetProductList();
        STP_ProductDetails GetProductById(int ProductId);
        int DeleteProduct(int ProductId);
        int AddProduct(ProductDTO model);
        int UpdateProduct(ProductDTO model);
    }
}
