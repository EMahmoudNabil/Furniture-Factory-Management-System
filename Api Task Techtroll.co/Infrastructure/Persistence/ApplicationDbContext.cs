using Microsoft.EntityFrameworkCore;
using Api_Task_Techtroll.co.Domain.Entities; 

namespace Api_Task_Techtroll.co.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

      
        public DbSet<Product> Products { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<Subcomponent> Subcomponents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Product → Component
            modelBuilder.Entity<Product>()
                .HasMany(p => p.Components)
                .WithOne(c => c.Product)
                .HasForeignKey(c => c.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            // Component → Subcomponent
            modelBuilder.Entity<Component>()
                .HasMany(c => c.Subcomponents)
                .WithOne(sc => sc.Component)
                .HasForeignKey(sc => sc.ComponentId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure MaxLength if you want EF to generate schema properly
            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Component>()
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Subcomponent>()
                .Property(s => s.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Subcomponent>()
                .Property(s => s.Material)
                .HasMaxLength(100)
                .IsRequired();


            // Configure Price precision for Product
            modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(18, 4); 


        }
    }
}
