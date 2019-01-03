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
            var list = _unitOfWork.userRepository.GetSP();
            return list;
        }

       
    }
}
