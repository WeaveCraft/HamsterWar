using System.ComponentModel.DataAnnotations;

namespace HamsterApp.Entities.Models
{
    public class Hamster
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter a name!")]
        [MinLength(2, ErrorMessage = "Enter a name!")]
        public string? Name { get; set; }

        [Range(1, 5, ErrorMessage = "Age must be between 1 and 5.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter favourite food!")]
        [MinLength(3, ErrorMessage = "Enter favourite food!")]
        public string? FavFood { get; set; }

        [Required(ErrorMessage = "Enter favourite thing!")]
        [MinLength(3, ErrorMessage = "Enter favourite thing!")]
        public string? FavThing { get; set; }
        public string? ImgName { get; set; }
        public int Wins { get; set; } = 0;
        public int Losses { get; set; } = 0;
        public int Games { get; set; } = 0;
    }
}
