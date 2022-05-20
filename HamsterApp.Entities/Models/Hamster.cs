using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HamsterApp.Entities.Models
{
    public class Hamster
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? FavFood { get; set; }
        public string? Loves { get; set; }
        public string? ImgName { get; set; }
        public int? Wins { get; set; } = 0;
        public int? Losses { get; set; } = 0;
        public int? Games { get; set; } = 0;


    }
}
