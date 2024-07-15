
namespace ShoppingCartApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart cart = new ShoppingCart();
            GroceryStore groceryStore = new GroceryStore();
            ClothingStore clothingStore = new ClothingStore();
            ElectronicsStore electronicsStore = new ElectronicsStore();

            while (true)
            {
                Console.WriteLine("Welcome to the Smart Cart Application!");
                Console.WriteLine("1. Shop at Grocery Store");
                Console.WriteLine("2. Shop at Electronics Store");
                Console.WriteLine("3. Shop at Clothing Store");
                Console.WriteLine("4. View Cart");
                Console.WriteLine("5. Calculate Total Cost");
                Console.WriteLine("6. Checkout and Exit");
                Console.Write("Choice an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ShopAtStore(groceryStore, cart);
                        break;
                    case 2:
                        ShopAtStore(electronicsStore, cart);
                        break;
                    case 3:
                        ShopAtStore(clothingStore, cart);
                        break;
                    case 4:
                        cart.ViewCart();
                        break;
                    case 5:
                        double totalCost = cart.CalculateTotalCost();
                        Console.WriteLine($"Total Cost: {totalCost:C}");
                        break;
                    case 6:
                        Console.WriteLine("Thank you for shopping!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        static void ShopAtStore(dynamic store, ShoppingCart cart)
        {
            store.DisplayProducts();
            Console.Write("Enter the index of the product to add to cart, or -1 to go back: ");
            int index = int.Parse(Console.ReadLine());

            if (index == -1)
            {
                return;
            }

            Product product = store.SelectProduct(index);
            if (product != null)
            {
                cart.AddProduct(product);
                Console.WriteLine($"{product.Name} added to cart.");
            }
            else
            {
                Console.WriteLine("Invalid product index.");
            }
        }
    }
}
