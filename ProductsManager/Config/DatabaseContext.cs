using Microsoft.EntityFrameworkCore;
using ProductsManager.Entities;

namespace ProductsManager.Config
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) { }       
        
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ProductsProperties(modelBuilder);
            PricesProperties(modelBuilder);
            InventoryProperties(modelBuilder);
        }
        private void InventoryProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Inventory>()
                .Property(x => x.SKU)
                .IsRequired();

            modelBuilder.Entity<Inventory>()
                .HasKey(x => x.ProductId);
        }
        private void PricesProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Prices>()
                .Property(x => x.SKU)
                .IsRequired();
        }
        private void ProductsProperties(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(x => x.SKU)
                .IsRequired();

            modelBuilder.Entity<Products>()
                .Property(x => x.Name)
                .IsRequired();
        }
    }
}
