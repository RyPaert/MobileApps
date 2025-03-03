using GroceryApp.Models.Enumerations;

namespace Models
{
    public class Order
    {
        public long Id { get; set; }
        public IEnumerable<CartItem> Items { get; set; } = Enumerable.Empty<CartItem>();
        public DateTime Date { get; set; } = DateTime.Now;
        public decimal TotalAmount => Items.Sum(i => i.Amount);
        public OrderStatus Status { get; set; }

        public Color Color => _orderStatusColorMap[Status];

        private static readonly IReadOnlyDictionary<OrderStatus, Color> _orderStatusColorMap =
            new Dictionary<OrderStatus, Color>
            {
                [OrderStatus.Placed] = Colors.Yellow,
                [OrderStatus.Placed] = Colors.Blue,
                [OrderStatus.Placed] = Colors.Green,
                [OrderStatus.Placed] = Colors.Red
            };
    }
}
