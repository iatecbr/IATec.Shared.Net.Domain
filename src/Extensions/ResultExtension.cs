using FluentResults;
using IATec.Shared.Domain.Messages;
using IATec.Shared.Domain.Results.Errors.Base;
using IATec.Shared.Domain.Results.Errors.Default;
using IATec.Shared.Domain.Results.Successes.Default;

namespace IATec.Shared.Domain.Extensions;

/// <summary>
/// Provides extension methods for FluentResults Result objects.
/// </summary>
public static class ResultExtension
{
    /// <summary>
    /// Determines whether the result contains a created success.
    /// </summary>
    /// <param name="result">The result to evaluate.</param>
    /// <returns>True if the result has a created success; otherwise, false.</returns>
    public static bool IsCreatedSuccess(this ResultBase result)
    {
        return result.HasSuccess<CreatedSuccess>();
    }

    /// <summary>
    /// Determines whether the result contains a no-content success.
    /// </summary>
    /// <param name="result">The result to evaluate.</param>
    /// <returns>True if the result has a no-content success; otherwise, false.</returns>
    public static bool IsNoContentSuccess(this ResultBase result)
    {
        return result.HasSuccess<NoContentSuccess>();
    }

    /// <summary>
    /// Determines whether the result is an empty result (null value or no-content success).
    /// </summary>
    /// <typeparam name="T">The type of the result value.</typeparam>
    /// <param name="result">The result to evaluate.</param>
    /// <returns>True if the result is empty; otherwise, false.</returns>
    public static bool IsEmptyResult<T>(this Result<T> result)
    {
        return result.IsSuccess
               && (result.Value is null
                   || result.HasSuccess(x => x.Message.Equals(StatusCodeMessageKeys.NoContentMessageKey)));
    }

    /// <summary>
    /// Determines whether the result contains a resource-not-found error.
    /// </summary>
    /// <param name="result">The result to evaluate.</param>
    /// <returns>True if the result has a resource-not-found error; otherwise, false.</returns>
    public static bool IsResourceNotFoundError(this ResultBase result)
    {
        return result.HasError<ResourceNotFoundError>();
    }

    /// <summary>
    /// Determines whether the result contains a bad-request error.
    /// </summary>
    /// <param name="result">The result to evaluate.</param>
    /// <returns>True if the result has a bad-request error; otherwise, false.</returns>
    public static bool IsBadRequestError(this ResultBase result)
    {
        return result.HasError<BadRequestFieldsError>();
    }

    /// <summary>
    /// Determines whether the result contains a service-unavailable error.
    /// </summary>
    /// <param name="result">The result to evaluate.</param>
    /// <returns>True if the result has a service-unavailable error; otherwise, false.</returns>
    public static bool IsServiceUnavailableError(this ResultBase result)
    {
        return result.HasError<ServiceUnavailableError>();
    }

    /// <summary>
    /// Determines whether the result contains an internal-server-error.
    /// </summary>
    /// <param name="result">The result to evaluate.</param>
    /// <returns>True if the result has an internal-server-error; otherwise, false.</returns>
    public static bool IsInternalServerError(this ResultBase result)
    {
        return result.HasError<InternalServerError>();
    }

    /// <summary>
    /// Determines whether the result contains a conflict error.
    /// </summary>
    /// <param name="result">The result to evaluate.</param>
    /// <returns>True if the result has a conflict error; otherwise, false.</returns>
    public static bool IsConflictError(this ResultBase result)
    {
        return result.HasError<ConflictError>();
    }
}
