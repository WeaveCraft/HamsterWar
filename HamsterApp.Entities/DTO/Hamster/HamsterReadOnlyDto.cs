﻿namespace HamsterApp.Entities.DTO.Hamster
{
    public class HamsterReadOnlyDto : BaseDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string FavFood { get; set; }
        public string Loves { get; set; }
        public string ImgName { get; set; }

    }
}
