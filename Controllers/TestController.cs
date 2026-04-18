using EternaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class TestController: Controller
    {
        public IActionResult Index()
        {
            var product= new Product
            {
                Id=1,
                Name="Test Product"
            };

            //ViewData
            //ViewBag
            //TempData
            ViewData["group"]="PA401";
            ViewBag.StuName="Filankes";
            TempData["message"]="Welcome to EternaApp";

            return RedirectToAction("Test");
        }
        public IActionResult Test()
        {
            return View();
        }
    }
}
