using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteka.Models  
{
    public class BookEntity //książki, główna encja
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }

        public int CategoryId { get; set; } //klucz obcy 
        public virtual ICollection<OrderEntity> Orders { get; set; } //relacja z wypożyczaniem
        [ValidateNever]
        public virtual CategoryEntity Category { get; set; } //właściwość nawigacyjna z kategorią

        

    }
}
