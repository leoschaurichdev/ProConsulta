using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProConsulta.Migrations
{
    /// <inheritdoc />
    public partial class SixtyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc3b447d-f5bb-4409-a2f6-0ad5669d7bda", "AQAAAAIAAYagAAAAEAVJGc7h4UvI5XCw4RN4Ja9qAi2x1igH6mwEpMSNB3+0bH2rr7Tm//sQqcscFqvGuQ==", "b92848a6-f681-42ff-aefa-de521ff47f88" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4482dd6d-0639-4188-85d3-ea9f9f027ad5", "AQAAAAIAAYagAAAAEJRolwBPBTf+X6jr0dR6tV7Prb5leQqnTptAuRw6Af5LzTKXkBF8Oan+Cb4owYutsg==", "1730e6be-5779-444e-92fb-fe462678d9b3" });
        }
    }
}
