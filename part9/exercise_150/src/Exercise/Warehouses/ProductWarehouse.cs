namespace Exercise
{
    using System;
    public class ProductWarehouse : Warehouse
    {

        public string productName;

        public ProductWarehouse(string productName, int capacity) : base(capacity)
        {
            this.productName = productName;
        }

        public override string ToString()
        {
            return productName + ": " + base.ToString();
        }
    }
}