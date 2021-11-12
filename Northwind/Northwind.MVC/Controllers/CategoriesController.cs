using Microsoft.AspNetCore.Mvc;
using Northwind.Core;
using Northwind.MVC.Model;
using NorthwindBL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly IDatabaseManipulation _dateFromCategory;

        public CategoriesController(IDatabaseManipulation dateFromCategory)
        {
            _dateFromCategory = dateFromCategory;
        }

        public IActionResult Categories()
        {         
            return View("Categories", _dateFromCategory.CategoryList);
        }
    }
}