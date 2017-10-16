using System.Collections.Generic;
using System.Linq;

namespace SupermarketCheckout
{
    public class Discount
    {
        public Discount (string sku, int numberOfItems, int packagePrice)
        {
            this.Sku = sku;
            this.NumberOfItems = numberOfItems;
            this.PackagePrice = packagePrice;
        }

        public readonly string Sku;
        public readonly int NumberOfItems;
        public readonly int PackagePrice;
    }

    public class Discounts
    {
        private List<Discount> discounts = new List<Discount>();

        public Discounts DiscountProduct(string sku, int numberOfItems, int packagePrice)
        {
            this.discounts.RemoveAll(x => x.Sku == sku);
            this.discounts.Add(new Discount(sku, numberOfItems, packagePrice));
            return this;
        }

        public int GetDiscountedPrice(string sku, ref int numberOfItemsToCalculatePriceFor)
        {
            var discount = this.discounts.Where(x => x.Sku == sku).FirstOrDefault();
            if (discount == null) return 0; // no discounted price for this product

            var discountedPrice = (numberOfItemsToCalculatePriceFor / discount.NumberOfItems) * discount.PackagePrice;

            // number of items to still calculate price for
            numberOfItemsToCalculatePriceFor = numberOfItemsToCalculatePriceFor % discount.NumberOfItems;

            return discountedPrice;
        }
    }
}
