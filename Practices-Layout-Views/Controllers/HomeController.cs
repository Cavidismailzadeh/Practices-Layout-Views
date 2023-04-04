using Microsoft.AspNetCore.Mvc;
using Practices_Layout_Views.Models;
using Practices_Layout_Views.ViewModels.Home;
using Practices_Layout_Views.ViewModels.Product;

namespace Practices_Layout_Views.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            #region Practice1
            //ViewData["names"] = new string[] { "Elcan", "Pervin", "Aqshin" };

            //ViewBag.numbers = new int[] { 10, 20, 30, 40 };

            //string name = "Konul";

            //return View((object)name);

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

            //ViewBag.name = "Elcan";

            //TempData["surname"] = "Qurbanov";

            //return RedirectToAction(nameof(Detail));


            #endregion



            Student stu1 = new Student
            {
                Id = 1,
                FullName = "Pervin Rehimli",
                Age = 26
            };

            Student stu2 = new Student
            {
                Id = 2,
                FullName = "Ali Talibov",
                Age = 20
            };

            Student stu3 = new Student
            {
                Id = 3,
                FullName = "Mirze Besirli",
                Age = 27
            };

            List<Student> students = new List<Student> { stu1, stu2, stu3 };


            Product product = new()
            {
                Id = 1,
                Name = "Samsung 11",
                Count = 50,
                Price = 200,
                Description = "Description"
            };

            ProductVM productVM = new()
            {
                Name=product.Name,
                Price=product.Price
            };

            HomeVM VM = new HomeVM()
            {
                Students = students,
                Product = productVM
            };

            return View(VM);


        }

        //public IActionResult Detail()
        //{
        //    return View();
        //}
    }
}
