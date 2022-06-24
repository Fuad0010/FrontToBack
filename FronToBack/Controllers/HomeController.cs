using FronToBack.DAL;
using FronToBack.Models;
using FronToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FronToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM();
            homeVM.Sliders = _context.Sliders.ToList();
            homeVM.SliderContent = _context.SliderContents.FirstOrDefault();
            homeVM.Categories = _context.Categories.ToList();
            homeVM.Products = _context.Products.ToList();
            homeVM.FiorelloMiddles = _context.FiorelloMiddles.ToList();

            return View(homeVM);
        }

        public IActionResult Detail(int? id,string name)
        {
            if(id== null)
            {
                return NotFound();
            }
            Product dbProduct = _context.Products.FirstOrDefault(p => p.Id == id);
            if(dbProduct == null)
            {
                return NotFound();
            }
            return View(dbProduct);

        }
    }
}
