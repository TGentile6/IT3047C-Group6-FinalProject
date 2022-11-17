using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IT3047C_FinalProjectGroup6.Migrations
{
    public partial class fifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Description", "TimeEstimate" },
                values: new object[] { "A bright and creamy tomato based pasta sauce served with Penne.", 30 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Description", "Ingredients", "Name" },
                values: new object[] { "An unbeatable combination of both jelly and peanut butter between two slices of bread.", "Peanut Butter, Jelly, Bread", "Peanut Butter and Jelly Sandwich" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "id", "Author", "Description", "Image", "Ingredients", "Name", "TimeEstimate" },
                values: new object[,]
                {
                    { 3, "Saif Bayarri", "Cincinnati Chili is a famous dish in southwestern Ohio , with it’s most popular brand being Skyline Chili. The restaurant gets its name from the city skyline of Cincinnati.", "https://houseofnasheats.com/wp-content/uploads/2022/02/Cincinnati-Chili-Recipe-9-1.jpg", "Ground Beef, Cheddar Cheese, Chocolate, Pasta", "Cincinnati Chili", 45 },
                    { 4, "JP Kelcewski", "A quick on-the-go meal with all the nutrients you need to start your day.", "https://lexiscleankitchen.com/wp-content/uploads/2017/10/Breakfast-Burritos-Freezer-Friendly5.jpg", "Eggs, Bacon or Sausage, Shredded Cheese, Bell Peppers, Diced Potatoes, Tortillas.", "Breakfast Burrito", 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "Description", "TimeEstimate" },
                values: new object[] { "A bright and creamy tomato based pasta sauce served with Penne", 45 });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "Description", "Ingredients", "Name" },
                values: new object[] { "An unbeatable combination with both jelly and peanut butter in between two slices of bread", "Peanut butter, Jelly, Bread", "Peanut butter and jelly sandwich" });
        }
    }
}
