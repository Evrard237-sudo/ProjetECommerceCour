using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Actor_Movie
    {
        [Key]
        public int Id { get; set; }
        public int MovieId { get; set; } // Migration de la classe Actors
        public Movie? Movie { get; set; }
        public int ActorId { get; set; } // Migration de la classe Movies
        public Actor? Actor { get; set; }
    }
}
