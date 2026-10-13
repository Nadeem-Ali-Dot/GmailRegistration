using GmailRegistration.Models;
using Microsoft.EntityFrameworkCore;

namespace GmailRegistration.Data
{
    public class GmailDBContext:DbContext
    {
        public GmailDBContext(DbContextOptions<GmailDBContext> opt):base(opt)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("GmailRegistration");
            modelBuilder.Entity<User>()
                .Property(u => u.Gender)
                .HasConversion<string>()
                .IsRequired();
            modelBuilder.Entity<User>()
.Property(u => u.DateOfBirth)
.HasColumnType("date");
        

        }

        public DbSet<User> Users { get; set; }
        public DbSet<RegistrationSession> RegistrationSessions { get; set; }
    }
}
