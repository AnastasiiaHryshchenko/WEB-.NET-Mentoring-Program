using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Northwind.Core;

namespace NorthwindBL
{
    public class DatabaseManipulation : IDatabaseManipulation
    {
        NorthwindContext db = new NorthwindContext();
        private List<Product> product;

        public DatabaseManipulation(NorthwindContext context)
        {
            db = context;
        }
       
        public List<Category> CategoryList
        {
            get { return db.Categories.OrderBy(c => c.CategoryName).ToList(); }
        }
        public List<Product> ProductList
        {
            get { return db.Products.Include(u => u.Category).Include(u => u.Supplier).ToList(); }
        }

        public List<Supplier> SupplierList
        {
            get { return db.Suppliers.OrderBy(s => s.CompanyName).ToList(); }
        }
        
        public void NewProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            db.Products.Update(product);
            db.SaveChanges();
        }
    }
}
