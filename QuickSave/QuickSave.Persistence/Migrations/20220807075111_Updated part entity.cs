using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickSave.Persistence.Migrations
{
    public partial class Updatedpartentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Parts",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Parts");
        }
    }
}
