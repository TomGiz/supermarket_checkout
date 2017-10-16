using System.Collections.Generic;
using System.Linq;

namespace SupermarketCheckout
{
    public class ProductCatalog
    {
        private List<Product> catalog = new List<Product>();

        public ProductCatalog UpdateProductPrice(string sku, int price)
        {
            this.catalog.RemoveAll(x => x.Sku == sku);
            this.catalog.Add(new Product(sku, price));
            return this;
        }

        public ProductCatalog RemoveProduct(string sku)
        {
            this.catalog.RemoveAll(x => x.Sku == sku);
            return this;
        }

        public int GetPriceForProduct(string sku)
        {
            var product = this.catalog.Where(x => x.Sku == sku).FirstOrDefault();
            if (product == null) throw new UnknownSkuException(sku);
            return product.Price;
        }
    }

   
}
