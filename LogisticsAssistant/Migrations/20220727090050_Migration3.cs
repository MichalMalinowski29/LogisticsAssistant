using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LogisticsAssistant.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Vmax",
                table: "Truck",
                newName: "vMax");

            migrationBuilder.RenameColumn(
                name: "BreakRequired",
                table: "Truck",
                newName: "breakRequired");

            migrationBuilder.AddColumn<int>(
                name: "truckId",
                table: "Truck",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "truckId",
                table: "Truck");

            migrationBuilder.RenameColumn(
                name: "vMax",
                table: "Truck",
                newName: "Vmax");

            migrationBuilder.RenameColumn(
                name: "breakRequired",
                table: "Truck",
                newName: "BreakRequired");
        }
    }
}
