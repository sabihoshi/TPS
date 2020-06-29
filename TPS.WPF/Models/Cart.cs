using System.Collections.Generic;
using System.Linq;
using TPS.Data.Products;

namespace TPS.WPF.Models
{
    public class Cart
    {
        public Dictionary<Product, Purchase> Items { get; } = new Dictionary<Product, Purchase>();

        public decimal Total => Items.Values.Sum(i => i.Total);

        public void AddOrUpdate(Product product, uint amount)
        {
            var count = amount;

            if (Items.TryGetValue(product, out var existing)) count += existing.Amount;

            Items[product] = new Purchase(product, count);
        }
    }

    public class Purchase
    {
        public Purchase(Product item, uint amount)
        {
            Item = item;
            Amount = amount;
        }

        public Product Item { get; }

        public decimal Price => Item.Price;

        public decimal Total => Price * Amount;

        public uint Amount { get; set; }
    }
}