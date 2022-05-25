using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterApp.DataAccess.Migrations
{
    public partial class FirstSeedingOfHamstersToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3845d87b-b230-41ff-a1a7-84bbd7ec821d",
                column: "ConcurrencyStamp",
                value: "9dd64476-1bfc-49ca-85c0-5cec51d429d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985f4930-21ad-4249-abaf-e4251b1553d9",
                column: "ConcurrencyStamp",
                value: "2174ada1-575b-4a25-9e65-39199ac7ff91");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "087f2124-f507-4642-a8f7-84442abb3d70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "938fbba7-1382-4e86-a466-7b35f8a854f3", "AQAAAAEAACcQAAAAEE7cBHZxWSf7vXL3X0Ii8fRE0r2+EbX2/UbTkSEqHS38Jvrffiikg1H+DaoHXxcfOg==", "6ec78a6d-535c-402b-a0bf-6c649d2c46fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe5a2197-03b0-4c40-91f7-5025506231ce", "AQAAAAEAACcQAAAAEL78kr0r7ScxChi0JIjHEL7IbgCC9f0FqhVHGcUYJZPfXEoOLlKUg+42howftcR6tQ==", "109572bd-fa75-4e83-9244-ee8256647b8d" });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 1, 2, "Eating1", 0, "", 0, "Losing1", "Hamster1", 0 },
                    { 2, 3, "Eating2", 0, "", 0, "Losing2", "Hamster2", 0 },
                    { 3, 2, "Eating3", 0, "", 0, "Losing3", "Hamster3", 0 },
                    { 4, 1, "Eating4", 0, "", 0, "Losing4", "Hamster4", 0 },
                    { 5, 2, "Eating5", 0, "", 0, "Losing5", "Hamster5", 0 },
                    { 6, 2, "Eating6", 0, "", 0, "Losing6", "Hamster6", 0 },
                    { 7, 3, "Eating7", 0, "", 0, "Losing7", "Hamster7", 0 },
                    { 8, 2, "Eating8", 0, "", 0, "Losing8", "Hamster8", 0 },
                    { 9, 1, "Eating9", 0, "", 0, "Losing9", "Hamster9", 0 },
                    { 10, 2, "Eating10", 0, "", 0, "Losing10", "Hamster10", 0 },
                    { 11, 3, "Eating11", 0, "", 0, "Losing11", "Hamster11", 0 },
                    { 12, 2, "Eating12", 0, "", 0, "Losing12", "Hamster12", 0 },
                    { 13, 3, "Eating13", 0, "", 0, "Losing13", "Hamster13", 0 },
                    { 14, 1, "Eating14", 0, "", 0, "Losing14", "Hamster14", 0 },
                    { 15, 1, "Eating15", 0, "", 0, "Losing15", "Hamster15", 0 },
                    { 16, 3, "Eating16", 0, "", 0, "Losing16", "Hamster16", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3845d87b-b230-41ff-a1a7-84bbd7ec821d",
                column: "ConcurrencyStamp",
                value: "51cabc8d-4943-48de-9870-373335453181");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985f4930-21ad-4249-abaf-e4251b1553d9",
                column: "ConcurrencyStamp",
                value: "2807dd19-617f-49f4-97a7-f9d63bf6e476");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "087f2124-f507-4642-a8f7-84442abb3d70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1a45b0d-5026-4d69-84e8-5a59af5977d0", "AQAAAAEAACcQAAAAEBqe0da5byladRyMOF7rhsrXDmBKNiwhPnpxqpJSqBueyHPUQ5B0nUFdrY2j8XAuBw==", "168fd148-c52b-4ee6-ac1c-e6fff907d918" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b7904fd-8ae3-4d69-a614-98c74b36fe71", "AQAAAAEAACcQAAAAEFfrj0dI8O37MZAmqJRQ5+jCQl+G9Ru8AapVxi2iKQKzjZAWnLFSpkVTyAbvcEURZw==", "e63566b1-b956-49cb-9a2d-f0a5e2fe6551" });
        }
    }
}
