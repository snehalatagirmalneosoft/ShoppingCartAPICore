using AutoMapper;
using ShoppingCart.DTO.DTO;
using ShoppingCartArchitecture.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRoleDTO, UserRole>().ReverseMap();
        }
    }
}
