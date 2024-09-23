using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

public class ServiceUnavailableError : Error
{
    public ServiceUnavailableError()
    {
        Message = DefaultErrorMessageKeys.ServiceUnavailableMessageKey;
    }
}