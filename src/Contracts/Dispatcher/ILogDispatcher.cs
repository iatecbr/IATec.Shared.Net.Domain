namespace IATec.Shared.Domain.Contracts.Dispatcher;

/// <summary>
/// Defines the contract for dispatching log entries.
/// </summary>
public interface ILogDispatcher
{
    /// <summary>
    /// Dispatches a log entry asynchronously.
    /// </summary>
    /// <param name="source">The source of the log entry.</param>
    /// <param name="owner">The owner associated with the log entry.</param>
    /// <param name="action">The action performed.</param>
    /// <param name="content">Optional content for the log entry.</param>
    /// <param name="cancellationToken">Cancellation token for the operation.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DispatchAsync(
        string source,
        string owner,
        string action,
        object? content = null,
        CancellationToken cancellationToken = default
    );
}
