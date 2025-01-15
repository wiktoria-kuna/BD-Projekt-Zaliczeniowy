using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka.Models  
{
    public class BookEntity //książki, główna encja
    {
        public int Id { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Display(Name = "Autor")]
        public string Author { get; set; }

        public int CategoryId { get; set; } //klucz obcy 
        [ValidateNever]
        public virtual ICollection<OrderEntity> Orders { get; set; } //relacja z wypożyczaniem
        [ValidateNever]
        [Display(Name = "Kategoria")]
        public virtual CategoryEntity Category { get; set; } //właściwość nawigacyjna z kategorią

    }
}
