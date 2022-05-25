using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterApp.DataAccess.Migrations
{
    public partial class AddedMoreHamstersToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3845d87b-b230-41ff-a1a7-84bbd7ec821d",
                column: "ConcurrencyStamp",
                value: "15512b02-f3ae-4093-aeed-dd4a3751a9e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985f4930-21ad-4249-abaf-e4251b1553d9",
                column: "ConcurrencyStamp",
                value: "c20c852b-ea67-451e-ae55-5c34d1d07e39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "087f2124-f507-4642-a8f7-84442abb3d70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be2c7085-8510-412f-adda-679dcab6649b", "AQAAAAEAACcQAAAAELRvWkHhMeG4SPaMe8Is176oMzm3VBBdMfZDOYdb5cAUML12EAiN1+Vvh8RRqNgzbw==", "50878181-6692-4c12-aac1-daec3c0e914a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9dae9f6-ba4c-4d09-92ce-9405dfb98d62", "AQAAAAEAACcQAAAAEIC0ShsYCBMsaPHXDog5up6B7rESqJKbsZVdWiVPga/iUge0WnlUHPwOUuFIYSyXOA==", "8c5e5a22-1976-4e33-9811-7abd74c64517" });

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgName",
                value: "hamster-1.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgName",
                value: "hamster-2.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgName",
                value: "hamster-3.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgName",
                value: "hamster-4.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgName",
                value: "hamster-5.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgName",
                value: "hamster-6.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImgName",
                value: "hamster-7.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImgName",
                value: "hamster-8.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImgName",
                value: "hamster-9.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImgName",
                value: "hamster-10.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImgName",
                value: "hamster-11.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImgName",
                value: "hamster-12.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImgName",
                value: "hamster-13.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImgName",
                value: "hamster-14.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImgName",
                value: "hamster-15.jpg");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "ImgName" },
                values: new object[] { 1, "hamster-16.jpg" });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[,]
                {
                    { 17, 1, "Eating17", 0, "hamster-17.jpg", 0, "Losing17", "Hamster17", 0 },
                    { 18, 1, "Eating18", 0, "hamster-18.jpg", 0, "Losing18", "Hamster18", 0 },
                    { 19, 1, "Eating19", 0, "hamster-19.jpg", 0, "Losing19", "Hamster19", 0 },
                    { 20, 1, "Eating20", 0, "hamster-20.jpg", 0, "Losing20", "Hamster20", 0 },
                    { 21, 1, "Eating21", 0, "hamster-21.jpg", 0, "Losing21", "Hamster21", 0 },
                    { 22, 1, "Eating22", 0, "hamster-22.jpg", 0, "Losing22", "Hamster22", 0 },
                    { 23, 1, "Eating23", 0, "hamster-23.jpg", 0, "Losing23", "Hamster23", 0 },
                    { 24, 3, "Eating24", 0, "hamster-24.jpg", 0, "Losing24", "Hamster24", 0 },
                    { 25, 1, "Eating25", 0, "hamster-25.jpg", 0, "Losing25", "Hamster25", 0 },
                    { 26, 1, "Eating26", 0, "hamster-26.jpg", 0, "Losing26", "Hamster26", 0 },
                    { 27, 1, "Eating27", 0, "hamster-27.jpg", 0, "Losing27", "Hamster27", 0 },
                    { 28, 1, "Eating28", 0, "hamster-28.jpg", 0, "Losing28", "Hamster28", 0 },
                    { 29, 1, "Eating29", 0, "hamster-29.jpg", 0, "Losing29", "Hamster29", 0 },
                    { 30, 1, "Eating30", 0, "hamster-30.jpg", 0, "Losing30", "Hamster30", 0 },
                    { 31, 1, "Eating31", 0, "hamster-31.jpg", 0, "Losing31", "Hamster31", 0 },
                    { 32, 1, "Eating32", 0, "hamster-32.jpg", 0, "Losing32", "Hamster32", 0 },
                    { 33, 1, "Eating33", 0, "hamster-33.jpg", 0, "Losing33", "Hamster33", 0 },
                    { 34, 1, "Eating34", 0, "hamster-34.jpg", 0, "Losing34", "Hamster34", 0 },
                    { 35, 3, "Eating35", 0, "hamster-35.jpg", 0, "Losing35", "Hamster35", 0 },
                    { 36, 2, "Eating36", 0, "hamster-36.jpg", 0, "Losing36", "Hamster36", 0 },
                    { 37, 3, "Eating37", 0, "hamster-37.jpg", 0, "Losing37", "Hamster37", 0 },
                    { 38, 1, "Eating38", 0, "hamster-38.jpg", 0, "Losing38", "Hamster38", 0 }
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 39, 1, "Eating39", 0, "hamster-39.jpg", 0, "Losing39", "Hamster39", 0 });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "FavFood", "Games", "ImgName", "Losses", "Loves", "Name", "Wins" },
                values: new object[] { 40, 3, "Eating40", 0, "hamster-40.jpg", 0, "Losing40", "Hamster40", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 40);

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

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 11,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 12,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 13,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 14,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 15,
                column: "ImgName",
                value: "");

            migrationBuilder.UpdateData(
                table: "Hamsters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Age", "ImgName" },
                values: new object[] { 3, "" });
        }
    }
}
