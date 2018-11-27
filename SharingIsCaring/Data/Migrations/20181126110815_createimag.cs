using Microsoft.EntityFrameworkCore.Migrations;

namespace SharingIsCaring.Data.Migrations
{
    public partial class createimag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Product");
        }
    }
}
