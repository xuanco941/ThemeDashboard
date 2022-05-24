using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Blank()
        {
            return View();
        }
        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult Lockscreen()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Mailbox()
        {
            return View();
        }
        public IActionResult UserPage()
        {
            return View();
        }
    }
}
