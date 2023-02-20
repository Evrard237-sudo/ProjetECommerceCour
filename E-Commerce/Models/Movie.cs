using E_Commerce.DATA.ENUMS;
namespace E_Commerce.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
        public string? ImageURL { get; set; }
        public  MovieCategory movieCategory { get; set; }

        public List<Actor_Movie> actor_Movies = new List<Actor_Movie>();
    }
}
