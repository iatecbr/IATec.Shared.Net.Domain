using IATec.Shared.Domain.Identifies.Contexts;
using IATec.Shared.Domain.Messages;
using IATec.Shared.Domain.Results.Errors.Base;

namespace IATec.Shared.Domain.Results.Errors.Default;

public class InvalidLengthError(
    string entity,
    string fieldName,
    string fieldValue,
    double fieldLengthMinLimit,
    double fieldLengthMaxLimit,
    ContextType type) : BadRequestFieldsError(DefaultErrorMessageKeys.InvalidLengthMessageKey,
    type,
    entity,
    new Dictionary<string, object>
    {
        {fieldName, fieldValue},
        {$"{fieldName}.min-value", fieldLengthMinLimit},
        {$"{fieldName}.max-value", fieldLengthMaxLimit}
    });