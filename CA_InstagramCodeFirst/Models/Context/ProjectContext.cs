using CA_InstagramCodeFirst.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CA_InstagramCodeFirst.Models.Context
{
    public class ProjectContext:DbContext
    {
        //Users
        public DbSet<User> Users { get; set; }
        //UserProfiles
        public DbSet<UserProfile> UserProfiles { get; set; }
        //Messages

        //Photos
        public DbSet<Photo> Photos { get; set; }
        //PhotoComments
        public DbSet<PhotoComment> PhotoComments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "server=localhost;database=InstagramCodeFirstDB;Trusted_Connection=True;TrustServerCertificate=true;";

            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User Custom Properties
            modelBuilder.Entity<User>().Property("Username").HasColumnName("UserName");
            modelBuilder.Entity<User>().Property(x => x.Username).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(x => x.Password).HasMaxLength(50);

            //Photo Custom Properties
            modelBuilder.Entity<Photo>().Property(x => x.PhotoPath).HasMaxLength(255);
            modelBuilder.Entity<Photo>().Property(x => x.Title).HasMaxLength(500);

            //UserProfiles Custom Properties
            modelBuilder.Entity<UserProfile>().Property(x => x.Firstname).HasMaxLength(50);
            modelBuilder.Entity<UserProfile>().Property(x => x.Lastname).HasMaxLength(50);
            modelBuilder.Entity<UserProfile>().Property(x => x.PhoneNumber).HasMaxLength(11); //char(11)
            modelBuilder.Entity<UserProfile>().Property(x => x.Email).HasMaxLength(50);

            //PhotoComment Custom Properties
            modelBuilder.Entity<PhotoComment>().Property(x => x.Comment).HasMaxLength(500);
            base.OnModelCreating(modelBuilder);
        }
    }
}
