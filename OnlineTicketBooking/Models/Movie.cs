using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineTicketBooking.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }
        
        // Movie has many relationship with Actor_Movies
        public List<Actor_Movie> Actor_Movies { get; set; }
        
        // Movie has relation with Cinema
        public int CinemaId { get; set; }        
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        // Movie has relation with Cinema
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
