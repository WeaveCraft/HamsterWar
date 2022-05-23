﻿using Blazored.LocalStorage;
using HamsterApp.Blazor.ServerUi.Providers;
using HamsterApp.Blazor.ServerUi.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;

namespace HamsterApp.Blazor.ServerUi.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthenticationService(IClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
            _authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            var response = await _httpClient.LoginAsync(loginModel);

            //Store Token
            await _localStorage.SetItemAsync("accessToken", response.Token);

            //Change auth state of app
            await ((ApiAuthenticationStateProvider)_authenticationStateProvider).LoggedIn();

            return true;
        }

        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)_authenticationStateProvider).LoggedOut();
        }
    }
}
