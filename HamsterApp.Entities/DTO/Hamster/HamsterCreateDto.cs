using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterApp.Entities.DTO.Hamster
{
    public class HamsterCreateDto
    {
        [Required]
        [StringLength(25)]
        public string? Name { get; set; }
        [Required]
        [Range(1, 3, ErrorMessage = "Only hamsters between the age of 1 to 3.")]
        public int Age { get; set; }
        [Required]
        [StringLength(50)]
        public string? FavFood { get; set; }
        [Required]
        [StringLength(50)]
        public string? Loves { get; set; }
        [Required]
        public string? ImgName { get; set; }
    }
}
