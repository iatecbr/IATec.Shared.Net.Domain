using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Successes.Default;

/// <summary>
/// Represents a success result indicating a no-content response.
/// </summary>
public class NoContentSuccess : Success
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NoContentSuccess"/> class.
    /// </summary>
    public NoContentSuccess()
    {
        Message = StatusCodeMessageKeys.NoContentMessageKey;
    }
}
