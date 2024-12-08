
/*{
  "info": {
    "count": 826,
    "pages": 42,
    "next": "https://rickandmortyapi.com/api/character/?page=2",
    "prev": null
  },
  "results": [
    {
      "id": 1,
      "name": "Rick Sanchez",
      "status": "Alive",
      "species": "Human",
      "type": "",
      "gender": "Male",
      },
      "location": {
        "name": "Earth",
        "url": "https://rickandmortyapi.com/api/location/20"
      },
      "image": "https://rickandmortyapi.com/api/character/avatar/1.jpeg",
     
    },
    // ...
  ]
}*/


namespace DTO
{
    public class RickAndMortyDTO
    {

        public InfoDTO Info { get; set; }
        public List<DetailDTO> Results { get; set; }
    }
    public class InfoDTO
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public string Next { get; set; }
        public int? Prev { get; set; }

    }
    public class DetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public LocationDTO Location { get; set; }
    }
    public class LocationDTO
    {

        public string Name { get; set; }
    }
}
