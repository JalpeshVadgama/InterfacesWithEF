namespace InterfaceWithEF
{
    public class AnotherCustomer : ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
    }
}