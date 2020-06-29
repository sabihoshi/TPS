using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPS.Data.Users;

namespace TPS.Data.Sales
{
    public class Customer : PersonBase
    {
        public int CustomerId { get; set; }

        public ICollection<Credit> Credits { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }

    public class CustomerConfigruation : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder
                .HasOne<Person>()
                .WithOne();
        }
    }
}