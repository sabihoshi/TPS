using System;

namespace TPS.Data.Products
{
    public class Perishable : ProductBase
    {
        public int PerishableId { get; set; }

        public DateTimeOffset ManufacturingDate { get; set; }

        public DateTimeOffset ExpiryDate { get; set; }
    }
}