namespace Ligia.Ecommerce.API.Entities
{
    public class Client : BaseEntity
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
