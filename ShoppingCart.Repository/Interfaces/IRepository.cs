using System;
using System.Collections.Generic;
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

        object GetUserList();
        object GetUserDetail(int Id);
    }
}
