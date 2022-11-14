using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3047C_FinalProjectGroup6.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "id", "Author", "Description", "Ingredients", "Name", "TimeEstimate" },
                values: new object[] { 2, "Karan Patel", "An unbeatable combination with both jelly and peanut butter in between two slices of bread", "Peanut butter, Jelly, Bread", "Peanut butter and jelly sandwich", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2);
        }
    }
}
