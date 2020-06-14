namespace TPS.Data.Products
{
    public class Beverage : ProductBase
    {
        public enum Temperatures
        {
            None,
            Hot,
            Cold
        }

        public int BeverageId { get; set; }

        public ulong Volume { get; set; }

        public Temperatures Temperature { get; set; }
    }
}