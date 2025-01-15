using System.ComponentModel.DataAnnotations;

namespace Biblioteka.Models
{
    public class MemberEntity //lista pracowników
    {
        public int Id { get; set; }

        [Display(Name = "Imię")]
        public string FirstName { get; set; }

        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Display(Name = "Numer telefony")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Adres email")]
        public string Email { get; set; }
    }
}
