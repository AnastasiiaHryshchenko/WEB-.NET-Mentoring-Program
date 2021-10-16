using Microsoft.AspNetCore.Mvc;
using Northwind.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MVC.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindContext db;
        public ProductsController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Products()
        {           
            return View("~/Views/Home/Products.cshtml", db.Products.ToList());
        }
    }
}
