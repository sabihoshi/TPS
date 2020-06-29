using System;
using TPS.Data.Users;

namespace TPS.Data.Sales
{
    public class Transaction
    {
        public int TransactionId { get; set; }

        public Customer Customer { get; set; }

        public Employee Employee { get; set; }

        public DateTime Date { get; set; }

        public decimal Total { get; set; }

        public decimal Tax { get; set; }
    }
}