using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class CategoryEntity //kategoria książki
    {

        public int Id { get; set; }

        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }
         
        //relacja z Books
        [ValidateNever]
        public virtual ICollection<BookEntity> Books { get; set; } //relacja z książką
    }
}
