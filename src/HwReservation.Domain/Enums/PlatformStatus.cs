namespace HwReservation.Domain.Enums;

public enum PlatformStatus
{
    Free = 0,
    TakenByUser = 1,
    TakenForSmokeTests = 2,
    TakenForRegressionRun = 3
}
