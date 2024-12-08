using Newtonsoft.Json;
using DTO;
using AutoMapper;
public class WebApiService : IWebApiService
{

    public IWebApiRepository _webApiRepository;
    public Helpers _helpers;
    public WebApiService(IWebApiRepository repository, Helpers helpers)
    {

        _webApiRepository = repository;
        _helpers = helpers;

    }
    public DTO.RickAndMorty GetAll()
    {

       DMO.RickAndMorty returnModel = _webApiRepository.GetAll();
       DTO.RickAndMorty model=new RickAndMorty();
        // DMO denen tip'in asla action'a gitmemesi lazım!! Bunun için DTO denen, data transfer object kullanılabilir

        // RickAndMortyDmo tipini,RickAndMortyDTO'ya çevirmek için, AutoMapper kullanılabilir!!
        // 1 : DMO^yu DTO'ya elle mapleyelim!!
        try
        {
             model = _helpers.Map(returnModel);   
        }
        catch (Exception ex)
        {

        }
        return model;



        #region DMO-DTO Mapping
        /*var newReturnModel = new RickAndMortyDTO()
        {
            Info = new InfoDTO()
            {
                Count = returnModel.Info.Count,
                Next = returnModel.Info.Next,
                Pages = returnModel.Info.Pages,
                Prev = returnModel.Info.Prev,
            },


        };
        newReturnModel.Results = returnModel.Results.Select(s => new DetailDTO()
        {
            Gender = s.Gender,
            Id = s.Id,
            Image = s.Image,
            Name = s.Name,
            Type = s.Type,
            Status = s.Status,
            Species = s.Species,
            Location = new LocationDTO()
            {
                Name = s.Location.Name
            }
        }).ToList();
        

        return newReturnModel;*/
        #endregion
    }

}
public interface IWebApiService
{
    public DTO.RickAndMorty GetAll();
}