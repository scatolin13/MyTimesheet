using AutoMapper;
using AutoMapper.Configuration;

namespace M2RG.MyTimesheet.MyMapper
{
    public class CustomMapper<TOne, TTwo> : IMapperInclude<TOne, TTwo>
    {
        readonly MapperConfigurationExpression conf;

        public CustomMapper()
        {
            conf = new MapperConfigurationExpression();
            conf.CreateMap<TOne, TTwo>();
        }

        public TTwo Map(TOne source)
        {
            IMapper iMapper = new MapperConfiguration(conf).CreateMapper();

            var target = iMapper.Map<TOne, TTwo>(source);

            return target;
        }

        public IMapperInclude<TOne, TTwo> Includes<TSource, TDestination>()
        {
            conf.CreateMap<TSource, TDestination>();
            return this;
        }
    }
}
