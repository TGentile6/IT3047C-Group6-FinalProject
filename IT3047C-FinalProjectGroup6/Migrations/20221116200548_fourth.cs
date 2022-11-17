using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3047C_FinalProjectGroup6.Migrations
{
    public partial class fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                column: "Image",
                value: "https://www.gannett-cdn.com/media/2021/05/02/USATODAY/usatsports/imageForEntry14-XDZ.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                column: "Image",
                value: "url");
        }
    }
}
