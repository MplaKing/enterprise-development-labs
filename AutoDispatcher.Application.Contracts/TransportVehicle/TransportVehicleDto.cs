namespace AutoDispatcher.Application.Contracts.TransportVehicle;
/// <summary>
/// Dto для просмотра сведений об авто
/// </summary>
public record TransportVehicleDto(int Id, string? LicensePlate, string? VehicleType, string? ModelName, int? MaxCapacity, int? YearOfManufacture);
