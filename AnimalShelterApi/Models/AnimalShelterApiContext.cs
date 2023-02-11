using Microsoft.EntityFrameworkCore;

namespace AnimalShelterApi.Models
{
  public class AnimalShelterApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalShelterApiContext(DbContextOptions<AnimalShelterApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, Name = "Izze", Species = "Cat", Description = "Black and white cat", Age = 5, DateAdded = DateTime.Now},
          new Animal { AnimalId = 2, Name = "Kobe", Species = "Dog", Description = "Small dog with black, brown, and orange fur.", Age = 12, DateAdded = DateTime.Now}, 
          new Animal { AnimalId = 3, Name = "Shadow", Species = "Dog", Description = "Medium dog with black, brown,orange, and white fur.", Age = 10, DateAdded = DateTime.Now},
          new Animal { AnimalId = 4, Name = "AJ", Species = "Dog", Description = "Small black and white dog.", Age = 14, DateAdded = DateTime.Now},
          new Animal { AnimalId = 5, Name = "Bella", Species = "Cat", Description = "Grey tabbey.", Age = 10, DateAdded = DateTime.Now},
          new Animal { AnimalId = 6, Name = "Ziggy", Species = "Cat", Description = "Ginger and white cat.", Age = 8, DateAdded = DateTime.Now},
          new Animal { AnimalId = 7, Name = "Marley", Species = "Cat", Description = "Grey with black stripes.", Age = 6, DateAdded = DateTime.Now}
        );
    }
  }
}