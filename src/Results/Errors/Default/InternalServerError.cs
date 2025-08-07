using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

public class InternalServerError : Error
{
    public InternalServerError()
    {
        Message = DefaultErrorMessageKeys.InternalServerErrorMessageKey;
    }
}