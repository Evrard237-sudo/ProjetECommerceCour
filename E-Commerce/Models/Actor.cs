using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string? ProfilPictureUrl  { get; set; }
        public string? FullName { get; set; }
        public string? Bio { get; set; }
        public List<Actor_Movie> actor_Movies = new List<Actor_Movie>(); 

    }
}
