using EternaApp.Data;
using EternaApp.Models;
using EternaApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EternaApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly EternaDbContext _context;

        public ProductController(EternaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ProductVm productVm = new ProductVm()
            {
                Categories = _context.Categories.ToList(),
                Products = _context.Products.Include(p => p.Category).Include(p => p.ProductImages).ToList()
            };
            return View(productVm);
        }
        public IActionResult Detail(int id)
        {
            Product product = _context.Products
                .Include(p => p.Category)
                .Include(p => p.ProductImages)
                .FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }
    }
}
