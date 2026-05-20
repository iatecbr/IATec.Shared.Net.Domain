using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

/// <summary>
/// Represents an error indicating that a requested resource was not found.
/// </summary>
public class ResourceNotFoundError : Error
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ResourceNotFoundError"/> class.
    /// </summary>
    public ResourceNotFoundError()
    {
        Message = StatusCodeMessageKeys.NotFoundMessageKey;
    }
}
