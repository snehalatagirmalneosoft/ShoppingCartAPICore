using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.BAL.Mapper
{
    public class MapperFactory : IMapperFactory
    {
        public IMapper IMapper
        {

            get
            {
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<MappingProfile>();
                });

                return config.CreateMapper();
            }

        }

        public T GetDto<T>(object source) where T : class
        {
            return IMapper.Map<T>(source);
        }
    }
}
