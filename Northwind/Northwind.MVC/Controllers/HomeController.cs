using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Northwind.Core;

namespace Northwind.MVC.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext db;
        public HomeController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }        
    }
}
