using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

public class ResourceNotFoundError : Error
{
    public ResourceNotFoundError()
    {
        Message = StatusCodeMessageKeys.NotFoundMessageKey;
    }
}