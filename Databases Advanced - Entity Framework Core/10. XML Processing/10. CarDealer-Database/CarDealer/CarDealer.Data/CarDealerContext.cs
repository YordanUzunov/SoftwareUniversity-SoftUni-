namespace CarDealer.Data
{  
    using Microsoft.EntityFrameworkCore;

    using CarDealer.Models;

    public class CarDealerContext : DbContext
    {
        public CarDealerContext() { }

        public CarDealerContext(DbContextOptions options) : base(options) { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<PartCar> PartCars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseLazyLoadingProxies(true);
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PartCar>()
                .HasKey(e => new { e.Part_Id, e.Car_Id });

            modelBuilder.Entity<PartCar>()
                .HasOne(pc => pc.Part)
                .WithMany(p => p.PartCars)
                .HasForeignKey(pc => pc.Part_Id);

            modelBuilder.Entity<PartCar>()
                .HasOne(pc => pc.Car)
                .WithMany(p => p.PartCars)
                .HasForeignKey(c => c.Car_Id);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Car)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.Car_Id);

            modelBuilder.Entity<Sale>()
                .HasOne(s => s.Customer)
                .WithMany(c => c.Sales)
                .HasForeignKey(s => s.Customer_Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
