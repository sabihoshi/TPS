using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TPS.Data.Products;
using TPS.Data.Sales;
using TPS.Data.Users;

namespace TPS.Data
{
    public class TPSContext : DbContext
    {
        public TPSContext(DbContextOptions<TPSContext> options) : base(options) { }

        private DbSet<Employee> Administrators { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Person> People { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Meat> Meats { get; set; }

        public DbSet<Produce> Produces { get; set; }

        public DbSet<Aisle> Aisles { get; set; }

        public DbSet<Credit> Credits { get; set; }

        public DbSet<Transaction> Transactions { get; set; }
    }

    public class TPSContextFactory : IDesignTimeDbContextFactory<TPSContext>
    {
        public TPSContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TPSContext>()
                .UseSqlite("Data Source=master_data.db");

            return new TPSContext(optionsBuilder.Options);
        }
    }
}