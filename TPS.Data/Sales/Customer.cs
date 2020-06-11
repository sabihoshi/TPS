using System.Collections.Generic;
using TPS.Data.Users;

namespace TPS.Data.Sales
{
    public class Customer : IPerson
    {
        public int CustomerId { get; set; }

        public int PersonId { get; set; }

        public ICollection<Credit> Credits { get; set; }

        public ICollection<TransactionBase> Transactions { get; set; }
    }
}