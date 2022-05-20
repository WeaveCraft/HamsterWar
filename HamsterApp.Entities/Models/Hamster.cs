﻿using System.ComponentModel.DataAnnotations;

namespace HamsterApp.Entities.Models
{
    public class Hamster
    {
        public Hamster()
        {
            Matches = new HashSet<Match>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? FavFood { get; set; }
        public string? Loves { get; set; }
        public string? ImgName { get; set; }
        public int? Wins { get; set; }
        public int? Losses { get; set; }
        public int? Games { get; set; }

        public virtual ICollection<Match> Matches { get; set; }
    }
}
