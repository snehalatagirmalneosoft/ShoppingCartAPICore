using ShoppingCart.Data.Models;
using ShoppingCart.Repository.Interfaces;
using ShoppingCart.Repository.Repositories;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repository.UnitOfWorks
{
    public class UnitOfWork : BaseRepository, IUnitOfWork
    {
       // public ShoppingCartOldDBContext Context { get; }
        public void Commit()
        {
            Context.SaveChanges();
        }
        IRepository<UserRole> IUnitOfWork.userRoleRepository => 
            new Repository<UserRole>(Context);

        public IRepository<STP_GetUsers> userRepository => new Repository<STP_GetUsers>(Context);

        public void Dispose()
        {
            Context.Dispose();
        }
    }
}
