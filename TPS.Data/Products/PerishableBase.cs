using System;

namespace TPS.Data.Products
{
    public abstract class PerishableBase : IProduct
    {
        public int PerishableId { get; set; }

        public int ProductId { get; set; }

        public DateTimeOffset ManufacturingDate { get; set; }

        public DateTimeOffset ExpiryDate { get; set; }
    }
}