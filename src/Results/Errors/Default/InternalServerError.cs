using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

/// <summary>
/// Represents an error indicating an internal server error has occurred.
/// </summary>
public sealed class InternalServerError(
    string? message = null) : Error(message ?? DefaultErrorMessageKeys.InternalServerErrorMessageKey)
{
}
