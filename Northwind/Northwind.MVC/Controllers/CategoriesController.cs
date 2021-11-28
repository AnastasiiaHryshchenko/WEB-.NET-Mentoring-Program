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
        private readonly IDatabaseManipulation _databaseManipulation;

        public CategoriesController(IDatabaseManipulation databaseManipulation)
        {
            _databaseManipulation = databaseManipulation;
        }

        public IActionResult Categories()
        {         
            return View("Categories", _databaseManipulation.CategoryList);
        }
        [HttpGet]
        [Route("Categories/Update/{id?}")]
        [Route("Categories/Update/images/{id?}")]
        public IActionResult Update(int id)
        {
            ProductListViewModel viewModel = new ProductListViewModel
            {
                Products = null,
                Suppliers = null,
                Categories = _databaseManipulation.CategoryList.Where(p => p.CategoryId == id).ToList()
            };
            return View("Update", viewModel);
        }
        [HttpPost]
        [Route("Categories/Update/{id?}")]
        [Route("Categories/Update/images/{id?}")]
        public IActionResult Update(Category category)
        {
            _databaseManipulation.UpdateCategory (category);            
            return RedirectToAction("Categories");
        }

    }
}