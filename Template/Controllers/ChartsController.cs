using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
