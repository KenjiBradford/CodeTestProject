using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeTestProject.Migrations
{
    public partial class OfferUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Offer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Offer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
