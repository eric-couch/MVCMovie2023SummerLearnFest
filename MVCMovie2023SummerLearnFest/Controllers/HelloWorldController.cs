using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCMovie2023SummerLearnFest.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            //var movie = new { id = 1, name = "The Matrix", description = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers." };
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1) {
            ViewData["Message"] = $"Hello, {name}";
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
