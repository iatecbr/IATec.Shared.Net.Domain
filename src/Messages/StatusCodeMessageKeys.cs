namespace IATec.Shared.Domain.Messages;

/// <summary>
/// Provides status code message keys used throughout the application.
/// </summary>
public static class StatusCodeMessageKeys
{
    private const string InitialPath = "general.api.messages.status-code.";

    /// <summary>
    /// Message key for an internal server error status code.
    /// </summary>
    public const string InternalServerErrorMessageKey = $"{InitialPath}internal-server-error";

    /// <summary>
    /// Message key for a forbidden status code.
    /// </summary>
    public const string ForbiddenMessageKey = $"{InitialPath}forbidden";

    /// <summary>
    /// Message key for a not found status code.
    /// </summary>
    public const string NotFoundMessageKey = $"{InitialPath}not-found";

    /// <summary>
    /// Message key for a no content status code.
    /// </summary>
    public const string NoContentMessageKey = $"{InitialPath}no-content";

    /// <summary>
    /// Message key for a created status code.
    /// </summary>
    public const string CreatedMessageKey = $"{InitialPath}created";

    /// <summary>
    /// Message key for an external server error status code.
    /// </summary>
    public const string ExternalServerErrorMessageKey = $"{InitialPath}external-server-error";
}
