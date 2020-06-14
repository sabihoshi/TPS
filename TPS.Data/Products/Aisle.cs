using System.Collections.Generic;

namespace TPS.Data.Products
{
    public class Aisle
    {
        public int AisleId { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}