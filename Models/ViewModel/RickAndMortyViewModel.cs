
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


namespace ViewModel
{
    public class RickAndMortyViewModel
    {

        public InfoViewModel Info { get; set; }
        public List<DetailViewModel> Results { get; set; }
    }
    public class InfoViewModel
    {
        public int Count { get; set; }
        public int Pages { get; set; }
        public string Next { get; set; }
        public int? Prev { get; set; }

    }
    public class DetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string Type { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }
        public LocationViewModel Location { get; set; }
    }
    public class LocationViewModel
    {

        public string Name { get; set; }
    }
}
