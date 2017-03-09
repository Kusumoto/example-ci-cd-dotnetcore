using System.ComponentModel.DataAnnotations;

namespace FizzBuzz.ViewModels
{
    public class FizzBuzzCriteriaViewModel
    {
        [Required(ErrorMessage = "InputNumber is required.")]
        public int InputNumber { get; set; }

        public string Result { get; set; }
    }
}
