using HwReservation.Domain.Enums;

namespace HwReservation.Domain.Entities;

public class Platform : BaseEntity
{
    public string IpAddress { get; set; }
    public PlatformType Type { get; set; }
    public PlatformStatus Status { get; set; }
}
