using System.ComponentModel.DataAnnotations;

namespace OnlineTicketBooking.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        // Movie has many relationship with Actor_Movies
        public List<Actor_Movie> Actor_Movies { get; set; } 
    }
}
