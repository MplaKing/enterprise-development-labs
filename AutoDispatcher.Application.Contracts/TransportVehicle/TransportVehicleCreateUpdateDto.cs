namespace AutoDispatcher.Application.Contracts.TransportVehicle;
/// <summary>
/// Dto для создания или изменения авто
/// </summary>
public record TransportVehicleCreateUpdateDto(string? LicensePlate, string? VehicleType, string? ModelName, int? MaxCapacity, int? YearOfManufacture);
