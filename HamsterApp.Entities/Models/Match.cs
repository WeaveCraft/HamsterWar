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
        public int WinId { get; set; }
        public int LoseId { get; set; }
        public int HamsterId { get; set; }
        public virtual Hamster? Hamster { get; set; }
    }
}
