using Microsoft.AspNetCore.Mvc;

namespace Agro.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
