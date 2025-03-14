using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApp.Shared.Enumerations
{
    public enum OrderStatus
    {
        Placed = 0,
        Confirmed = 1,
        Delivered = 2,
        Cancelled = 3
    }
}
