using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Successes.Default;

/// <summary>
/// Represents a success result indicating that a resource was created.
/// </summary>
public class CreatedSuccess : Success
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreatedSuccess"/> class.
    /// </summary>
    /// <param name="resourceId">The unique identifier of the created resource.</param>
    public CreatedSuccess(int resourceId)
    {
        Metadata.Add("id", resourceId);
        Message = StatusCodeMessageKeys.CreatedMessageKey;
    }
}
