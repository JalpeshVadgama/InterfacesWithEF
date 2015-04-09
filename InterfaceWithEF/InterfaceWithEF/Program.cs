using System;

namespace InterfaceWithEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { FirstName = "Jalpesh", LastName = "Vagdama", City = "NewYork" };

            AnotherCustomer anotherCustomer = new AnotherCustomer
            {
                FirstName = "Vishal",
                LastName = "Vadgama",
                State = "NewYork"
            };
            using (CustomerContext customerContext = new CustomerContext())
            {
                customerContext.Customers.Add(customer);
                customerContext.AnotherCustomers.Add(anotherCustomer);
                customerContext.SaveChanges();
                Console.WriteLine("Both customer saved");

                foreach (var c in customerContext.Customers)
                {
                    Console.WriteLine(c.Id);
                }
                foreach (var a in customerContext.AnotherCustomers)
                {
                    Console.WriteLine(a.Id);
                }
            }



        }
    }
}
