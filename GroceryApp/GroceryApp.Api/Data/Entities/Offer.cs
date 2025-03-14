using System.ComponentModel.DataAnnotations;

namespace GroceryApp.Api.Data.Entities
{
    public class Offer
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(150)]
        public string Title { get; set; }
        [Required, MaxLength(250)]
        public string Description { get; set; }
        [Required, MaxLength(10)]
        public string Code { get; set; }
        public string BgColor { get; set; }
    }
}
