using FronToBack.DAL;
using FronToBack.Models;
using FronToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FronToBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Product> products = _context.Products.Take(2).Include(p=>p.Category).ToList();
            ViewBag.ProductCount = _context.Products.Count();
            return View(products);
        }
        public IActionResult LoadMore(int skip)
        {
            List<Product> products = _context.Products.Skip(skip).Take(2).Include(p=>p.Category).ToList();

            #region Json

            //List<ProductReturnVM> products = _context.Products.Select(p => new ProductReturnVM
            //{
            //    Id=p.Id,
            //    Name=p.Name,
            //    Price=p.Price,
            //    CategoryId=p.CategoryId,
            //    Category=p.Category.Name
            //}).ToList();


            //List<ProductReturnVM> productReturnVMs = new List<ProductReturnVM>();

            //foreach (var item in products)
            //{
            //    ProductReturnVM productReturnVM = new ProductReturnVM();
            //    productReturnVM.Id = item.Id;
            //    productReturnVM.Name = item.Name;
            //    productReturnVM.Price = item.Price;
            //    productReturnVM.Category= item.Category;
            //    productReturnVM.CategoryId= item.CategoryId;
            //    productReturnVMs.Add(productReturnVM);
            //}
            #endregion

            return PartialView("_LoadMorePartial",products);
        }
    }
}
