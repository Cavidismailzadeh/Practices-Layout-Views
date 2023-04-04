using Microsoft.AspNetCore.Mvc;

namespace Practices_Layout_Views.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
