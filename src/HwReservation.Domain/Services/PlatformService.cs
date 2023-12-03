using HwReservation.Domain.Entities;
using HwReservation.Domain.Repositories;
using HwReservation.Shared.DTOs;

namespace HwReservation.Domain.Services;

public class PlatformService : IPlatformService
{
    private readonly IRepository<Platform> _repository;

    public Task<PlatformDto> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
