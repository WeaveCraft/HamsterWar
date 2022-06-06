using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Services
{
    public interface IMatchService
    {
        Task<Response<int>> CreateMatch(MatchCreateDto hamster);

    }
}
