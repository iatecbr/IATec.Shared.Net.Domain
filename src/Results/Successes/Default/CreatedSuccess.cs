using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Successes.Default;

public class CreatedSuccess : Success
{
    public CreatedSuccess(int resourceId)
    {
        Metadata.Add("id", resourceId);
        Message = StatusCodeMessageKeys.CreatedMessageKey;
    }
}