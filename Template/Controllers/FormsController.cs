using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class FormsController : Controller
    {
        public IActionResult CustomComponents()
        {
            return View();
        }
        public IActionResult FormComponents()
        {
            return View();
        }
        public IActionResult FormNotifications()
        {
            return View();
        }
        public IActionResult FormSamples()
        {
            return View();
        }
    }
}
