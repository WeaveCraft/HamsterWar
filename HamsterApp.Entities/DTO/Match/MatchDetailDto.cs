using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterApp.Entities.DTO.Match
{
    public class MatchDetailDto
    {
        [Required]
        public int HamsterId { get; set; }
        public string HamsterName { get; set; }
        public int WinId { get; set; }
        public int LoseId { get; set; }
    }
}
