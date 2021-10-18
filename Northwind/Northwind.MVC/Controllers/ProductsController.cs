using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Northwind.Core;
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
                return View("~/Views/Home/Products.cshtml", products);
            }
            else
            {
                return View("~/Views/Home/Products.cshtml", maxProducts);
            }            
            
        }
    }
}
