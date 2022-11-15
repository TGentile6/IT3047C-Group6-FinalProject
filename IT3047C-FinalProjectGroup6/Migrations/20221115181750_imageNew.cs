using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3047C_FinalProjectGroup6.Migrations
{
    public partial class imageNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                column: "Image",
                value: "https://www.cook2eatwell.com/wp-content/uploads/2018/05/Pasta-with-Vodka-Sauce-Image-1.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                column: "Image",
                value: "url");
        }
    }
}
