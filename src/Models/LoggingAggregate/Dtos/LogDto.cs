namespace IATec.Shared.Domain.Models.LoggingAggregate.Dtos;

/// <summary>
/// Data transfer object representing a log entry.
/// </summary>
public record LogDto
{
    /// <summary>
    /// Gets the unique identifier of the log entry.
    /// </summary>
    public string? Id { get; init; }

    /// <summary>
    /// Gets the container key associated with the log entry.
    /// </summary>
    public required string ContainerKey { get; init; }

    /// <summary>
    /// Gets the source of the log entry.
    /// </summary>
    public required string Source { get; init; }

    /// <summary>
    /// Gets the owner associated with the log entry.
    /// </summary>
    public required string Owner { get; init; }

    /// <summary>
    /// Gets the action performed.
    /// </summary>
    public required string Action { get; init; }

    /// <summary>
    /// Gets the user identifier who performed the action.
    /// </summary>
    public string? UserId { get; init; }

    /// <summary>
    /// Gets the date and time when the log entry was created.
    /// </summary>
    public DateTime Date { get; init; }

    /// <summary>
    /// Gets the content of the log entry.
    /// </summary>
    public required string Content { get; init; }
}
