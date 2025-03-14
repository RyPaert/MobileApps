using GroceryApp.Shared.Enumerations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace GroceryApp.Api.Data.Entities
{
    [Table(nameof(Order))]
    public class Order
    {
        [Key]
        public long Id { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Placed;
        public virtual ICollection<OrderItem> Orders { get; set ;}
        public virtual User User { get; set; }
    }
}
