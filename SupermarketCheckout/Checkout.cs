using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketCheckout
{
    public class Checkout
    {
        public Checkout(ProductCatalog catalog, Discounts discounts)
        {
            this.Catalog = catalog;
            this.Discounts = discounts;
            this.ScannedItems = new Dictionary<string, int>();
        }

        private readonly ProductCatalog Catalog;
        private readonly Discounts Discounts;
        private readonly Dictionary<string, int> ScannedItems;

        /// <summary>
        /// scan an item  based on sku
        /// </summary>
        /// <param name="sku">stock keeping unit</param>
        public void Scan(string sku, int times = 1)
        {
            if (ScannedItems.ContainsKey(sku))
            {
                ScannedItems[sku] += times;
            }
            else
            {
                ScannedItems.Add(sku, times);
            }
        }

        public int Total
        {
            get
            {
                var total = 0;
                foreach (var group in ScannedItems)
                {
                    var sku = group.Key;
                    var number_of_items = group.Value;
                    total += Discounts.GetDiscountedPrice(sku, ref number_of_items);
                    total += number_of_items * Catalog.GetPriceForProduct(group.Key);
                }
                return total;
            }
        }
    }
}
