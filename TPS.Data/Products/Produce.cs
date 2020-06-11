namespace TPS.Data.Products
{
    public class Produce : PerishableBase
    {
        public enum Groups
        {
            Vegetable,
            Fruit
        }

        public Groups Group { get; set; }
    }
}