using ShoppingCart.Data.Models;
using ShoppingCart.DTO.DTO;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace ShoppingCart.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        T GetByID(int id);
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);

        //for user module
        object GetUserList();
        object GetUserDetail(int Id);

        //for subCategory module
        List<STP_GetAllSubCategories> GetSubCategoryList();
        STP_GetSubCategoryDetails GetSubCategoryDetail(int SubCategoryId);
        int DeleteSubCategory(int SubCategoryId);
        int AddSubCategory(T entity);
        int UpdateSubCategory(T entity);

        //for category module
        List<Category> GetCategoryList();
        Category GetCategoryDetail(int SubCategoryId);
        int DeleteCategory(int SubCategoryId);
        int AddCategory(T entity);
        int UpdateCategory(T entity);

        //for product module
        List<STP_ShowAllProductList> GetProductList();
        STP_ProductDetails GetProductDetail(int ProductId);
        int DeleteProduct(int ProductId);
        int AddProduct(Product model, DataTable tempProductImages);
        int UpdateProduct(Product model, DataTable tempProductImages);
    }
}

