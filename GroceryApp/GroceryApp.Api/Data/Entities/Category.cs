using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroceryApp.Api.Data.Entities
{
    [Table(nameof(Category))]
    public class Category
    {
        [Key]
        public short Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required, MaxLength(150)]
        public string Image { get; set; }
        public short? ParentId { get; set; }
        [MaxLength(150)]
        public string? Credit { get; set; }

        public bool IsMainCategory => ParentId == 0;

        public Category(short id, string name, short parentId, string image, string credit) : this()
        {
            Id = id;
            Name = name;
            Image = image;
            ParentId = parentId;
            Credit = credit;
        }

        public Category()
        {

        }

        public static IEnumerable<Category> GetInitialData()
        {
                var categories = new List<Category>();

                var fruits = new List<Category>
            {
                new (1, "Fruits", 0, "fruits.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/2/2f/Culinary_fruits_front_view.jpg"),
                new (2, "Seasonal Fruits", 0, "seasonal_fruits.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/3/35/Fruit_Platter-_Seasonal_Fruits.jpg"),
                new (3, "Exotic Fruits", 0, "exotic_fruits.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/1/18/ARS_tropical_fruit_no_labels.jpg/220px-ARS_tropical_fruit_no_labels.jpg"),
            };
                categories.AddRange(fruits);

                var vegetables = new List<Category>
            {
                new (4, "Vegetables", 0, "vegetables.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/Marketvegetables.jpg/1024px-Marketvegetables.jpg"),
                new (5, "Green Vegetables", 4, "green_vegetables.jpg", "Photo from <a href=\"https://birlahealthcare.com/wp-content/uploads/2022/02/Importance-of-Green-Vegetables.jpg"),
                new (6, "Leafy Vegetables", 4, "leafy_vegetables.jpg", "Photo from <a href=\"https://images.squarespace-cdn.com/content/v1/5dbec0afbde55b468ed1229e/1600444506112-A5NPINZS6Y4KKEEDP3JK/leafy-greens-for-dogs.jpg"),
                new (7, "Salads", 4, "salads.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/a/a8/Salad_platter02_crop.jpg/1280px-Salad_platter02_crop.jpg"),
            };
                categories.AddRange(vegetables);

                var dairy = new List<Category>
            {
                new (8, "Dairy", 0, "dairy.jpg", "Photo from <a href=\"https://domf5oio6qrcr.cloudfront.net/medialibrary/9685/iStock-544807136.jpg"),
                new (9, "Milk, Curd & Yogurts", 8, "milk.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/a/a5/Glass_of_Milk_%2833657535532%29.jpg"),
                new (10, "Butter & Cheese", 8, "Cheese.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/a/a8/Cheese_platter.jpg"),
            };
                categories.AddRange(dairy);

                var eggsMeat = new List<Category>
            {
                new (11, "Eggs & Steaks", 0, "steakeggs.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/2/24/Marketvegetables.jpg/1024px-Marketvegetables.jpg"),
                new (12, "Eggs", 11, "egg.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/f/f0/Fried_Egg_2.jpg/220px-Fried_Egg_2.jpg"),
                new (13, "Meat", 11, "meat.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/FoodMeat.jpg/1280px-FoodMeat.jpg"),
                new (14, "Seafood", 11, "seafood.jpg", "Photo from <a href=\"https://upload.wikimedia.org/wikipedia/commons/thumb/a/ae/Plateau_van_zeevruchten.jpg/1280px-Plateau_van_zeevruchten.jpg"),
            };
                categories.AddRange(eggsMeat);
            return categories;
            }
        }
}
