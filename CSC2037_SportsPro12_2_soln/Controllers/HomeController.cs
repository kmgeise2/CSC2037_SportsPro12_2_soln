using Microsoft.AspNetCore.Mvc;

namespace CSC2037_SportsPro12_2_soln.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
    }
}