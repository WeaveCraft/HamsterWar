using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
