namespace Pub.Data
{
    using System;
    using Microsoft.EntityFrameworkCore;

    using Pub.Models;  

    public class PubContext : DbContext
    {
        public PubContext() { }

        public PubContext(DbContextOptions options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasOne(x => x.Manager)
                      .WithMany(x => x.ManagerEmployees)
                      .HasForeignKey(x => x.ManagerId);
            });
        }

    }
}
