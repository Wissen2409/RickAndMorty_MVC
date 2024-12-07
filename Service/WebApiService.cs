using Newtonsoft.Json;
public class WebApiService : IWebApiService
{

    public IWebApiRepository _webApiRepository;
    public WebApiService(IWebApiRepository repository)
    {

        _webApiRepository = repository;

    }
    public RickAndMortyDMO GetAll()
    {
        string jsonString = _webApiRepository.GetAll();

        RickAndMortyDMO resultData = JsonConvert.DeserializeObject<RickAndMortyDMO>(jsonString);
        return resultData;

    }

}
public interface IWebApiService
{

    public RickAndMortyDMO GetAll();
}