using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;
using CommunityToolkit.Mvvm.ComponentModel;

namespace GroceryApp.Shared.Dtos
{
    public partial class ProductDto : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ObservableProperty]
        private string? _image;
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public short CategoryId { get; set; }
        
        [ObservableProperty]
        private int _cartQuantity => Random.Shared.Next(0, 3);

        //public int CartQuantity => Random.Shared.Next(0, 3);

        public ProductDto(int id, string name, string image, decimal price, string unit, short categoryId)
        {
            Id = id;
            Name = name;
            Image = image;
            Price = price;
            Unit = unit;
            CategoryId = categoryId;
        }
    }
}
