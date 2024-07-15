using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
        public static Random random = new Random();
        public static string[] productNames = { "Apple", "T-Shirt", "Laptop", "Banana", "Jeans" };

        public Product GenerateProduct()
        {
            string name = productNames[random.Next(productNames.Length)];
            int price = (int)(random.Next(100, 10000) / 100);
            ProductCategory category = (ProductCategory)random.Next(ProductCategory.GetValues(typeof(ProductCategory)).Length);

            return new Product(name, price, category);
        }
    }
}
