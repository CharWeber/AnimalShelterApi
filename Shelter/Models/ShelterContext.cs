using Microsoft.EntityFrameworkCore;

namespace Shelter.Models
{
    public class ShelterContext : DbContext
    {
        public DbSet<Animal> Animals { get; set; }
        public ShelterContext(DbContextOptions<ShelterContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Animal>()
            .HasData(
                new Animal { AnimalId = 1, Name = "Mr. Meowmers", Species = "cat", Age = 2, Gender = "Male" },
                new Animal { AnimalId = 2, Name = "Friendo", Species = "dog", Age = 1, Gender = "Female" },
                new Animal { AnimalId = 2, Name = "Buster", Species = "dog", Age = 2, Gender = "Male" },
                new Animal { AnimalId = 2, Name = "ShelterCat.exe", Species = "cat", Age = 3, Gender = "Female" },
            );
        }

    }
}