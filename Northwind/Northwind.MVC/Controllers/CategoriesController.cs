using Microsoft.AspNetCore.Mvc;
using Northwind.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        NorthwindContext db;
        public CategoriesController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Categories()
        {         
            return View("~/Views/Home/Categories.cshtml", db.Categories.ToList());
        }
    }
}
