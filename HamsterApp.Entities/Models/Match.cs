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
        public Hamster? Hamster { get; set; }
        public Game? Game { get; set; }
        public string WinStatus { get; set; } = string.Empty;
    }
}
