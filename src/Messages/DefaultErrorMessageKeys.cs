namespace IATec.Shared.Domain.Messages;

/// <summary>
/// Provides default error message keys used throughout the application.
/// </summary>
public static class DefaultErrorMessageKeys
{
    private const string InitialPath = "general.api.messages.";

    /// <summary>
    /// Message key for a record that cannot be deleted.
    /// </summary>
    public const string CannotBeDeletedErrorMessageKey = $"{InitialPath}record-cannot-be-deleted";

    /// <summary>
    /// Message key for an expired token.
    /// </summary>
    public const string ExpiredTokenMessageKey = $"{InitialPath}expired-token";

    /// <summary>
    /// Message key for an unactivated user.
    /// </summary>
    public const string UserUnactivatedMessageKey = $"{InitialPath}user-is-unactivated";

    /// <summary>
    /// Message key for an empty field.
    /// </summary>
    public const string EmptyFieldMessageKey = $"{InitialPath}empty-field";

    /// <summary>
    /// Message key for a record that already exists.
    /// </summary>
    public const string AlreadyExistsMessageKey = $"{InitialPath}record-already-exists";

    /// <summary>
    /// Message key for different identifiers.
    /// </summary>
    public const string DifferentIdentifiersMessageKey = $"{InitialPath}different-identifiers";

    /// <summary>
    /// Message key for a record that cannot be smaller.
    /// </summary>
    public const string CannotBeSmallerMessageKey = $"{InitialPath}record-cannot-be-smaller";

    /// <summary>
    /// Message key for a record that cannot be bigger.
    /// </summary>
    public const string CannotBeBiggerMessageKey = $"{InitialPath}record-cannot-be-bigger";

    /// <summary>
    /// Message key for a value that is empty or null.
    /// </summary>
    public const string ValueIsEmptyOrNullMessageKey = $"{InitialPath}value-is-empty-or-null";

    /// <summary>
    /// Message key for an invalid minimum value.
    /// </summary>
    public const string InvalidMinValueMessageKey = $"{InitialPath}invalid-min-value";

    /// <summary>
    /// Message key for an invalid range.
    /// </summary>
    public const string InvalidRangeMessageKey = $"{InitialPath}invalid-range";

    /// <summary>
    /// Message key for an invalid length.
    /// </summary>
    public const string InvalidLengthMessageKey = $"{InitialPath}invalid-length";

    /// <summary>
    /// Message key for invalid fields.
    /// </summary>
    public const string InvalidFieldsMessageKey = $"{InitialPath}invalid-fields";

    /// <summary>
    /// Message key for an invalid identifier.
    /// </summary>
    public const string InvalidIdMessageKey = $"{InitialPath}invalid-id";

    /// <summary>
    /// Message key for an invalid date.
    /// </summary>
    public const string InvalidDateMessageKey = $"{InitialPath}invalid-date";

    /// <summary>
    /// Message key for service unavailable.
    /// </summary>
    public const string ServiceUnavailableMessageKey = $"{InitialPath}service-unavailable";

    /// <summary>
    /// Message key for an internal server error.
    /// </summary>
    public const string InternalServerErrorMessageKey = $"{InitialPath}internal-server-error";
}
