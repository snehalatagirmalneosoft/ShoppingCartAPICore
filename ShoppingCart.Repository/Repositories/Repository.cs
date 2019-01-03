using Microsoft.EntityFrameworkCore;
using ShoppingCart.Repository.Interfaces;
using ShoppingCart.Repository.UnitOfWorks;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
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

        public object GetUserList()
        {
            return Context.GetUsers();
        }

        public object GetUserDetail(int Id)
        {
            return Context.GetUserDetails(Id);
        }

    }
}
