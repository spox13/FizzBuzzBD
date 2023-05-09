using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FizzBuzzBD.Forms
{
    public class FizzBuzzForm
    {
        [DisplayName("Rok")]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        [Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")]
        public int Year { get; set; }

        [DisplayName("Imię")]
        [MaxLength(100, ErrorMessage = "Wprowadź maksymalnie 100 znaków.")]
        public string? Name { get; set; }
        public string? Leap { get; set; }
    }
}
