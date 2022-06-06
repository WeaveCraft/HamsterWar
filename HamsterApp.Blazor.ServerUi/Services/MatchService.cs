using AutoMapper;
using Blazored.LocalStorage;
using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Services
{
    public class MatchService : BaseHttpService, IMatchService
    {
        public IClient _client { get; set; }
        public IMapper _mapper { get; }

        public MatchService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            _client = client;
            _mapper = mapper;
        }

        

        public async Task<Response<int>> CreateMatch(MatchCreateDto match)
        {
            Response<int> response = new Response<int> { Success = true };

            try
            {
                await GetBearerToken();
                await _client.MatchesPOSTAsync(match);
            }
            catch (ApiException ex)
            {

                response = ConvertApiExceptions<int>(ex);
            }
            return response;
        }
    }
}
