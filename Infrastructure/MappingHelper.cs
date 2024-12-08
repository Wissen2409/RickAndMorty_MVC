using System.Diagnostics;
using AutoMapper;


public class Helpers
{

    public DTO.RickAndMorty Map(DMO.RickAndMorty source)
    {
        var config = new MapperConfiguration(s =>
        {
            s.CreateMap<DMO.Info, DTO.Info>();
            s.CreateMap<DMO.Detail, DTO.Detail>();
            s.CreateMap<DMO.Location, DTO.Location>();
            s.CreateMap<DMO.RickAndMorty, DTO.RickAndMorty>();
        });
        Mapper mapper = new Mapper(config);
        return mapper.Map<DMO.RickAndMorty,DTO.RickAndMorty>(source);
    }

}
