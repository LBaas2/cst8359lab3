using Lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Data
{
    public class RsvpDBContext : DbContext
    {
        public RsvpDBContext(DbContextOptions<RsvpDBContext> options) : base(options)
        {
        }

        public DbSet<Rsvp> Rsvps { get; set; }
    }
}
