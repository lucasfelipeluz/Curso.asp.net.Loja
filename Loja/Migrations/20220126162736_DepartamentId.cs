using Microsoft.EntityFrameworkCore.Migrations;

namespace Loja.Migrations
{
    public partial class DepartamentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Departament_DepartamentId",
                table: "Sellers");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentId",
                table: "Sellers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Departament_DepartamentId",
                table: "Sellers",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sellers_Departament_DepartamentId",
                table: "Sellers");

            migrationBuilder.AlterColumn<int>(
                name: "DepartamentId",
                table: "Sellers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Sellers_Departament_DepartamentId",
                table: "Sellers",
                column: "DepartamentId",
                principalTable: "Departament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
