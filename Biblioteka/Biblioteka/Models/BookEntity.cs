using System.ComponentModel;

namespace Biblioteka.Models
{
    public class BookEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public int CategoryId { get; set; }

        public CategoryEntity Category { get; set; }
    }
}
