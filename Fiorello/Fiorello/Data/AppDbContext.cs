using Fiorello.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiorello.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opttion) : base(opttion)
        {

        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SlidersInfo { get; set;}
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogDetail> BlogsDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<Start> Starts { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }

    }
}
