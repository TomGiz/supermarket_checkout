using System;

namespace SupermarketCheckout
{
    public class UnknownSkuException : Exception
    {
        public UnknownSkuException(string sku) : base($"Unknown SKU = {sku}")
        {
        }
    }
}
