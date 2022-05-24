using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class UIElementController : Controller
    {
        public IActionResult BootstrapElements()
        {
            return View();
        }
        public IActionResult Cards()
        {
            return View();
        }
        public IActionResult FontIcons()
        {
            return View();
        }
        public IActionResult Widgets()
        {
            return View();
        }
    }
}
