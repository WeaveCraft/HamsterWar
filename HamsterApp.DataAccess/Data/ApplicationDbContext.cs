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
                    Name = "Ebichu",
                    Age = 2,
                    FavFood = "Camembert",
                    Loves = "His Master",
                    ImgName = "/images/hamster-1.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 2,
                    Name = "Oliver",
                    Age = 3,
                    FavFood = "Pizza",
                    Loves = "Climbing",
                    ImgName = "/images/hamster-2.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 3,
                    Name = "Iver",
                    Age = 2,
                    FavFood = "Mud",
                    Loves = "Playing Football",
                    ImgName = "/images/hamster-3.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 4,
                    Name = "Urban",
                    Age = 1,
                    FavFood = "Olives",
                    Loves = "Sleeping",
                    ImgName = "/images/hamster-4.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 5,
                    Name = "Lisa",
                    Age = 2,
                    FavFood = "Tortila",
                    Loves = "Fighting",
                    ImgName = "/images/hamster-5.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 6,
                    Name = "Thomas",
                    Age = 2,
                    FavFood = "Salad",
                    Loves = "Working out",
                    ImgName = "/images/hamster-6.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 7,
                    Name = "Renya",
                    Age = 3,
                    FavFood = "Flesh",
                    Loves = "Chaos",
                    ImgName = "/images/hamster-7.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 8,
                    Name = "Valvet",
                    Age = 2,
                    FavFood = "Naan",
                    Loves = "Trains",
                    ImgName = "/images/hamster-8.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 9,
                    Name = "Cece",
                    Age = 1,
                    FavFood = "Poptarts",
                    Loves = "America",
                    ImgName = "/images/hamster-9.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 10,
                    Name = "Poppy",
                    Age = 2,
                    FavFood = "Potatoes",
                    Loves = "Drama",
                    ImgName = "/images/hamster-10.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 11,
                    Name = "Ehmberg",
                    Age = 3,
                    FavFood = "Plastic",
                    Loves = "Losing",
                    ImgName = "/images/hamster-11.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 12,
                    Name = "Svahlberg",
                    Age = 2,
                    FavFood = "Ramen",
                    Loves = "Subways",
                    ImgName = "/images/hamster-12.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 13,
                    Name = "Ohm",
                    Age = 3,
                    FavFood = "Tacos",
                    Loves = "Gaining weight",
                    ImgName = "/images/hamster-13.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 14,
                    Name = "Bert",
                    Age = 1,
                    FavFood = "Meatballs",
                    Loves = "Sitting",
                    ImgName = "/images/hamster-14.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 15,
                    Name = "Fredrik",
                    Age = 1,
                    FavFood = "Salmon",
                    Loves = "Hunting",
                    ImgName = "/images/hamster-15.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 16,
                    Name = "Ida",
                    Age = 1,
                    FavFood = "Tomatoes",
                    Loves = "Swimming",
                    ImgName = "/images/hamster-16.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 17,
                    Name = "Karl",
                    Age = 1,
                    FavFood = "Chocolate",
                    Loves = "Running",
                    ImgName = "/images/hamster-17.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 18,
                    Name = "Linn",
                    Age = 1,
                    FavFood = "Sourcream",
                    Loves = "Walking",
                    ImgName = "/images/hamster-18.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 19,
                    Name = "Ewa",
                    Age = 1,
                    FavFood = "Carrots",
                    Loves = "Winning",
                    ImgName = "/images/hamster-19.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 20,
                    Name = "Ingrid",
                    Age = 1,
                    FavFood = "Beans",
                    Loves = "Farting",
                    ImgName = "/images/hamster-20.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 21,
                    Name = "Daniel",
                    Age = 1,
                    FavFood = "Burritos",
                    Loves = "Dancing",
                    ImgName = "/images/hamster-21.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 22,
                    Name = "Nizz",
                    Age = 1,
                    FavFood = "Garlic",
                    Loves = "Breathing",
                    ImgName = "/images/hamster-22.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 23,
                    Name = "Gustaf",
                    Age = 1,
                    FavFood = "Oranges",
                    Loves = "Friends",
                    ImgName = "/images/hamster-23.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 24,
                    Name = "Tiffany",
                    Age = 3,
                    FavFood = "Lemon",
                    Loves = "Family",
                    ImgName = "/images/hamster-24.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 25,
                    Name = "Jake",
                    Age = 1,
                    FavFood = "Pancakes",
                    Loves = "Baking",
                    ImgName = "/images/hamster-25.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 26,
                    Name = "Finn",
                    Age = 1,
                    FavFood = "Sandwiches",
                    Loves = "Adventure",
                    ImgName = "/images/hamster-26.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 27,
                    Name = "Jarvis",
                    Age = 1,
                    FavFood = "Spaghetti",
                    Loves = "Opera",
                    ImgName = "/images/hamster-27.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 28,
                    Name = "Peppy",
                    Age = 1,
                    FavFood = "Pears",
                    Loves = "Music",
                    ImgName = "/images/hamster-28.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 29,
                    Name = "Hampus",
                    Age = 1,
                    FavFood = "Curry",
                    Loves = "The Sun",
                    ImgName = "/images/hamster-29.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 30,
                    Name = "Fiona",
                    Age = 1,
                    FavFood = "Dumplings",
                    Loves = "Work",
                    ImgName = "/images/hamster-30.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 31,
                    Name = "Lisabell",
                    Age = 1,
                    FavFood = "Gyoza",
                    Loves = "Traveling",
                    ImgName = "/images/hamster-31.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 32,
                    Name = "Olivia",
                    Age = 1,
                    FavFood = "Fish",
                    Loves = "Fishing",
                    ImgName = "/images/hamster-32.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 33,
                    Name = "Cedric",
                    Age = 1,
                    FavFood = "Melons",
                    Loves = "Gardening",
                    ImgName = "/images/hamster-33.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 34,
                    Name = "Hamil",
                    Age = 1,
                    FavFood = "Chili con Carne",
                    Loves = "Haircuts",
                    ImgName = "/images/hamster-34.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 35,
                    Name = "Julia",
                    Age = 3,
                    FavFood = "Pupusas",
                    Loves = "Sunbathing",
                    ImgName = "/images/hamster-35.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 36,
                    Name = "Ana-Maria",
                    Age = 2,
                    FavFood = "Cakes",
                    Loves = "Exercise",
                    ImgName = "/images/hamster-36.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 37,
                    Name = "Sammy",
                    Age = 3,
                    FavFood = "Popcorn",
                    Loves = "Hunting",
                    ImgName = "/images/hamster-37.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 38,
                    Name = "Alex",
                    Age = 1,
                    FavFood = "Fried-Chicken",
                    Loves = "Brewing",
                    ImgName = "/images/hamster-38.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 39,
                    Name = "Sandy",
                    Age = 1,
                    FavFood = "Corn",
                    Loves = "Reading",
                    ImgName = "/images/hamster-39.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                },
                new Hamster
                {
                    Id = 40,
                    Name = "Felicia",
                    Age = 3,
                    FavFood = "Hamsters",
                    Loves = "Being Crazy",
                    ImgName = "/images/hamster-40.jpg",
                    Wins = 0,
                    Losses = 0,
                    Games = 0
                }
             );
        }
    }
}
