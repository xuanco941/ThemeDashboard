using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult BasicTables()
        {
            return View();
        }
        public IActionResult DataTables()
        {
            return View();
        }
    }
}
