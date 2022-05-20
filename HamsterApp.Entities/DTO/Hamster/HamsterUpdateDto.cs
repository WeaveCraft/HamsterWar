﻿using System.ComponentModel.DataAnnotations;

namespace HamsterApp.Entities.DTO.Hamster
{
    public class HamsterUpdateDto : BaseDto
    {
        [Required]
        [StringLength(25)]
        public string? Name { get; set; }
        [Required]
        public int? Age { get; set; }
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
