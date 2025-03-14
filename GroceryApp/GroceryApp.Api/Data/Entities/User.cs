using GroceryApp.Api.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryApp.Api.Data.Entities
{
    [Table(nameof(User))]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(30)]
        public string Name { get; set; }
        [Required, MaxLength(100)]
        public string Email { get; set; }
        [Required, MaxLength(20)]
        public string Mobile { get; set; }
        public short RoleId { get; set; }
        [Required, MaxLength(25)]
        public string Password { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public static IEnumerable<User> GetInitialUsers() =>
            new List<User>()
            {
                new User
                {
                    Id = 1,
                    Name = "Mihkel Marlon Sark",
                    Email = "thomashenrypaert@gmail.com",
                    Mobile = "12345678",
                    Password= "12345678",
                    RoleId = DatabaseConstants.Roles.Admin.Id
                },
                new User
                {
                    Id = 1,
                    Name = "Mihkel Marlon Sark",
                    Email = "thomashenrypaert@gmail.com",
                    Mobile = "12345678",
                    Password= "12345678",
                    RoleId = DatabaseConstants.Roles.Admin.Id
                }
            };
    }
}