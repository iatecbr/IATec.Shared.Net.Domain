using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Successes.Default;

/// <summary>
/// Represents an empty result with a no-content success message.
/// </summary>
public class EmptyResult : Result
{
    /// <summary>
    /// Gets a successful result with a no-content success message.
    /// </summary>
    /// <returns>A successful <see cref="Result"/> with no content.</returns>
    public static Result GetResult()
    {
        return Ok().WithSuccess(StatusCodeMessageKeys.NoContentMessageKey);
    }
}
