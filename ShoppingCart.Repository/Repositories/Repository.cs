using Microsoft.EntityFrameworkCore;
using ShoppingCart.Data.Models;
using ShoppingCart.DTO.DTO;
using ShoppingCart.Repository.Interfaces;
using ShoppingCart.Repository.UnitOfWorks;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ShoppingCart.Repository.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        //  private readonly UnitOfWork _unitOfWork;
        public ShoppingCartOldDBContext Context;
        public Repository(ShoppingCartOldDBContext context)
        {
            Context = context;
        }
        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void Delete(int id)
        {
            T existing = Context.Set<T>().Find(id);
            if (existing != null)
                Context.Set<T>().Remove(existing);
        }

        public IEnumerable<T> Get()
        {
            return Context.Set<T>().AsEnumerable<T>();
        }

        public T GetByID(int id)
        {
            return Context.Set<T>().Find(id);
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            Context.Set<T>().Attach(entity);
        }

        #region User Module
        public object GetUserList()
        {
            return Context.GetUsers();
        }

        public object GetUserDetail(int Id)
        {
            return Context.GetUserDetails(Id);
        }
        #endregion

        #region Sub Category Module

        public List<STP_GetAllSubCategories> GetSubCategoryList()
        {
            return Context.GetSubCategoryList();
        }

        public STP_GetSubCategoryDetails GetSubCategoryDetail(int SubCategoryId)
        {
            return Context.GetSubCategoryDetail(SubCategoryId);
        }

        public int DeleteSubCategory(int SubCategoryId)
        {
            int result = 0;
            T existing = Context.Set<T>().Find(SubCategoryId);
            if (existing != null)
            {
                Context.Set<T>().Remove(existing);
                return result = 1;
            }
            else {
                return result;
            }
        }

        public int AddSubCategory(T entity)
        {
            int result = 0;
            if (entity != null)
            {
                Context.Set<T>().Add(entity);
                return result = 1;
            }
            else
            {
                return result;
            }
        }

        public int UpdateSubCategory(T entity)
        {
            int result = 0;
            if (entity != null)
            {
                Context.Entry(entity).State = EntityState.Modified;
                Context.SaveChanges();
                Context.Set<T>().Attach(entity);
                return result = 1;
            }
            else
            {
                return result;
            }
        }
        #endregion

        #region Category Module

        public List<Category> GetCategoryList()
        {
            return Context.Set<Category>().AsNoTracking().AsEnumerable<Category>().ToList();
        }

        public Category GetCategoryDetail(int CategoryId)
        {
            return Context.Set<Category>().Find(CategoryId);
        }

        public int DeleteCategory(int CategoryId)
        {
            int result = 0;
            T existing = Context.Set<T>().Find(CategoryId);
            if (existing != null)
            {
                Context.Set<T>().Remove(existing);
                return result = 1;
            }
            else
            {
                return result;
            }
        }

        public int AddCategory(T entity)
        {
            int result = 0;
            if (entity != null)
            {
                Context.Set<T>().Add(entity);
                return result = 1;
            }
            else
            {
                return result;
            }
        }

        public int UpdateCategory(T entity)
        {
            int result = 0;
            if (entity != null)
            {
                Context.Entry(entity).State = EntityState.Modified;
                Context.SaveChanges();
                Context.Set<T>().Attach(entity);
                return result = 1;
            }
            else
            {
                return result;
            }
        }
        #endregion

        #region Product Module

        public List<STP_ShowAllProductList> GetProductList()
        {
            return Context.GetProductList();
        }

        public STP_ProductDetails GetProductDetail(int ProductId)
        {
            return Context.GetProductDetail(ProductId);
        }

        public int DeleteProduct(int ProductId)
        {
            return Context.DeleteProduct(ProductId);
        }

        public int AddProduct(Product model, DataTable tempProductImages)
        {
            return Context.AddProduct(model, tempProductImages);            
        }

        public int UpdateProduct(Product model, DataTable tempProductImages)
        {
            return Context.UpdateProduct(model, tempProductImages);
        }
        #endregion
    }
}
