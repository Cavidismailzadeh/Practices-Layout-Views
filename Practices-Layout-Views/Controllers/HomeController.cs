using Microsoft.AspNetCore.Mvc;

namespace Practices_Layout_Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            //ViewData["names"] = new string[] { "Elcan", "Pervin", "Aqshin" };

            //ViewBag.numbers = new int[] { 10, 20, 30, 40 };


            //string name = "Konul";

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };



            return View();
        }
    }
}
