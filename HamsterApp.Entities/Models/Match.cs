using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterApp.Entities.Models
{
    public class Match
    {
        public int Id { get; set; }
        public int HamsterId { get; set; }
        public int GameId { get; set; }
        public string? WinStatus { get; set; }

        public virtual Game Game { get; set; } 
        public virtual Hamster Hamster { get; set; }
    }
}
