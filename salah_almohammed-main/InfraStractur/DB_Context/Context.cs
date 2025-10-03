using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Model;

namespace InfraStractur.DB_Context
{
    public class Context : IdentityDbContext<User>
    {
        public DbSet<Catigory> catigories { get; set; }
        public DbSet<UserCatigory> userCatigories { get; set; }
        public DbSet<Seats> seats { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=sszzxxqq");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>()
                .HasMany(c => c.userCatigories)
                .WithMany(u => u.userCatigories)
                .UsingEntity<UserCatigory>();


            builder.Entity<Seats>()
                .HasOne(s => s.Catigory)
                .WithMany(u => u.seats)
                .HasForeignKey(s => s.CatigoryId);

            builder.Entity<Seats>()
                .HasOne(s => s.User)
                .WithMany(u => u.seats)
                .HasForeignKey(s => s.UserId);

        }
    }
}
