namespace Shop.Tests
{
    using NUnit.Framework;

    [TestFixture] // Class with tests
    public class ShopTests
    {
        [Test] // Unit test
        public void TestThatThereIsOneProductLessOnBuy()
        {
            //Arrange
            var shop = new Shop();

            var cheese = new Product("Cheese", 9.50m);
            shop.Add(cheese);

            var bananas = new Product("Bananas", 5m);
            shop.Add(bananas);

            var mango = new Product("Mango", 3.99m);
            shop.Add(mango);

            var riceUp = new Product("RiceUp", 2.10m);
            shop.Add(riceUp);

            //Act
            shop.Buy(mango);

            //Assert
            Assert.AreEqual(3, shop.Count); // (expected, actual)
        }
    }
}
