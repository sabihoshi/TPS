namespace TPS.Data.Products
{
    public class Produce : Perishable
    {
        public enum Groups
        {
            Vegetable,
            Fruit
        }

        public int ProduceId { get; set; }

        public Groups Group { get; set; }
    }
}