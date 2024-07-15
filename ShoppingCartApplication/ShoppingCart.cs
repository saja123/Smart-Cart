using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ShoppingCart 
    {
        public List<Product> items = new List<Product>();
        public void AddProduct(Product product)
        {
            items.Add(product);
            Console.WriteLine("The item added successfuly");
        }

        public void RemoveProduct(Product product)
        {
            items.Remove(product);
            Console.WriteLine("The item removed successfuly");
        }

        public void ViewCart()
        {
            Console.WriteLine("Your cart:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} - {item.Price:F2} - {item.Category}");
            }
        }

        public double CalculateTotalCost()
        {
            return items.Sum(item => item.Price);
        }

    }
}
