using HamsterApp.Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HamsterApp.API.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<ApiUser>
    {
        public ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Hamster> Hamsters { get; set; } = null!;
        public virtual DbSet<Match> Matches { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HamsterWarDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = "3845d87b-b230-41ff-a1a7-84bbd7ec821d"
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = "985f4930-21ad-4249-abaf-e4251b1553d9"
                }
             );

            var hasher = new PasswordHasher<ApiUser>();
            modelBuilder.Entity<ApiUser>().HasData(
                new ApiUser
                {
                    Id = "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                    Email = "admin@hamsters.com",
                    NormalizedEmail = "ADMIN@HAMSTERS.COM",
                    UserName = "admin@hamsters.com",
                    NormalizedUserName = "ADMIN@HAMSTERS.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "Admin123!")
                },
                new ApiUser
                {
                    Id = "087f2124-f507-4642-a8f7-84442abb3d70",
                    Email = "user@hamsters.com",
                    NormalizedEmail = "USER@HAMSTERS.COM",
                    UserName = "user@hamsters.com",
                    NormalizedUserName = "USER@HAMSTERS.COM",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "User123!")
                }
             );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3845d87b-b230-41ff-a1a7-84bbd7ec821d", //User
                    UserId = "087f2124-f507-4642-a8f7-84442abb3d70"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "985f4930-21ad-4249-abaf-e4251b1553d9", //Admin
                    UserId = "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d"
                }
             );
        }
    }
}
