using ShoppingCart.BAL.Interfaces;
using ShoppingCart.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.BusinessService
{
   public class UserService: IUserService
    {
        IUnitOfWork _unitOfWork;
        //private readonly IMapperFactory _mapperFactory;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
             
        }

        public object GetAllUser()
        {
            var list = _unitOfWork.userRepository.GetUserList();
            return list;
        }

        public object GetUserById(int Id)
        {
            var list = _unitOfWork.userRepository.GetUserDetail(Id);
            return list;
        }

    }
}
