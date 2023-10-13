using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KassenzettelApi.Migrations
{
    /// <inheritdoc />
    public partial class newRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Receipts_KassenzettelId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "KassenzettelId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Receipts_KassenzettelId",
                table: "Items",
                column: "KassenzettelId",
                principalTable: "Receipts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Receipts_KassenzettelId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "KassenzettelId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Receipts_KassenzettelId",
                table: "Items",
                column: "KassenzettelId",
                principalTable: "Receipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
