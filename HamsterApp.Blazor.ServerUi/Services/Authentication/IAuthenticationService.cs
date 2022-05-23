using Blazored.LocalStorage;
using HamsterApp.Blazor.ServerUi.Providers;
using HamsterApp.Blazor.ServerUi.Services.Base;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Components.Authorization;

namespace HamsterApp.Blazor.ServerUi.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
