namespace AutoDispatcher.Application.Contracts.DailySchedule;
/// <summary>
/// Dto для просмотра сведений о связи авто, водителя и маршрута
/// </summary>
public record DailyScheduleDto(int Id, int TransportVehicleId, int DriverId, int RouteId, DateTime StartTime, DateTime EndTime);
