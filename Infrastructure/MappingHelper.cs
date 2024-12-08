using System.Diagnostics;
using AutoMapper;


public class Helpers
{

    public TDestination Map<TSource, TDestination>(TSource source, TDestination destination)
    {

        var config = new MapperConfiguration(s =>
                       s.CreateMap<TSource, TDestination>());

        Mapper mapper = new Mapper(config);
        return mapper.Map<TSource, TDestination>(source, destination);
    }

}
