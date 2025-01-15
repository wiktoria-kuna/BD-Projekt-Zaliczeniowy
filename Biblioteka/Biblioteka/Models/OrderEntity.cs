using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Biblioteka.Models
{
    public class OrderEntity //wypożyczanie książek
    {
        public int Id { get; set; }

        [Display(Name = "Data wypożyczenia")]
        public DateTime BorrowDate { get; set; }

        [Display(Name = "Data oddania")]
        public DateTime? ReturnDate { get; set; } 

        //klucz obcy
        public int BookId { get; set; } //klucz obcy
        [ValidateNever]
        [Display(Name = "Książka")]
        public BookEntity Book { get; set; } //Właściwość nawigacyjna
    }
}
