using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ElectronicsStore
    {
        public ProductGenerator productGenerator = new ProductGenerator();

        public List<Product> AvailableProducts = new List<Product>();

        public ElectronicsStore()
        {
            for (int i = 0; i < 10; i++)
            {
                AvailableProducts.Add(productGenerator.GenerateProduct());
            }
        }

        public void DisplayProducts()
        {
            int i = 0;
            foreach (var product in AvailableProducts)
            {
                i++;
                Console.WriteLine($"{i}. {product.Name} - {product.Price:F2} - {product.Category}");
            }
        }

        public Product SelectProduct(int index)
        {
            if (index < 0 || index >= AvailableProducts.Count)
            {
                return null;
            }
            return AvailableProducts[index];
        }
    }
}
