using Blazored.LocalStorage;
using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Services
{
    public class HamsterService : BaseHttpService, IHamsterService
    {
        private readonly IClient _client;
        public HamsterService(IClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
        }

        public async Task<Response<List<HamsterReadOnlyDto>>> GetHamsters()
        {
            Response<List<HamsterReadOnlyDto>> response;

            try
            {
                await GetBearerToken();
                var data = await _client.HamstersAllAsync();
                response = new Response<List<HamsterReadOnlyDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<List<HamsterReadOnlyDto>>(ex);
            }
            return response;
        }
    }
}
