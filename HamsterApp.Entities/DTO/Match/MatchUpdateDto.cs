using System.ComponentModel.DataAnnotations;

namespace HamsterApp.Entities.DTO.Match
{
    public class MatchUpdateDto : BaseDto
    {
        [Required]
        public int HamsterId { get; set; }
        public int WinId { get; set; }
        public int LoseId { get; set; }
    }
}
