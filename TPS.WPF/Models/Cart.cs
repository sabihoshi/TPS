using System.Collections.Generic;
using System.Linq;
using TPS.Data.Products;

namespace TPS.WPF.Models
{
    public class Cart
    {
        public List<Purchase<Product>> Items { get; set; }

        public decimal Total => Items.Sum(i => i.Total);
    }

    public class Purchase<T>
    {
        public Purchase(T item, decimal price, uint amount)
        {
            Item = item;
            Price = price;
            Amount = amount;
        }

        public T Item { get; }

        public decimal Price { get; }

        public decimal Total => Price * Amount;

        public uint Amount { get; set; }
    }
}