using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UserRole> userRoleRepository { get; }
        void Commit();
    }
}
