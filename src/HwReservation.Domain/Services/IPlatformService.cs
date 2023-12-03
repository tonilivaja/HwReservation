using HwReservation.Shared.DTOs;

namespace HwReservation.Domain.Services;

public interface IPlatformService
{
    Task<PlatformDto> GetAllAsync();
}
