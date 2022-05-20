using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterApp.Entities.Models
{
    public class Game
    {
        public Game()
        {
            Matches = new HashSet<Match>();
        }

        public int Id { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
}
