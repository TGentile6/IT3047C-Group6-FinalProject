using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3047C_FinalProjectGroup6.Migrations
{
    public partial class image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                column: "Image",
                value: "url");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                column: "Image",
                value: "url");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Recipes");
        }
    }
}
