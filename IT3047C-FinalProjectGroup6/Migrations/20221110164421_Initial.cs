using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3047C_FinalProjectGroup6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeEstimate = table.Column<int>(type: "int", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "id", "Author", "Description", "Ingredients", "Name", "TimeEstimate" },
                values: new object[] { 1, "Tony Gentile", "A bright and creamy tomato based pasta sauce served with Penne", "Tomato Sauce, Heavy Whipping Cream, Olive Oil, Garlic, Pancetta (optional), Vodka, Basil, Penne", "Vodka Pasta", 45 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
