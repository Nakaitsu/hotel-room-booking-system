using Microsoft.EntityFrameworkCore;

namespace Prototype.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {
        }

        public DbSet<Room> Rooms { get; set; }
    }
}