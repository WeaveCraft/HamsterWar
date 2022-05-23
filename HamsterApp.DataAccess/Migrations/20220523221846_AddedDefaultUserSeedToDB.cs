using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterApp.DataAccess.Migrations
{
    public partial class AddedDefaultUserSeedToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3845d87b-b230-41ff-a1a7-84bbd7ec821d", "7362d0bd-4219-4783-825b-6b11f96fea40", "User", "USER" },
                    { "985f4930-21ad-4249-abaf-e4251b1553d9", "0ef0315b-7ad5-4964-abc3-b07019b575c1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "087f2124-f507-4642-a8f7-84442abb3d70", 0, "193d103f-3c8f-4a87-98f8-fff8b6b52da3", "user@hamsters.com", false, "System", "User", false, null, "USER@HAMSTERS.COM", "USER@HAMSTERS.COM", "AQAAAAEAACcQAAAAEJ/2U3Pisjsb68+C9dRoLNPWb/rl3EThLpM+BRf7y747fLv52WUB+d9p8E0D98KqMg==", null, false, "540a0e5f-640b-4286-b21b-caad27ee6571", false, "user@hamsters.com" },
                    { "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d", 0, "fa7fdda1-0566-4b85-9cb7-30d9f3fef6ec", "admin@hamsters.com", false, "System", "Admin", false, null, "ADMIN@HAMSTERS.COM", "ADMIN@HAMSTERS.COM", "AQAAAAEAACcQAAAAEAS0buIDmfcuWj54SUwWO21stF1Sh5IiC1+CvUxkbukYJsM+VZq32GOd7KsgYWmazg==", null, false, "9ee712a6-5458-4ef8-96ee-5cccee1983aa", false, "admin@hamsters.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3845d87b-b230-41ff-a1a7-84bbd7ec821d", "087f2124-f507-4642-a8f7-84442abb3d70" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "985f4930-21ad-4249-abaf-e4251b1553d9", "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3845d87b-b230-41ff-a1a7-84bbd7ec821d", "087f2124-f507-4642-a8f7-84442abb3d70" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "985f4930-21ad-4249-abaf-e4251b1553d9", "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3845d87b-b230-41ff-a1a7-84bbd7ec821d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985f4930-21ad-4249-abaf-e4251b1553d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "087f2124-f507-4642-a8f7-84442abb3d70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d");
        }
    }
}
