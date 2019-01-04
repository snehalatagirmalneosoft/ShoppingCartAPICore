using ShoppingCart.Data.Models;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<UserRole> userRoleRepository { get; }

        IRepository<STP_GetUsers> userRepository { get; }

        IRepository<SubCategory> subCategoryRepository { get; }

        IRepository<Category> categoryRepository { get; }

        IRepository<Product> productRepository { get; }
        void Commit();
    }
}
