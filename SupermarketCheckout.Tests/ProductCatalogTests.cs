using Xunit;

namespace SupermarketCheckout.Tests
{
    public class ProductCatalogTests
    {
        [Fact]
        public void can_add_product()
        {
            // ARRANGE
            var catalog = new ProductCatalog();

            // ACT
            catalog.UpdateProductPrice("A", 50);

            // ASSERT
            Assert.Equal(50, catalog.GetPriceForProduct("A"));
        }

        [Fact]
        public void can_remove_product()
        {
            // ARRANGE
            var catalog = new ProductCatalog();
            catalog.UpdateProductPrice("A", 50);

            // ACT
            catalog.RemoveProduct("A");

            // ASSERT
            Assert.Throws<UnknownSkuException>(
                ()=>  catalog.GetPriceForProduct("A"));
        }
    }
}
