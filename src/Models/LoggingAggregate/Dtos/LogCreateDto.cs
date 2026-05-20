namespace IATec.Shared.Domain.Models.LoggingAggregate.Dtos;

/// <summary>
/// Data transfer object for creating a new log entry.
/// </summary>
/// <param name="ContainerKey">The container key associated with the log entry.</param>
/// <param name="Source">The source of the log entry.</param>
/// <param name="Owner">The owner associated with the log entry.</param>
/// <param name="Action">The action performed.</param>
/// <param name="UserId">The user identifier who performed the action.</param>
/// <param name="Content">Optional content of the log entry.</param>
public record LogCreateDto(
    string ContainerKey,
    string Source,
    string Owner,
    string Action,
    string UserId,
    string? Content = null);
