using Microsoft.EntityFrameworkCore;

namespace IT3047C_FinalProjectGroup6.Models
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasData(
                new Recipe
                {
                    id = 1,
                    Name = "Vodka Pasta",
                    Description = "A bright and creamy tomato based pasta sauce served with Penne.",
                    Ingredients = "Tomato Sauce, Heavy Whipping Cream, Olive Oil, Garlic, Pancetta (optional), Vodka, Basil, Penne",
                    Author = "Tony Gentile",
                    TimeEstimate = 30,
                    Image = "https://www.cook2eatwell.com/wp-content/uploads/2018/05/Pasta-with-Vodka-Sauce-Image-1.jpg"
                },
                new Recipe
                {
                    id = 2,
                    Name = "Peanut Butter and Jelly Sandwich",
                    Description = "An unbeatable combination of both jelly and peanut butter between two slices of bread.",
                    Ingredients = "Peanut Butter, Jelly, Bread",
                    Author = "Karan Patel",
                    TimeEstimate = 5,
                    Image = "https://www.gannett-cdn.com/media/2021/05/02/USATODAY/usatsports/imageForEntry14-XDZ.jpg"
                },
                new Recipe
                {
                    id = 3,
                    Name = "Cincinnati Chili",
                    Description = "Cincinnati Chili is a famous dish in southwestern Ohio , with it’s most popular brand being Skyline Chili. The restaurant gets its name from the city skyline of Cincinnati.",
                    Ingredients = "Ground Beef, Cheddar Cheese, Chocolate, Pasta",
                    Author = "Saif Bayarri",
                    TimeEstimate = 45,
                    Image = "https://houseofnasheats.com/wp-content/uploads/2022/02/Cincinnati-Chili-Recipe-9-1.jpg"
                },
                new Recipe
                {
                    id = 4,
                    Name = "Breakfast Burrito",
                    Description = "A quick on-the-go meal with all the nutrients you need to start your day.",
                    Ingredients = "Eggs, Bacon or Sausage, Shredded Cheese, Bell Peppers, Diced Potatoes, Tortillas.",
                    Author = "JP Kelcewski",
                    TimeEstimate = 20,
                    Image = "https://lexiscleankitchen.com/wp-content/uploads/2017/10/Breakfast-Burritos-Freezer-Friendly5.jpg"
                }
            );
        }
    }
}
