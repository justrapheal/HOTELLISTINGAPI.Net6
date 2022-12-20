using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace HOTELLISTING.Data
{
    public class HotelListingDBContext :DbContext
    {
        public HotelListingDBContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortNaame = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortNaame = "BS"


                },
                  new Country
                  {
                      Id = 3,
                      Name = "Cayman Island",
                      ShortNaame = "CI"


                  }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = "4.5"
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Comfort Suites",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = "4.3"
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palladin and Spa",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = "4"
                }

);

        }

    }
}
