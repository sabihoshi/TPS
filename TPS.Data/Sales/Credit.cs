using System;

namespace TPS.Data.Sales
{
    public class Credit
    {
        public enum Providers
        {
            Other,
            Visa,
            MasterCard
        }

        public int CreditId { get; set; }

        public decimal Balance { get; set; }

        public Providers Provider { get; set; }

        public ulong Number { get; set; }

        public uint SecurityCode { get; set; }

        public DateTime Expiry { get; set; }
    }
}