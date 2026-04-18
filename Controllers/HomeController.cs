using System.Diagnostics;
using EternaApp.Data;
using EternaApp.Models;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EternaApp.Controllers
{
    public class HomeController(EternaDbContext eternaDbContext) : Controller
    {
        public IActionResult Index()
        {
            HomeVm homeVm = new HomeVm()
            {
                Sliders = eternaDbContext.Sliders.ToList(),
                Feathures = eternaDbContext.Feathures.ToList()
            };
            return View(homeVm);
        }

    }
}
