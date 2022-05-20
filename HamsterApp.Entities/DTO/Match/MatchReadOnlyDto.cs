namespace HamsterApp.Entities.DTO.Match
{
    public class MatchReadOnlyDto : BaseDto
    {
        public string HamsterId { get; set; }
        public string HamsterName { get; set; }
        public int WinId { get; set; }
        public int LoseId { get; set; }
    }
}
