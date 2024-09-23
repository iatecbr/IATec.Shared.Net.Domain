namespace IATec.Shared.Domain.Models.LoggingAggregate.Dtos;

public record LogCreateDto(
    string ContainerKey,
    string Source,
    string Owner,
    string Action,
    string UserId,
    string? Content = null);