using Microsoft.AspNetCore.Mvc;

namespace crudApp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
