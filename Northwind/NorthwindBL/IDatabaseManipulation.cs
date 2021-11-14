using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Northwind.Core;

namespace NorthwindBL
{
    public interface IDatabaseManipulation
    {
        List<Category> CategoryList { get; }
        List<Product> ProductList { get; }
        List<Supplier> SupplierList { get; }

        void NewProduct(Product product);
        void UpdateProduct(Product product);
        void UpdateCategory(Category category);
        List<Category> FindImage(int id); 
    }
}
