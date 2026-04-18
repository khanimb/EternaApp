namespace EternaApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        public int CategoriesId { get; set; }
        public Categories Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }

    }
}
