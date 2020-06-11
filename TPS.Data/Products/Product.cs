using System;

namespace TPS.Data.Products
{
    public class Product : IProduct
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Code { get; set; }

        public DateTime AddedIn { get; set; }
    }

    public interface IProduct
    {
        int ProductId { get; set; }
    }
}