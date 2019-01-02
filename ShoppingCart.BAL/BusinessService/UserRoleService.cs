using ShoppingCart.BAL.Interfaces;
using ShoppingCart.BAL.Mapper;
using ShoppingCart.DTO.DTO;
using ShoppingCart.Repository.Interfaces;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.BusinessService
{
    public class UserRoleService : IUserRoleService
    {
        IUnitOfWork _unitOfWork;
        private readonly IMapperFactory _mapperFactory;
        public UserRoleService(IUnitOfWork unitOfWork, IMapperFactory mapperFactory)
        {
            _unitOfWork = unitOfWork;
            _mapperFactory = mapperFactory;
        }
        public void SaveUserRole(UserRoleDTO model)
        {
            var role= _mapperFactory.IMapper.Map<UserRoleDTO, UserRole>(model);
            _unitOfWork.userRoleRepository.Add(role);
            _unitOfWork.Commit();
        }
        
        public IEnumerable<UserRoleDTO> GetAllUserRoles()
        {
            var list = _unitOfWork.userRoleRepository.Get();
            return _mapperFactory.IMapper.Map<IEnumerable<UserRole>, IEnumerable<UserRoleDTO>>(list);
        }
    }
}
