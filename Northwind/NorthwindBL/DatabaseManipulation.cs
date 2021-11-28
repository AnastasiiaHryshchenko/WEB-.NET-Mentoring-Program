using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Core;

namespace NorthwindBL
{
    public class DatabaseManipulation : IDatabaseManipulation
    {
        readonly NorthwindContext _context;       

        public DatabaseManipulation(NorthwindContext context)
        {
            _context = context;
        }
       
        public List<Category> CategoryList
        {
            get { return _context.Categories.OrderBy(c => c.CategoryName).ToList(); }
        }        
        public List<Product> ProductList
        {
            get { return _context.Products.Include(u => u.Category).Include(u => u.Supplier).ToList(); }
        }

        public List<Supplier> SupplierList
        {
            get { return _context.Suppliers.OrderBy(s => s.CompanyName).ToList(); }
        }          

        public void NewProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public List<Category> FindImage(int id)
        {
            return _context.Categories.Where(c => c.CategoryId == id).ToList();       
        }
    }
}
