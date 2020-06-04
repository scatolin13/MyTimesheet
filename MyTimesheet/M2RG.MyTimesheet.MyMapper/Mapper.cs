using AutoMapper;

namespace M2RG.MyTimesheet.MyMapper
{
    public static class Mapper<TOne, TTwo>
    {
        public static TTwo Map(TOne source)
        {
            IMapper iMapper = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TOne, TTwo>();
            }).CreateMapper();


            var target = iMapper.Map<TOne, TTwo>(source);

            return target;
        }
    }
}
