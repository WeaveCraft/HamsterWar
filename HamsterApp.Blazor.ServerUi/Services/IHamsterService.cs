using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Services
{
    public interface IHamsterService
    {
        Task<Response<List<HamsterReadOnlyDto>>> GetHamsters();
    }
}