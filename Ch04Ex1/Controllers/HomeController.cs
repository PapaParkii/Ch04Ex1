using Ch04Ex1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ch04Ex1.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context {  get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var movies = context.Movies.OrderBy(m => m.Name).ToList();
            return View(movies);
        }
    }
}
