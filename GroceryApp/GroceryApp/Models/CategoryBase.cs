namespace Models
{
    public class CategoryBase
    {
        public short Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public short? ParentId { get; set; }
    }
}