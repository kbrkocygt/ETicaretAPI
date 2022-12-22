namespace ETicaretAPI.Domain.Entities
{
    public class Customer : BaseEntity
    {  //1-n ilişki, bire çok ilişki
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
