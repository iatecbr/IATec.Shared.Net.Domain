using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

/// <summary>
/// Represents an error indicating that a request could not be completed due to a conflict with the current state of the resource.
/// </summary>
public class ConflictError : Error
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConflictError"/> class.
    /// </summary>
    public ConflictError()
    {
        Message = StatusCodeMessageKeys.ConflictMessageKey;
    }
}
