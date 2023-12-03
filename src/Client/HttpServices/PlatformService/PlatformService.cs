using HwReservation.Shared.DTOs;
using System.Net.Http.Json;

namespace HwReservation.Client.HttpServices;

public class PlatformService : IPlatformService
{
    private readonly HttpClient _httpClient;

    public PlatformService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<PlatformDto>> GetAllPlatforms()
    {
        return await _httpClient.GetFromJsonAsync<List<PlatformDto>>("/platforms");
    }
}
