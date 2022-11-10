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
                    Description = "A bright and creamy tomato based pasta sauce served with Penne",
                    Ingredients = "Tomato Sauce, Heavy Whipping Cream, Olive Oil, Garlic, Pancetta (optional), Vodka, Basil, Penne",
                    Author = "Tony Gentile",
                    TimeEstimate = 45
                }
            );
        }
    }
}
