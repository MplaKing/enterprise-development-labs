namespace AutoDispatcher.Application.Contracts.Route;
/// <summary>
/// Dto для создания или изменения маршрута
/// </summary>
public record RouteCreateUpdateDto(string? RouteNumber, string? Description);