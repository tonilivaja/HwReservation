using HwReservation.Shared.DTOs;

namespace HwReservation.Client.HttpServices;

public interface IPlatformService
{
    Task<List<PlatformDto>> GetAllPlatforms();
}
