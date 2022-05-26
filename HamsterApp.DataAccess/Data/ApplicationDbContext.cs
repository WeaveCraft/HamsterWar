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

            modelBuilder.Entity<Hamster>().HasData(
                new Hamster
                {
                    Id = 1,
                    Name = "Hamster1",
                    Age = 2,
                    FavFood = "Eating1",
                    Loves = "Losing1",
                    ImgName = "/images/hamster-1.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 2,
                    Name = "Hamster2",
                    Age = 3,
                    FavFood = "Eating2",
                    Loves = "Losing2",
                    ImgName = "/images/hamster-2.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 3,
                    Name = "Hamster3",
                    Age = 2,
                    FavFood = "Eating3",
                    Loves = "Losing3",
                    ImgName = "/images/hamster-3.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 4,
                    Name = "Hamster4",
                    Age = 1,
                    FavFood = "Eating4",
                    Loves = "Losing4",
                    ImgName = "/images/hamster-4.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 5,
                    Name = "Hamster5",
                    Age = 2,
                    FavFood = "Eating5",
                    Loves = "Losing5",
                    ImgName = "/images/hamster-5.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 6,
                    Name = "Hamster6",
                    Age = 2,
                    FavFood = "Eating6",
                    Loves = "Losing6",
                    ImgName = "/images/hamster-6.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 7,
                    Name = "Hamster7",
                    Age = 3,
                    FavFood = "Eating7",
                    Loves = "Losing7",
                    ImgName = "/images/hamster-7.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 8,
                    Name = "Hamster8",
                    Age = 2,
                    FavFood = "Eating8",
                    Loves = "Losing8",
                    ImgName = "/images/hamster-8.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 9,
                    Name = "Hamster9",
                    Age = 1,
                    FavFood = "Eating9",
                    Loves = "Losing9",
                    ImgName = "/images/hamster-9.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 10,
                    Name = "Hamster10",
                    Age = 2,
                    FavFood = "Eating10",
                    Loves = "Losing10",
                    ImgName = "/images/hamster-10.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 11,
                    Name = "Hamster11",
                    Age = 3,
                    FavFood = "Eating11",
                    Loves = "Losing11",
                    ImgName = "/images/hamster-11.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 12,
                    Name = "Hamster12",
                    Age = 2,
                    FavFood = "Eating12",
                    Loves = "Losing12",
                    ImgName = "/images/hamster-12.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 13,
                    Name = "Hamster13",
                    Age = 3,
                    FavFood = "Eating13",
                    Loves = "Losing13",
                    ImgName = "/images/hamster-13.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 14,
                    Name = "Hamster14",
                    Age = 1,
                    FavFood = "Eating14",
                    Loves = "Losing14",
                    ImgName = "/images/hamster-14.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 15,
                    Name = "Hamster15",
                    Age = 1,
                    FavFood = "Eating15",
                    Loves = "Losing15",
                    ImgName = "/images/hamster-15.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 16,
                    Name = "Hamster16",
                    Age = 1,
                    FavFood = "Eating16",
                    Loves = "Losing16",
                    ImgName = "/images/hamster-16.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 17,
                    Name = "Hamster17",
                    Age = 1,
                    FavFood = "Eating17",
                    Loves = "Losing17",
                    ImgName = "/images/hamster-17.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 18,
                    Name = "Hamster18",
                    Age = 1,
                    FavFood = "Eating18",
                    Loves = "Losing18",
                    ImgName = "/images/hamster-18.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 19,
                    Name = "Hamster19",
                    Age = 1,
                    FavFood = "Eating19",
                    Loves = "Losing19",
                    ImgName = "/images/hamster-19.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 20,
                    Name = "Hamster20",
                    Age = 1,
                    FavFood = "Eating20",
                    Loves = "Losing20",
                    ImgName = "/images/hamster-20.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 21,
                    Name = "Hamster21",
                    Age = 1,
                    FavFood = "Eating21",
                    Loves = "Losing21",
                    ImgName = "/images/hamster-21.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 22,
                    Name = "Hamster22",
                    Age = 1,
                    FavFood = "Eating22",
                    Loves = "Losing22",
                    ImgName = "/images/hamster-22.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 23,
                    Name = "Hamster23",
                    Age = 1,
                    FavFood = "Eating23",
                    Loves = "Losing23",
                    ImgName = "/images/hamster-23.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 24,
                    Name = "Hamster24",
                    Age = 3,
                    FavFood = "Eating24",
                    Loves = "Losing24",
                    ImgName = "/images/hamster-24.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 25,
                    Name = "Hamster25",
                    Age = 1,
                    FavFood = "Eating25",
                    Loves = "Losing25",
                    ImgName = "/images/hamster-25.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 26,
                    Name = "Hamster26",
                    Age = 1,
                    FavFood = "Eating26",
                    Loves = "Losing26",
                    ImgName = "/images/hamster-26.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 27,
                    Name = "Hamster27",
                    Age = 1,
                    FavFood = "Eating27",
                    Loves = "Losing27",
                    ImgName = "/images/hamster-27.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 28,
                    Name = "Hamster28",
                    Age = 1,
                    FavFood = "Eating28",
                    Loves = "Losing28",
                    ImgName = "/images/hamster-28.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 29,
                    Name = "Hamster29",
                    Age = 1,
                    FavFood = "Eating29",
                    Loves = "Losing29",
                    ImgName = "/images/hamster-29.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 30,
                    Name = "Hamster30",
                    Age = 1,
                    FavFood = "Eating30",
                    Loves = "Losing30",
                    ImgName = "/images/hamster-30.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 31,
                    Name = "Hamster31",
                    Age = 1,
                    FavFood = "Eating31",
                    Loves = "Losing31",
                    ImgName = "/images/hamster-31.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 32,
                    Name = "Hamster32",
                    Age = 1,
                    FavFood = "Eating32",
                    Loves = "Losing32",
                    ImgName = "/images/hamster-32.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 33,
                    Name = "Hamster33",
                    Age = 1,
                    FavFood = "Eating33",
                    Loves = "Losing33",
                    ImgName = "/images/hamster-33.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 34,
                    Name = "Hamster34",
                    Age = 1,
                    FavFood = "Eating34",
                    Loves = "Losing34",
                    ImgName = "/images/hamster-34.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 35,
                    Name = "Hamster35",
                    Age = 3,
                    FavFood = "Eating35",
                    Loves = "Losing35",
                    ImgName = "/images/hamster-35.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 36,
                    Name = "Hamster36",
                    Age = 2,
                    FavFood = "Eating36",
                    Loves = "Losing36",
                    ImgName = "/images/hamster-36.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 37,
                    Name = "Hamster37",
                    Age = 3,
                    FavFood = "Eating37",
                    Loves = "Losing37",
                    ImgName = "/images/hamster-37.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 38,
                    Name = "Hamster38",
                    Age = 1,
                    FavFood = "Eating38",
                    Loves = "Losing38",
                    ImgName = "/images/hamster-38.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 39,
                    Name = "Hamster39",
                    Age = 1,
                    FavFood = "Eating39",
                    Loves = "Losing39",
                    ImgName = "/images/hamster-39.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 40,
                    Name = "Hamster40",
                    Age = 3,
                    FavFood = "Eating40",
                    Loves = "Losing40",
                    ImgName = "/images/hamster-40.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                }
             );
        }
    }
}
