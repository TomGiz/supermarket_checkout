namespace SupermarketCheckout
{
    public class Product
    {
        public Product(string sku, int price)
        {
            this.Price = price;
            this.Sku = sku;
        }

        public readonly string Sku;
        public readonly int Price;
    }
}
