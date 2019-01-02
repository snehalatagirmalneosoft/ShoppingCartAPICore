using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.Mapper
{
    public interface IMapperFactory
    {
        T GetDto<T>(object source) where T : class;
        IMapper IMapper { get; }
    }
}
