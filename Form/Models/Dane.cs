using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj imie")]
        [MinLength(2, ErrorMessage = "Imie musi byc dluzsze niz 2 znaki")]
        public string Imie { get; set; }
        [Required(ErrorMessage = "Prosze podaj nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi byc dluzsze niz 2 znaki")]
        public string Nazwisko { get; set; }
        [Required(ErrorMessage = "Prosze podaj email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Prosze podaj adres email w prawidlowym formacie przyklad: *@*.*")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Prosze podaj haslo")]
        [DataType(DataType.Password, ErrorMessage = "Podany format jest nieprawidlowy")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)[a-zA-Z\\d]{8,}$", ErrorMessage = "Prosze podaj haslo w formacie: 1 wielka litera, 1 mala litera, 1 cyfra, minimum 8 znakow")]
        public string Haslo { get; set; }
        [Required(ErrorMessage = "Hasla nie sa takie same")]
        [DataType(DataType.Password, ErrorMessage = "Podany format jest nieprawidłowy")]
        [Compare(nameof(Haslo))]
        public string Podtwierdz_Haslo { get; set; }
        [Required(ErrorMessage = "Prosze podaj temat")]
        [Phone(ErrorMessage = "Podany format numeru telefonu jest nieprawidlowy")]
        public string Numer_Telefonu { get; set; }
        [Required(ErrorMessage = "Prosze podaj numer telefonu")]
        public int Wiek { get; set; }
        [Required(ErrorMessage = "Prosze podaj miasto")]
        public string Miasto { get; set; }

    }
}
