using Microsoft.EntityFrameworkCore;
using PollE.Controllers.DTOs;

namespace PollE.DataAccess.Entities
{
    public class PollEDbContext : DbContext
    {
        public DbSet<PollEntity> Polls { get; set; }
        public DbSet<PollOptionEntity> Options { get; set; }
        public DbSet<VoteEntity> Votes { get; set; }
        public DbSet<PollOptionImageEntity> OptionImages { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=polle;Username=postgres;Password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PollEntity>();
            modelBuilder.Entity<PollOptionEntity>()
                .HasOne(x => x.Poll)
                .WithMany(x => x.Options)
                .HasForeignKey("poll_id")
                .IsRequired();

            modelBuilder.Entity<PollOptionImageEntity>()
                .HasOne(x => x.Option)
                .WithOne(x => x.Image)
                .HasForeignKey<PollOptionEntity>("image_id")
                .IsRequired();

            modelBuilder.Entity<VoteEntity>()
                .HasOne(x => x.Option)
                .WithMany(x => x.Votes)
                .HasForeignKey("option_id")
                .IsRequired();
            
            base.OnModelCreating(modelBuilder);
        }
    }
}