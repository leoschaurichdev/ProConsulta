using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProConsulta.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Especialidades_EspecialidadeId",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_EspecialidadeId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Agendamentos");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b048d23e-aaab-4552-98f9-91cd6c7573f6", "AQAAAAIAAYagAAAAEL6bIQeSzxCwB+KxzhiqK0dmmoPLQRPJR9cOVyq+WM5W2/QBIvTBPd1XMttcslRaog==", "015bfe53-d6f9-4e09-be5d-9228018e082b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeId",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Agendamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95433ac4-2fe9-468f-b80d-b05ec3724d1d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beded101-cb5c-41d6-8186-a4b527bbfda1", "AQAAAAIAAYagAAAAEFz+T0u4Xv8Zzu9rmNiJ81yhWLaflRN6ebxywOzBN3cSc4ZPl6qp5VrlWQ/WBci/3Q==", "00eb3f60-2546-4b9e-8e1b-3764a6783eda" });

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_EspecialidadeId",
                table: "Agendamentos",
                column: "EspecialidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Especialidades_EspecialidadeId",
                table: "Agendamentos",
                column: "EspecialidadeId",
                principalTable: "Especialidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
