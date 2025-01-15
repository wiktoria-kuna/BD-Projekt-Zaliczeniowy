using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
namespace Biblioteka.Models
{
    public class OrderEntity //wypożyczanie książek
    {
        public int Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; } 

        //klucz obcy
        public int BookId { get; set; } //klucz obcy
        [ValidateNever]
        public BookEntity Book { get; set; } //Właściwość nawigacyjna
    }
}
