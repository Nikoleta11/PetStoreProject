using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetHouse.Data;

namespace PetHouse.Data
{
    public class ApplicationDbContext : IdentityDbContext<Client>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get;set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PetHouse.Data.Aplied> Aplied { get; set; } = default!;
    }
}
