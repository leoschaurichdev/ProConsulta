using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProConsulta.Migrations
{
    /// <inheritdoc />
    public partial class thirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Medicos",
                type: "NVARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Medicos",
                type: "NVARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)");

            migrationBuilder.AlterColumn<string>(
                name: "Crm",
                table: "Medicos",
                type: "NVARCHAR(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(8)");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Medicos",
                type: "NVARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(11)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "332ff700-0d06-44ac-b2cb-94ab1fdc92b2", "AQAAAAIAAYagAAAAEBOKEGSHLWlw4ycysBhb8jAn4YujcqROPHvPf0QHXVF349jYOMZbs84khTrI941h4w==", "2ddad435-9ecd-4ecf-831a-56d046198f1e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Medicos",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Documento",
                table: "Medicos",
                type: "VARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(11)");

            migrationBuilder.AlterColumn<string>(
                name: "Crm",
                table: "Medicos",
                type: "VARCHAR(8)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(8)");

            migrationBuilder.AlterColumn<string>(
                name: "Celular",
                table: "Medicos",
                type: "VARCHAR(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(11)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b048d23e-aaab-4552-98f9-91cd6c7573f6", "AQAAAAIAAYagAAAAEL6bIQeSzxCwB+KxzhiqK0dmmoPLQRPJR9cOVyq+WM5W2/QBIvTBPd1XMttcslRaog==", "015bfe53-d6f9-4e09-be5d-9228018e082b" });
        }
    }
}
