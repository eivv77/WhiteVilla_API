using Microsoft.EntityFrameworkCore;
using WhiteVilla_VillaAPI.Models;

namespace WhiteVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) //конструктор 
            : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "First",
                    Details = "The First villa in our project",
                    ImgUrl = "",
                    Occupancy = 1,
                    Rate = 10,
                    Sqft = 100,
                    Amenity = "The best",
                    CreatedDate = DateTime.Now
                },
                new Villa
                {
                    Id = 2,
                    Name = "Second",
                    Details = "The Second villa in our project",
                    ImgUrl = "",
                    Occupancy = 2,
                    Rate = 10,
                    Sqft = 200,
                    Amenity = "The best",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 3,
                    Name = "Third",
                    Details = "The Third villa in our project",
                    ImgUrl = "",
                    Occupancy = 3,
                    Rate = 10,
                    Sqft = 300,
                    Amenity = "The best",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 4,
                    Name = "Fourth",
                    Details = "The Fourth villa in our project",
                    ImgUrl = "",
                    Occupancy = 4,
                    Rate = 10,
                    Sqft = 400,
                    Amenity = "The best",
                    CreatedDate = DateTime.Now

                },
                new Villa
                {
                    Id = 5,
                    Name = "Fifth",
                    Details = "The Fifth villa in our project",
                    ImgUrl = "",
                    Occupancy = 5,
                    Rate = 10,
                    Sqft = 500,
                    Amenity = "The best",
                    CreatedDate = DateTime.Now

                }
                );
        }
    }
}
