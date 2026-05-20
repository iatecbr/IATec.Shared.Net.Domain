using IATec.Shared.Domain.Identifies.Contexts;
using IATec.Shared.Domain.Messages;
using IATec.Shared.Domain.Results.Errors.Base;

namespace IATec.Shared.Domain.Results.Errors.Default;

/// <summary>
/// Represents an error that occurs when a field has an invalid value.
/// </summary>
public class InvalidFieldError(
    string entity,
    string fieldName,
    string fieldValue,
    ContextType type) : BadRequestFieldsError(
    DefaultErrorMessageKeys.InvalidFieldsMessageKey,
    type,
    entity,
    new Dictionary<string, object> { { fieldName, fieldValue } }
);
