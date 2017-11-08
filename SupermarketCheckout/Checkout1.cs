//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SupermarketCheckout
//{
//    public class Checkout1
//    {
//        public Checkout1(ProductCatalog catalog)
//        {
//            this.Catalog = catalog;
//            this.Total = 0;
//        }

//        private readonly ProductCatalog Catalog;
//        public int Total { get; private set; }

//        /// <summary>
//        /// scan an item  based on sku
//        /// </summary>
//        /// <param name="sku">stock keeping unit</param>
//        public void Scan(string sku, int times=1)
//        {
//            Total += times * Catalog.GetPriceForProduct(sku);
//        }
//    }
//}
