using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Errors.Default;

public sealed class InternalServerError(
    string? message = null) : Error(message ?? DefaultErrorMessageKeys.InternalServerErrorMessageKey)
{ }