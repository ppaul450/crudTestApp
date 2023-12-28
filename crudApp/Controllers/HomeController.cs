using Microsoft.AspNetCore.Mvc;

namespace crudApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
