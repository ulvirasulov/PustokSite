namespace Pustok.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Author { get; set; }
        public string ImgUrl { get; set; }
        public int BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }


    }
}
