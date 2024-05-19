namespace TaskProduct
{
    using System;

    namespace TaskProduct
    {
        class Program
        {
            static void Main()
            {
                ProductCatalog catalog = new ProductCatalog();
               
                catalog.Add(new Product("Laptop", 1200, ProductType.Electronics));
                catalog.Add(new Product("Phone", 600, ProductType.Electronics));
                catalog.Add(new Product("T-Shirt", 15, ProductType.Clothing));
                catalog.Add(new Product("C# Programming Book", 35, ProductType.Books));
                catalog.Add(new Product("Apple", 1, ProductType.Groceries));

                catalog.DisplayAllProducts();
                Console.WriteLine();

                ProductType Electronics = ProductType.Electronics;
                Product[] electronicsProducts = catalog.GetAllProductsByType(Electronics);
                Console.WriteLine($"Products in the category {Electronics}:");
                foreach (var product in electronicsProducts)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }

}
