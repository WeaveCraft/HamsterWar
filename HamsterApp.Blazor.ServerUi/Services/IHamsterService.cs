using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Services
{
    public interface IHamsterService
    {
        Task<Response<List<HamsterReadOnlyDto>>> GetHamsters();
        Task<Response<List<HamsterDetailsDto>>> GetTwoHamsters();
        Task<Response<HamsterReadOnlyDto>> GetHamster(int id);
        Task<Response<HamsterUpdateDto>> GetHamsterForUpdate(int id);
        Task<Response<int>> CreateHamster(HamsterCreateDto hamster);
        Task<Response<int>> UpdateHamster(int id, HamsterUpdateDto hamster);
        Task<Response<int>> DeleteHamster(int id);
    }
}