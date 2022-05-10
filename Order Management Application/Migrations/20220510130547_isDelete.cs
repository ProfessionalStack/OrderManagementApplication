using Microsoft.EntityFrameworkCore.Migrations;

namespace Order_Management_Application.Migrations
{
    public partial class isDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isDelete",
                table: "Suppliers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDelete",
                table: "Suppliers");
        }
    }
}
