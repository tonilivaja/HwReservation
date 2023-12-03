using HwReservation.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace HwReservation.Server.Controllers;

[ApiController, Route("[controller]")]
public class PlatformsController : ControllerBase
{
    private readonly IPlatformService _platformService;

    public PlatformsController(IPlatformService platformService)
    {
        _platformService = platformService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        Log.Debug("GET request for all platforms created.");

        var platforms = await _platformService.GetAllAsync();

        Log.Information("GET request for all platforms returned.");    

        return Ok();
    }
}
