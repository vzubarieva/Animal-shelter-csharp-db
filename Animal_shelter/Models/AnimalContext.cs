using Microsoft.EntityFrameworkCore;

namespace Animal_shelter.Models
{
    public class Animal_shelterContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }

        public Animal_shelterContext(DbContextOptions options) : base(options) { }
    }
}
