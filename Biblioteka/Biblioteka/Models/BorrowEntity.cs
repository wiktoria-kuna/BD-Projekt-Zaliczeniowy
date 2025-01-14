using System.ComponentModel;
namespace Biblioteka.Models
{
    public class BorrowEntity //wypożyczanie książek
    {
        public int Id { get; set; }     
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }
        public int BookId { get; set; }

        public ICollection<BookEntity> Books { get; set; }
    }
}
