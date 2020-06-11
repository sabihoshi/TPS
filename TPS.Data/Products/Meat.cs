namespace TPS.Data.Products
{
    public class Meat : PerishableBase
    {
        public enum Type
        {
            Other,
            Red,
            Poultry,
            Pork,
            Seafood
        }

        public Type MeatType { get; set; }
    }
}