using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Northwind.Core;
using Northwind.MVC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IConfiguration Configuration;        

        NorthwindContext db;
        public ProductsController(NorthwindContext context, IConfiguration configuration)
        {
            db = context;
            Configuration = configuration;
        }
        public IActionResult Products()
        {
            
            var maxAmountOfProducts = int.Parse(Configuration["MaximumAmountOfProducts"]);
            var products = db.Products.Include(u => u.Category).Include(u => u.Supplier).ToList();
            var maxProducts = products.Take(maxAmountOfProducts).ToList();
            if (maxAmountOfProducts == 0)
            {
                return View("Products", products);
            }
            else
            {
                return View("Products", maxProducts);
            }            
            
        }

        [HttpGet]
        public IActionResult New()
        {
            ProductListViewModel viewModel = new ProductListViewModel
            {
                Products = null,
                Suppliers = db.Suppliers.OrderBy(s => s.CompanyName).ToList(),
                Categories = db.Categories.OrderBy(c => c.CategoryName).ToList()
            };
            return View("New", viewModel);
        }

        [HttpPost]
        public IActionResult New(Product product)
        {            
            db.Products.Add(product);            
            db.SaveChanges();
            return View("Products");           
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ProductListViewModel viewModel = new ProductListViewModel
            {
                Products = db.Products.Include(u => u.Category).Include(u => u.Supplier).Where(p => p.ProductId == id).ToList(),
                Suppliers = db.Suppliers.OrderBy(s => s.CompanyName).ToList(),
                Categories = db.Categories.OrderBy(c => c.CategoryName).ToList()
            };
            return View("Update", viewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {            
            if (ModelState.IsValid)
            {
                db.Products.Update(product);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Products");
        }

    }
}
