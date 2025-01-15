using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Biblioteka.Models
{
    public class CategoryEntity //kategoria książki
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
         
        //relacja z Books
        [ValidateNever]
        public virtual ICollection<BookEntity> Books { get; set; } //relacja z książką
    }
}
