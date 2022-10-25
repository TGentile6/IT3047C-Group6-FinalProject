using System.ComponentModel.DataAnnotations;

namespace IT3047C_FinalProjectGroup6.Models
{
    public class Recipe
    {

        public int RecipeID { get; set; }

        [Required(ErrorMessage = "Recipe must include a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Recipe must include a description.")]
        public string Description { get; set; }
        
        [Required(ErrorMessage = "Recipe must include ingredients.")]
        public string Ingredients { get; set; }

        [Required(ErrorMessage = "Recipe must include a time estimate.")]
        public int TimeEstimate { get; set; }

        [Required(ErrorMessage = "Recipe must include an author.")]
        public string Author { get; set; }


    }
}
