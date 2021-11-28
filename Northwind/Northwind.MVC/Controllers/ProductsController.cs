using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Northwind.Core;
using Northwind.MVC.Model;
using NorthwindBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.MVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IConfiguration Configuration;
        private readonly IDatabaseManipulation _databaseManipulation;
       
        public ProductsController(IDatabaseManipulation databaseManipulation, IConfiguration configuration)
        {
            _databaseManipulation = databaseManipulation;
            Configuration = configuration;
        }
        public IActionResult Products()
        {
            
            var maxAmountOfProducts = int.Parse(Configuration["MaximumAmountOfProducts"]);
            var products = _databaseManipulation.ProductList;
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
                Suppliers = _databaseManipulation.SupplierList,
                Categories = _databaseManipulation.CategoryList
            };
            return View("New", viewModel);
        }

        [HttpPost]
        public IActionResult New(Product product)
        {

            _databaseManipulation.NewProduct(product);
            return RedirectToAction("Products");           
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ProductListViewModel viewModel = new ProductListViewModel
            {
                Products = _databaseManipulation.ProductList.Where(p => p.ProductId == id).ToList(),
                Suppliers = _databaseManipulation.SupplierList,
                Categories = _databaseManipulation.CategoryList
            };
            return View("Update", viewModel);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {            
            if (ModelState.IsValid)
            {
                _databaseManipulation.UpdateProduct(product);
            }
            return RedirectToAction("Products");
        }

    }
}
