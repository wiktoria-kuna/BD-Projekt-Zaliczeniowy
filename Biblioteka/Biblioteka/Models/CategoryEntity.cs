namespace Biblioteka.Models
{
    public class CategoryEntity //kategoria książki
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<BookEntity> Books { get; set; }
    }
}
