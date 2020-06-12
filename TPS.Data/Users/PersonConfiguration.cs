using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPS.Data.Sales;

namespace TPS.Data.Users
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .HasOne<Customer>()
                .WithOne();

            builder
                .HasOne<Employee>()
                .WithOne();
        }
    }
}