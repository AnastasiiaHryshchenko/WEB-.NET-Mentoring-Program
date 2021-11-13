using Microsoft.AspNetCore.Mvc;
using Northwind.Core;
using Northwind.MVC.Model;
using NorthwindBL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        [HttpGet]
        public IActionResult Update(int id)
        {
            ProductListViewModel viewModel = new ProductListViewModel
            {
                Products = null,
                Suppliers = null,
                Categories = _dateFromCategory.CategoryList.Where(p => p.CategoryId == id).ToList()
            };
            return View("Update", viewModel);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {             
            if (ModelState.IsValid)
            {
                _dateFromCategory.UpdateCategory (category);
            }
            return RedirectToAction("Categories");
        }

    }
}