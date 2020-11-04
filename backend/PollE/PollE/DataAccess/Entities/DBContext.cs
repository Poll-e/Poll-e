using Microsoft.EntityFrameworkCore;
using PollE.Controllers.DTOs;

namespace PollE.DataAccess.Entities
{
    public class DBContext : DbContext
    {
        public DbSet<CodeEntity> Codes { get; set; }
        public DbSet<PollEntity> Polls { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=polle;Username=postgres;Password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PollEntity>()
                .HasOne<CategoryEntity>(x => x.Category)
                .WithMany(x => x.Polls)
                .HasForeignKey("category");
            modelBuilder.Entity<CodeEntity>()
                .HasOne<PollEntity>(x => x.Poll)
                .WithOne(x => x.Code)
                .HasForeignKey<PollEntity>("code");
        }
    }
}