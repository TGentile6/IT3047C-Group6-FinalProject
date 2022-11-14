using IT3047C_FinalProjectGroup6.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT3047C_FinalProjectGroup6.Controllers
{
    public class RecipeController : Controller
    {


        private RecipeContext context { get; set; }

        public RecipeController(RecipeContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return RedirectToAction("List");
        }
        public IActionResult List()
        {
            var recipes = context.Recipes.OrderBy(m => m.id).ToList();
            return View(recipes);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recipe = context.Recipes.Find(id);
            return View(recipe);
        }
        [HttpPost]
        public IActionResult Delete(Recipe recipe)
        {
            context.Recipes.Remove(recipe);
            context.SaveChanges();
            return RedirectToAction("List", "Recipe");
        }

        [HttpGet]
        public IActionResult Add(int id)
        {
            var movie = context.Recipes.Find(id);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Add(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                if (recipe.id == 0)
                {
                    context.Recipes.Add(recipe);
                }   
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Please correct all errors");
                return View(recipe);
            }
        }
    }
}
