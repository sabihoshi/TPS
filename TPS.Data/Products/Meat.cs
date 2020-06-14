namespace TPS.Data.Products
{
    public class Meat : Perishable
    {
        public enum Type
        {
            Other,
            Red,
            Poultry,
            Pork,
            Seafood
        }

        public int MeatId { get; set; }

        public Type MeatType { get; set; }
    }
}