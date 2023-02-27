using Microsoft.EntityFrameworkCore;

namespace OnlineTicketBooking.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}
