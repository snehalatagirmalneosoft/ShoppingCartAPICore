using ShoppingCart.DTO.DTO;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.Interfaces
{
    public interface IUserRoleService
    {
        void SaveUserRole(UserRoleDTO model);
        IEnumerable<UserRoleDTO> GetAllUserRoles();
    }
}
