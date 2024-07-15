using ShoppingCartApplication;

namespace ShoppingCartApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddProduct()
        {
            var cart = new ShoppingCart();
            var product = new Product("TestProduct", 10.0, ProductCategory.Food);

            cart.AddProduct(product);
            Assert.Contains(product, cart.items);
        }

        [Fact]
        public void TestRemoveProduct()
        {
            var cart = new ShoppingCart();
            var product = new Product("TestProduct", 10.0, ProductCategory.Food);

            cart.AddProduct(product);
            cart.RemoveProduct(product);
            Assert.DoesNotContain(product, cart.items);
        }

        [Fact]
        public void TestCalculateTotalCost()
        {
            var cart = new ShoppingCart();
            var product1 = new Product("TestProduct1", 10.0, ProductCategory.Food);
            var product2 = new Product("TestProduct2", 20.0, ProductCategory.Clothing);

            cart.AddProduct(product1);
            cart.AddProduct(product2);
            var totalCost = cart.CalculateTotalCost();

            Assert.Equal(30.0, totalCost);
        }
    }
}