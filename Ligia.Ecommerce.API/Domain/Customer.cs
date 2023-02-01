namespace Ligia.Ecommerce.API.Domain
{
    public class Customer
    {
        public string Id { get; private set; }
        public string UserName { get; private set; }

        public string Password { get; private set; }

        public Customer(string userName, string password)
        {
            Id = Guid.NewGuid().ToString();
            UserName = userName;
            Password = password;
        }
    }
}
