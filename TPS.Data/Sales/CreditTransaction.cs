namespace TPS.Data.Sales
{
    public class CreditTransaction : Transaction
    {
        public int CreditTransactionId { get; set; }

        public Credit Credit { get; set; }
    }
}