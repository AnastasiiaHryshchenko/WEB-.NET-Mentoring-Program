using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
