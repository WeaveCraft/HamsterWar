using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterApp.DataAccess.Migrations
{
    public partial class ChangedUserDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3845d87b-b230-41ff-a1a7-84bbd7ec821d",
                column: "ConcurrencyStamp",
                value: "5f1772af-b24d-4f43-b5fb-befa3027b79e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985f4930-21ad-4249-abaf-e4251b1553d9",
                column: "ConcurrencyStamp",
                value: "59cd0547-c9d2-4781-825d-d329a80234d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "087f2124-f507-4642-a8f7-84442abb3d70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d8f7f02-889d-44da-b935-7062c595b9ff", "AQAAAAEAACcQAAAAEDEZtQEdvvAmokU21jtknZ6isrbA9Y+HEs5W/dqBwC7uQmo7o+TLSi7cbbf5wjtaQg==", "4d3d7787-9f7d-4095-9feb-14bff42aabd7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92bbd9d8-4c74-46f0-b111-e17c8c38bbeb", "AQAAAAEAACcQAAAAEPXasSvZPhpJFxdzEFD4nILblkSXr6Uwrl89R0RW/utVswKZQS0gPXAKg7LGqc+EnQ==", "67004154-8185-4532-9ac9-8d4540059055" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3845d87b-b230-41ff-a1a7-84bbd7ec821d",
                column: "ConcurrencyStamp",
                value: "7362d0bd-4219-4783-825b-6b11f96fea40");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985f4930-21ad-4249-abaf-e4251b1553d9",
                column: "ConcurrencyStamp",
                value: "0ef0315b-7ad5-4964-abc3-b07019b575c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "087f2124-f507-4642-a8f7-84442abb3d70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "193d103f-3c8f-4a87-98f8-fff8b6b52da3", "AQAAAAEAACcQAAAAEJ/2U3Pisjsb68+C9dRoLNPWb/rl3EThLpM+BRf7y747fLv52WUB+d9p8E0D98KqMg==", "540a0e5f-640b-4286-b21b-caad27ee6571" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa7fdda1-0566-4b85-9cb7-30d9f3fef6ec", "AQAAAAEAACcQAAAAEAS0buIDmfcuWj54SUwWO21stF1Sh5IiC1+CvUxkbukYJsM+VZq32GOd7KsgYWmazg==", "9ee712a6-5458-4ef8-96ee-5cccee1983aa" });
        }
    }
}
