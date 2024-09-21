using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProConsulta.Migrations
{
    /// <inheritdoc />
    public partial class fourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Pacientes",
                type: "NVARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Pacientes",
                type: "NVARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f2f7801-a9fd-48b2-91f9-8215307b838c", "AQAAAAIAAYagAAAAEAp13jPaed2izOJRLNWhTFeA4F/1b4cdDyzcHgwpEqIecI7FF1+qxK3zQGmYzVy29g==", "873ceaaf-6781-4553-90aa-6a3a5b3e9ef1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Pacientes",
                type: "VARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(11)");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Pacientes",
                type: "VARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(11)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "332ff700-0d06-44ac-b2cb-94ab1fdc92b2", "AQAAAAIAAYagAAAAEBOKEGSHLWlw4ycysBhb8jAn4YujcqROPHvPf0QHXVF349jYOMZbs84khTrI941h4w==", "2ddad435-9ecd-4ecf-831a-56d046198f1e" });
        }
    }
}
