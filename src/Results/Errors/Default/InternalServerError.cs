using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

public sealed class InternalServerError : Error
{
    public InternalServerError(string? message = null) : base(message ?? DefaultErrorMessageKeys.InternalServerErrorMessageKey) { }
}