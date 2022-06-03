using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Services
{
    public interface IHamsterService
    {
        Task<Response<List<HamsterReadOnlyDto>>> GetHamsters();
        Task<Response<List<HamsterDetailsDto>>> GetTwoHamsters();
        Task<Response<List<HamsterDetailsDto>>> GetOneHamsters();
        Task<Response<List<HamsterReadOnlyDto>>> FiveWinners();
        Task<Response<List<HamsterReadOnlyDto>>> FiveLosers();
        Task<Response<HamsterReadOnlyDto>> GetHamster(int id);
        Task<Response<HamsterUpdateDto>> GetHamsterForUpdate(int id);
        Task<Response<int>> CreateHamster(HamsterCreateDto hamster);
        Task<Response<int>> UpdateHamster(int id, HamsterUpdateDto hamster);
        Task<Response<int>> DeleteHamster(int id);
        Task<Response<int>> Wins(int id);
        Task<Response<int>> Losses(int id);


        Task<Response<int>> CreateMatch(MatchCreateDto match);
    }
}