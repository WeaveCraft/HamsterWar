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

        public async Task<Response<int>> CreateHamster(HamsterCreateDto hamster)
        {
            Response<int> response = new Response<int> {  Success = true };

            try
            {
                await GetBearerToken();
                await _client.HamstersPOSTAsync(hamster);
            }
            catch (ApiException ex)
            {

                response = ConvertApiExceptions<int>(ex);
            }
            return response;
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
