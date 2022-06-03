using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterApp.DataAccess.Migrations
{
    public partial class FirstMigrationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: true),
                    FavFood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Loves = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wins = table.Column<int>(type: "int", nullable: true),
                    Losses = table.Column<int>(type: "int", nullable: true),
                    Games = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WinId = table.Column<int>(type: "int", nullable: false),
                    LoseId = table.Column<int>(type: "int", nullable: false),
                    HamsterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Hamsters_HamsterId",
                        column: x => x.HamsterId,
                        principalTable: "Hamsters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3845d87b-b230-41ff-a1a7-84bbd7ec821d", "d9c60804-68c0-4ea8-b889-370374cfb43e", "User", "USER" },
                    { "985f4930-21ad-4249-abaf-e4251b1553d9", "99d7ed20-060f-4ca4-9406-17c5cde7e80f", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "087f2124-f507-4642-a8f7-84442abb3d70", 0, "2f306d70-d01c-4354-8316-9bad15223537", "user@hamsters.com", false, "System", "User", false, null, "USER@HAMSTERS.COM", "USER@HAMSTERS.COM", "AQAAAAEAACcQAAAAEFgC2477yCNO/FaVpjivgagYx15dF/fwXU5gL8vCj6mkMqj8E8aQzvAJP9nj1gnKLA==", null, false, "ecbfb0fc-cdfc-44bc-b3b9-fefa166db28c", false, "user@hamsters.com" },
                    { "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d", 0, "007a69dc-0618-467f-beb8-9a2ffd122dc1", "admin@hamsters.com", false, "System", "Admin", false, null, "ADMIN@HAMSTERS.COM", "ADMIN@HAMSTERS.COM", "AQAAAAEAACcQAAAAEEZerZiiNkXPwGox76UoWExZaV3sjq+cfkBIB2rMGMuuOukQewS1mMlyYzRxxJi5+A==", null, false, "98059ea3-da47-4047-9948-05d72d8de626", false, "admin@hamsters.com" }
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 2, "Camembert", 0, "/images/hamster-1.jpg", 0, "His Master", "Ebichu", 0 },
                    { 2, 3, "Pizza", 0, "/images/hamster-2.jpg", 0, "Climbing", "Oliver", 0 },
                    { 3, 2, "Mud", 0, "/images/hamster-3.jpg", 0, "Playing Football", "Iver", 0 },
                    { 4, 1, "Olives", 0, "/images/hamster-4.jpg", 0, "Sleeping", "Urban", 0 },
                    { 5, 2, "Tortila", 0, "/images/hamster-5.jpg", 0, "Fighting", "Lisa", 0 },
                    { 6, 2, "Salad", 0, "/images/hamster-6.jpg", 0, "Working out", "Thomas", 0 },
                    { 7, 3, "Flesh", 0, "/images/hamster-7.jpg", 0, "Chaos", "Renya", 0 },
                    { 8, 2, "Naan", 0, "/images/hamster-8.jpg", 0, "Trains", "Valvet", 0 },
                    { 9, 1, "Poptarts", 0, "/images/hamster-9.jpg", 0, "America", "Cece", 0 },
                    { 10, 2, "Potatoes", 0, "/images/hamster-10.jpg", 0, "Drama", "Poppy", 0 },
                    { 11, 3, "Plastic", 0, "/images/hamster-11.jpg", 0, "Losing", "Ehmberg", 0 },
                    { 12, 2, "Ramen", 0, "/images/hamster-12.jpg", 0, "Subways", "Svahlberg", 0 },
                    { 13, 3, "Tacos", 0, "/images/hamster-13.jpg", 0, "Gaining weight", "Ohm", 0 },
                    { 14, 1, "Meatballs", 0, "/images/hamster-14.jpg", 0, "Sitting", "Bert", 0 },
                    { 15, 1, "Salmon", 0, "/images/hamster-15.jpg", 0, "Hunting", "Fredrik", 0 },
                    { 16, 1, "Tomatoes", 0, "/images/hamster-16.jpg", 0, "Swimming", "Ida", 0 },
                    { 17, 1, "Chocolate", 0, "/images/hamster-17.jpg", 0, "Running", "Karl", 0 },
                    { 18, 1, "Sourcream", 0, "/images/hamster-18.jpg", 0, "Walking", "Linn", 0 },
                    { 19, 1, "Carrots", 0, "/images/hamster-19.jpg", 0, "Winning", "Ewa", 0 },
                    { 20, 1, "Beans", 0, "/images/hamster-20.jpg", 0, "Farting", "Ingrid", 0 },
                    { 21, 1, "Burritos", 0, "/images/hamster-21.jpg", 0, "Dancing", "Daniel", 0 },
                    { 22, 1, "Garlic", 0, "/images/hamster-22.jpg", 0, "Breathing", "Nizz", 0 },
                    { 23, 1, "Oranges", 0, "/images/hamster-23.jpg", 0, "Friends", "Gustaf", 0 },
                    { 24, 3, "Lemon", 0, "/images/hamster-24.jpg", 0, "Family", "Tiffany", 0 },
                    { 25, 1, "Pancakes", 0, "/images/hamster-25.jpg", 0, "Baking", "Jake", 0 },
                    { 26, 1, "Sandwiches", 0, "/images/hamster-26.jpg", 0, "Adventure", "Finn", 0 },
                    { 27, 1, "Spaghetti", 0, "/images/hamster-27.jpg", 0, "Opera", "Jarvis", 0 },
                    { 28, 1, "Pears", 0, "/images/hamster-28.jpg", 0, "Music", "Peppy", 0 },
                    { 29, 1, "Curry", 0, "/images/hamster-29.jpg", 0, "The Sun", "Hampus", 0 },
                    { 30, 1, "Dumplings", 0, "/images/hamster-30.jpg", 0, "Work", "Fiona", 0 },
                    { 31, 1, "Gyoza", 0, "/images/hamster-31.jpg", 0, "Traveling", "Lisabell", 0 },
                    { 32, 1, "Fish", 0, "/images/hamster-32.jpg", 0, "Fishing", "Olivia", 0 },
                    { 33, 1, "Melons", 0, "/images/hamster-33.jpg", 0, "Gardening", "Cedric", 0 },
                    { 34, 1, "Chili con Carne", 0, "/images/hamster-34.jpg", 0, "Haircuts", "Hamil", 0 },
                    { 35, 3, "Pupusas", 0, "/images/hamster-35.jpg", 0, "Sunbathing", "Julia", 0 },
                    { 36, 2, "Cakes", 0, "/images/hamster-36.jpg", 0, "Exercise", "Ana-Maria", 0 },
                    { 37, 3, "Popcorn", 0, "/images/hamster-37.jpg", 0, "Hunting", "Sammy", 0 },
                    { 38, 1, "Fried-Chicken", 0, "/images/hamster-38.jpg", 0, "Brewing", "Alex", 0 }
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 39, 1, "Corn", 0, "/images/hamster-39.jpg", 0, "Reading", "Sandy", 0 });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 40, 3, "Hamsters", 0, "/images/hamster-40.jpg", 0, "Being Crazy", "Felicia", 0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3845d87b-b230-41ff-a1a7-84bbd7ec821d", "087f2124-f507-4642-a8f7-84442abb3d70" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "985f4930-21ad-4249-abaf-e4251b1553d9", "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HamsterId",
                table: "Matches",
                column: "HamsterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}
