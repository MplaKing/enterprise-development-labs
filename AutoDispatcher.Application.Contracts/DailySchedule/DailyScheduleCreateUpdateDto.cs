namespace AutoDispatcher.Application.Contracts.DailySchedule;
/// <summary>
/// Dto для создания или изменения связи авто, водителя и маршрута
/// </summary>
public record DailyScheduleCreateUpdateDto(int TransportVehicleId, int DriverId, int RouteId, DateTime StartTime, DateTime EndTime);
