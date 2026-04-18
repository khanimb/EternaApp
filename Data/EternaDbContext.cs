using EternaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Data
{
    public class EternaDbContext:DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Feathure> Feathures { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public EternaDbContext(DbContextOptions<EternaDbContext> options) : base(options)
        {
        }
    }
}
