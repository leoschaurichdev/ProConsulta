using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProConsulta.Migrations
{
    /// <inheritdoc />
    public partial class FifthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4482dd6d-0639-4188-85d3-ea9f9f027ad5", "AQAAAAIAAYagAAAAEJRolwBPBTf+X6jr0dR6tV7Prb5leQqnTptAuRw6Af5LzTKXkBF8Oan+Cb4owYutsg==", "1730e6be-5779-444e-92fb-fe462678d9b3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f2f7801-a9fd-48b2-91f9-8215307b838c", "AQAAAAIAAYagAAAAEAp13jPaed2izOJRLNWhTFeA4F/1b4cdDyzcHgwpEqIecI7FF1+qxK3zQGmYzVy29g==", "873ceaaf-6781-4553-90aa-6a3a5b3e9ef1" });
        }
    }
}
