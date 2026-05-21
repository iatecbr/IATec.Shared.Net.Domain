using IATec.Shared.Domain.Models.LoggingAggregate.Dtos;

namespace IATec.Shared.Domain.Contracts.Services.Logging;

/// <summary>
/// Defines the contract for a logging service.
/// </summary>
public interface ILogService
{
    /// <summary>
    /// Sends a log entry asynchronously.
    /// </summary>
    /// <param name="log">The log entry to send.</param>
    /// <param name="cancellationToken">Cancellation token for the operation.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task SendAsync(LogDto log, CancellationToken cancellationToken = default);
}
