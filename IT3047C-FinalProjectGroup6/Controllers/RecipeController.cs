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
        public IActionResult Add()
        {
            return View(new Recipe());
        }
        [HttpPost]
        public IActionResult Add(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                context.Recipes.Add(recipe);
                context.SaveChanges();
                return RedirectToAction("Index", "Recipe");
            }
            else
            {
                return View(recipe);
            }
        }
    }
}
