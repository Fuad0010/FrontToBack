using Microsoft.AspNetCore.Mvc;

namespace FronToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
