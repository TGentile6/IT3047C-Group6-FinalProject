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

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
