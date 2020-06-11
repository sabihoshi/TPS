using Microsoft.EntityFrameworkCore;
using TPS.Data.Products;
using TPS.Data.Sales;
using TPS.Data.Users;

namespace TPS.Data
{
    public class TPSContext : DbContext
    {
        private DbSet<Employee> Administrators { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Person> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Aisle> Aisles { get; set; }

        public DbSet<Credit> Credits { get; set; }

        public DbSet<TransactionBase> Transactions { get; set; }
    }
}