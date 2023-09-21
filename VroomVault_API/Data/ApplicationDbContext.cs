using Microsoft.EntityFrameworkCore;
using VroomVault_API.Models.Car;

namespace VroomVault_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
   : base(options)
        {

        }
        public DbSet<CarBrand> CarBrands { get; set; }
    }

}
