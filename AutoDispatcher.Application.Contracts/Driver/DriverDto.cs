namespace AutoDispatcher.Application.Contracts.Driver;
/// <summary>
/// Dto для просмотра сведений о водителе
/// </summary>
public record DriverDto(int Id, string? FullName, string? PassportNumber, string? DriverLicenseNumber, string? Address, string? PhoneNumber);
