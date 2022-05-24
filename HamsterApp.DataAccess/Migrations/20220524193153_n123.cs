using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamsterApp.DataAccess.Migrations
{
    public partial class n123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3845d87b-b230-41ff-a1a7-84bbd7ec821d",
                column: "ConcurrencyStamp",
                value: "f7f15523-dbf4-438b-9397-13f52b1e4a5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "985f4930-21ad-4249-abaf-e4251b1553d9",
                column: "ConcurrencyStamp",
                value: "bea4707d-89d4-4a92-a839-3f5455f112d5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "087f2124-f507-4642-a8f7-84442abb3d70",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c8c80b2-9ae4-4609-8165-5e46f1b195ec", "AQAAAAEAACcQAAAAEB8Dghy6V2SReOomA3Va/QGpgJRBKMUm1ZfR0x0q896F8LT1STw3EC9g8x4GQXUs+Q==", "15a588e1-6660-42ec-842e-466773b806aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7eabebd-e10c-4da9-b6aa-2db9cad6b84d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fd2e87c-6380-4aef-977f-3f4226db0e92", "AQAAAAEAACcQAAAAEG169mR/mByhRv+MRbcsmXZ4Qcu0eIPyKA3t6chAhRUUlDSoDQLlAxqEAvmULYUuGw==", "91d85170-c21d-43b8-995b-6f941aa9b098" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
