namespace ETicaretAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Orders { get; set; } //birden çok order n-n çok'a çok ilişki 
        public Customer Customer { get; set; } // birden fazla customer olmaz , bir tane müşterisi olur
    }
}
