namespace M2RG.MyTimesheet.MyMapper
{
    public interface IMapperInclude<TOne, TTwo>
    {
        IMapperInclude<TOne, TTwo> Includes<TSource, TDestination>();
        TTwo Map(TOne source);
    }
}
