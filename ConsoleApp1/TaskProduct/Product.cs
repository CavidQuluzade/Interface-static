using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProduct
{
    namespace TaskProduct
    {
        public enum ProductType
        {
            Electronics,
            Clothing,
            Books,
            Groceries
        }
        public class Product
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
            public ProductType Type { get; set; }
            public Product(string name, decimal price, ProductType type)
            {
                Name = name;
                Price = price;
                Type = type;
            }
            public override string ToString()
            {
                return $"{Name}, Price: {Price}, Type: {Type}";
            }
        }
    }

}
