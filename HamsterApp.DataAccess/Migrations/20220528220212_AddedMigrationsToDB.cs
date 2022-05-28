using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterApp.DataAccess.Migrations
{
    public partial class AddedMigrationsToDB : Migration
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
                    HamsterId = table.Column<int>(type: "int", nullable: false),
                    WinId = table.Column<int>(type: "int", nullable: false),
                    LoseId = table.Column<int>(type: "int", nullable: false)
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
                    { "3845d87b-b230-41ff-a1a7-84bbd7ec821d", "5fa80517-4c06-433f-9d9f-72a5d3e21977", "User", "USER" },
                    { "985f4930-21ad-4249-abaf-e4251b1553d9", "2ec9a09b-8429-4997-898d-2c929b965197", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "087f2124-f507-4642-a8f7-84442abb3d70", 0, "34e0d63b-058f-401d-9d54-2bbffce3e02a", "user@hamsters.com", false, "System", "User", false, null, "USER@HAMSTERS.COM", "USER@HAMSTERS.COM", "AQAAAAEAACcQAAAAEFj6zRblMy91GC/G4s9k6XazmfwhRMYXMdL/UkbFFPxYeTWPRR1hkgsFuo5iORmP1w==", null, false, "1696bbcd-3750-48db-9d0d-da7eb685b350", false, "user@hamsters.com" },
                    { "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d", 0, "4dec43e0-5cec-457c-9f8b-e61c000db162", "admin@hamsters.com", false, "System", "Admin", false, null, "ADMIN@HAMSTERS.COM", "ADMIN@HAMSTERS.COM", "AQAAAAEAACcQAAAAEPBf3rFezVIgC/4PJCIxF4Ert9Ou+c3Awvc0UH8vH3Me7+eotpZ/nZTOVuxaTtAtBA==", null, false, "2266e292-e0b7-45f1-9a37-3dfbdcb1aed8", false, "admin@hamsters.com" }
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 2, "Eating1", 0, "/images/hamster-1.jpg", 0, "Losing1", "Hamster1", 0 },
                    { 2, 3, "Eating2", 0, "/images/hamster-2.jpg", 0, "Losing2", "Hamster2", 0 },
                    { 3, 2, "Eating3", 0, "/images/hamster-3.jpg", 0, "Losing3", "Hamster3", 0 },
                    { 4, 1, "Eating4", 0, "/images/hamster-4.jpg", 0, "Losing4", "Hamster4", 0 },
                    { 5, 2, "Eating5", 0, "/images/hamster-5.jpg", 0, "Losing5", "Hamster5", 0 },
                    { 6, 2, "Eating6", 0, "/images/hamster-6.jpg", 0, "Losing6", "Hamster6", 0 },
                    { 7, 3, "Eating7", 0, "/images/hamster-7.jpg", 0, "Losing7", "Hamster7", 0 },
                    { 8, 2, "Eating8", 0, "/images/hamster-8.jpg", 0, "Losing8", "Hamster8", 0 },
                    { 9, 1, "Eating9", 0, "/images/hamster-9.jpg", 0, "Losing9", "Hamster9", 0 },
                    { 10, 2, "Eating10", 0, "/images/hamster-10.jpg", 0, "Losing10", "Hamster10", 0 },
                    { 11, 3, "Eating11", 0, "/images/hamster-11.jpg", 0, "Losing11", "Hamster11", 0 },
                    { 12, 2, "Eating12", 0, "/images/hamster-12.jpg", 0, "Losing12", "Hamster12", 0 },
                    { 13, 3, "Eating13", 0, "/images/hamster-13.jpg", 0, "Losing13", "Hamster13", 0 },
                    { 14, 1, "Eating14", 0, "/images/hamster-14.jpg", 0, "Losing14", "Hamster14", 0 },
                    { 15, 1, "Eating15", 0, "/images/hamster-15.jpg", 0, "Losing15", "Hamster15", 0 },
                    { 16, 1, "Eating16", 0, "/images/hamster-16.jpg", 0, "Losing16", "Hamster16", 0 },
                    { 17, 1, "Eating17", 0, "/images/hamster-17.jpg", 0, "Losing17", "Hamster17", 0 },
                    { 18, 1, "Eating18", 0, "/images/hamster-18.jpg", 0, "Losing18", "Hamster18", 0 },
                    { 19, 1, "Eating19", 0, "/images/hamster-19.jpg", 0, "Losing19", "Hamster19", 0 },
                    { 20, 1, "Eating20", 0, "/images/hamster-20.jpg", 0, "Losing20", "Hamster20", 0 },
                    { 21, 1, "Eating21", 0, "/images/hamster-21.jpg", 0, "Losing21", "Hamster21", 0 },
                    { 22, 1, "Eating22", 0, "/images/hamster-22.jpg", 0, "Losing22", "Hamster22", 0 },
                    { 23, 1, "Eating23", 0, "/images/hamster-23.jpg", 0, "Losing23", "Hamster23", 0 },
                    { 24, 3, "Eating24", 0, "/images/hamster-24.jpg", 0, "Losing24", "Hamster24", 0 },
                    { 25, 1, "Eating25", 0, "/images/hamster-25.jpg", 0, "Losing25", "Hamster25", 0 },
                    { 26, 1, "Eating26", 0, "/images/hamster-26.jpg", 0, "Losing26", "Hamster26", 0 },
                    { 27, 1, "Eating27", 0, "/images/hamster-27.jpg", 0, "Losing27", "Hamster27", 0 },
                    { 28, 1, "Eating28", 0, "/images/hamster-28.jpg", 0, "Losing28", "Hamster28", 0 },
                    { 29, 1, "Eating29", 0, "/images/hamster-29.jpg", 0, "Losing29", "Hamster29", 0 },
                    { 30, 1, "Eating30", 0, "/images/hamster-30.jpg", 0, "Losing30", "Hamster30", 0 },
                    { 31, 1, "Eating31", 0, "/images/hamster-31.jpg", 0, "Losing31", "Hamster31", 0 },
                    { 32, 1, "Eating32", 0, "/images/hamster-32.jpg", 0, "Losing32", "Hamster32", 0 },
                    { 33, 1, "Eating33", 0, "/images/hamster-33.jpg", 0, "Losing33", "Hamster33", 0 },
                    { 34, 1, "Eating34", 0, "/images/hamster-34.jpg", 0, "Losing34", "Hamster34", 0 },
                    { 35, 3, "Eating35", 0, "/images/hamster-35.jpg", 0, "Losing35", "Hamster35", 0 },
                    { 36, 2, "Eating36", 0, "/images/hamster-36.jpg", 0, "Losing36", "Hamster36", 0 },
                    { 37, 3, "Eating37", 0, "/images/hamster-37.jpg", 0, "Losing37", "Hamster37", 0 },
                    { 38, 1, "Eating38", 0, "/images/hamster-38.jpg", 0, "Losing38", "Hamster38", 0 }
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 39, 1, "Eating39", 0, "/images/hamster-39.jpg", 0, "Losing39", "Hamster39", 0 });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 40, 3, "Eating40", 0, "/images/hamster-40.jpg", 0, "Losing40", "Hamster40", 0 });

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
