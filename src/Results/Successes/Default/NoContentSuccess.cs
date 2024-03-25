using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Successes.Default;

public class NoContentSuccess : Success
{
    public NoContentSuccess()
    {
        Message = StatusCodeMessageKeys.NoContentMessageKey;
    }
}