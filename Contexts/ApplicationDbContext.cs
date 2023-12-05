using Microsoft.EntityFrameworkCore;
using PracticeLinq.Contexts.Seeds;
using PracticeLinq.Models;

namespace PracticeLinq.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public IConfiguration Configuration;

        protected ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ApplicationDbContext(DbContextOptions options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        public DbSet<Customer> Cusotmers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration["ConnectionStrings:SqlServer"]);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>().HasKey(e => new { e.OrderID, e.ProductID });
            modelBuilder.AddCustomerSeed();
            modelBuilder.AddProductSeed();
            modelBuilder.AddOrderSeed();
            modelBuilder.AddOrderDetailSeed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
