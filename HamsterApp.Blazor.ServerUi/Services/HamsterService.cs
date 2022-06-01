using AutoMapper;
using Blazored.LocalStorage;
using HamsterApp.Blazor.ServerUi.Services.Base;

namespace HamsterApp.Blazor.ServerUi.Services
{
    public class HamsterService : BaseHttpService, IHamsterService
    {
        private readonly IClient _client;
        private readonly IMapper _mapper;

        public HamsterService(IClient client, ILocalStorageService localStorage, IMapper mapper) : base(client, localStorage)
        {
            _client = client;
            _mapper = mapper;
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

        public async Task<Response<HamsterUpdateDto>> GetHamsterForUpdate(int id)
        {
            Response<HamsterUpdateDto> response;

            try
            {
                await GetBearerToken();
                var data = await _client.HamstersGETAsync(id);
                response = new Response<HamsterUpdateDto>
                {
                    Data = _mapper.Map<HamsterUpdateDto>(data),
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<HamsterUpdateDto>(ex);
            }
            return response;
        }


        public async Task<Response<HamsterReadOnlyDto>> GetHamster(int id)
        {
            Response<HamsterReadOnlyDto> response;

            try
            {
                await GetBearerToken();
                var data = await _client.HamstersGETAsync(id);
                response = new Response<HamsterReadOnlyDto>
                {
                    Data = data,
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<HamsterReadOnlyDto>(ex);
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
        public async Task<Response<List<HamsterDetailsDto>>> GetTwoHamsters()
        {
            Response<List<HamsterDetailsDto>> response;

            try
            {
                await GetBearerToken();
                var data = await _client.GetTwoRandomAsync();
                response = new Response<List<HamsterDetailsDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<List<HamsterDetailsDto>>(ex);
            }
            return response;
        }

        public async Task<Response<int>> UpdateHamster(int id, HamsterUpdateDto hamster)
        {
            Response<int> response = new Response<int> { Success = true };

            try
            {
                await GetBearerToken();
                await _client.HamstersPUTAsync(id, hamster);
            }
            catch (ApiException ex)
            {

                response = ConvertApiExceptions<int>(ex);
            }
            return response;
        }

        public async Task<Response<int>> DeleteHamster(int id)
        {
            Response<int> response = new Response<int> { Success = true };

            try
            {
                await GetBearerToken();
                await _client.HamstersDELETEAsync(id);
            }
            catch (ApiException ex)
            {

                response = ConvertApiExceptions<int>(ex);
            }
            return response;
        }

        public async Task<Response<List<HamsterDetailsDto>>> GetOneHamsters()
        {
            Response<List<HamsterDetailsDto>> response;

            try
            {
                await GetBearerToken();
                var data = await _client.GetOneRandomAsync();
                response = new Response<List<HamsterDetailsDto>>
                {
                    Data = data.ToList(),
                    Success = true
                };
            }
            catch (ApiException ex)
            {
                response = ConvertApiExceptions<List<HamsterDetailsDto>>(ex);
            }
            return response;
        }


    }
}
