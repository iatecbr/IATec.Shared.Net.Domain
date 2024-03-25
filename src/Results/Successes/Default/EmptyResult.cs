using FluentResults;
using IATec.Shared.Domain.Messages;

namespace IATec.Shared.Domain.Results.Successes.Default;

public class EmptyResult : Result
{
    public static Result GetResult()
    {
        return Ok().WithSuccess(StatusCodeMessageKeys.NoContentMessageKey);
    }
}