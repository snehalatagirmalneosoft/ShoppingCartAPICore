using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.Interfaces
{
   public interface IUserService
    {
       // void SaveUserRole(UserRoleDTO model);
        object GetAllUser();
        object GetUserById(int Id);
    }
}
