using System;

namespace SupermarketCheckout
{
    class UnknownSkuException : Exception
    {
        public UnknownSkuException(string sku) : base($"Unknown SKU = {sku}")
        {
        }
    }
}
