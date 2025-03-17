namespace AutoDispatcher.Application.Contracts.Driver;
/// <summary>
/// Dto для создания или изменения водителя
/// </summary>
public record DriverCreateUpdateDto(string? FullName, string? PassportNumber, string? DriverLicenseNumber, string? Address, string? PhoneNumber);