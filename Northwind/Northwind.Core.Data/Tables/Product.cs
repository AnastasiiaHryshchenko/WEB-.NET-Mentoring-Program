using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Northwind.Core
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        [Required(ErrorMessage = "Doesn't contains null or empty values")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Doesn't contains null or empty values")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Длина строки должна быть от 3 до 200 символов")]
        public string ProductName { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        [Required(ErrorMessage = "Doesn't contains null or empty values")]
        public string QuantityPerUnit { get; set; }
        [Range(0, 999999)]
        public decimal? UnitPrice { get; set; }
        [Range(0, 9999)]
        public short? UnitsInStock { get; set; }
        [Range(0, 99)]
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        [Required(ErrorMessage = "Doesn't contains null or empty values")]
        public bool Discontinued { get; set; }
        
        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
