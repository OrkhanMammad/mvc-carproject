using Microsoft.AspNetCore.Mvc;

namespace CarProject.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
