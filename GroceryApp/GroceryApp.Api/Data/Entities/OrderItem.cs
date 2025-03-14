using System.ComponentModel.DataAnnotations;

namespace GroceryApp.Api.Data.Entities
{
    public class OrderItem
    {
        [Key]
        public Guid ID { get; set; }
        public long OrderID { get; set; }
        public int ProductID { get; set; }
        [Required, MaxLength(100)]
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
