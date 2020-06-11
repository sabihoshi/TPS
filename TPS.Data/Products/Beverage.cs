namespace TPS.Data.Products
{
    public class Beverage : IProduct
    {
        public enum Temperatures
        {
            None,
            Hot,
            Cold
        }

        public int BeverageId { get; set; }

        public int ProductId { get; set; }

        public ulong Volume { get; set; }

        public Temperatures Temperature { get; set; }
    }
}