namespace GroceryApp.Api.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public short CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
