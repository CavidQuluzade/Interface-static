using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProduct
{
    namespace TaskProduct
    {
        public class ProductCatalog
        {
            private Product[] products;
            private int count;

            public ProductCatalog()
            {
                products = new Product[0]; 
                count = 0;
            }
            public void Add(Product product)
            {
                Array.Resize(ref products, products.Length + 1); 
                products[count] = product;
                count++;
            }
            public Product[] GetAll()
            {
                Product[] allProducts = new Product[count];
                Array.Copy(products, allProducts, count);
                return allProducts;
            }
            public Product[] GetAllProductsByType(ProductType type)
            {
                Product[] typeProducts = new Product[count];
                int typeCount = 0;
                for (int i = 0; i < count; i++)
                {
                    if (products[i].Type == type)
                    {
                        typeProducts[typeCount] = products[i];
                        typeCount++;
                    }
                }
                Array.Resize(ref typeProducts, typeCount);
                return typeProducts;
            }            
            public void DisplayAllProducts()
            {
                foreach (var product in GetAll())
                {
                    Console.WriteLine(product);
                }
            }
        }
    }

}
