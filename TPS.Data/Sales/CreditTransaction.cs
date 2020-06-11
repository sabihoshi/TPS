namespace TPS.Data.Sales
{
    public class CreditTransaction : TransactionBase
    {
        public int CreditTransactionId { get; set; }

        public Credit Credit { get; set; }
    }
}