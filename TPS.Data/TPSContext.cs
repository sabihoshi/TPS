using Microsoft.EntityFrameworkCore;
using TPS.Data.Users;

namespace TPS.Data
{
    public class TPSContext : DbContext
    {
        private DbSet<Employee> Administrators { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Person> Customers { get; set; }
    }
}