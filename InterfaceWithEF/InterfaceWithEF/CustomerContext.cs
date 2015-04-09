using System.Data.Entity;

namespace InterfaceWithEF
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(): base("ConnectionString")
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<AnotherCustomer> AnotherCustomers { get; set; }
    }
}