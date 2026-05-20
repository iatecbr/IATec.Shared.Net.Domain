using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

/// <summary>
/// Represents an error indicating that a service is unavailable.
/// </summary>
public class ServiceUnavailableError : Error
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceUnavailableError"/> class.
    /// </summary>
    public ServiceUnavailableError()
    {
        Message = DefaultErrorMessageKeys.ServiceUnavailableMessageKey;
    }
}
