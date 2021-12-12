using Microsoft.AspNetCore.Mvc;

namespace MoveElementRealtime.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
