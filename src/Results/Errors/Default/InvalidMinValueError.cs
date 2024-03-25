using IATec.Shared.Domain.Identifies.Contexts;
using IATec.Shared.Domain.Messages;
using IATec.Shared.Domain.Results.Errors.Base;

namespace IATec.Shared.Domain.Results.Errors.Default;

public class InvalidMinValueError(
    string entity,
    string fieldName,
    string fieldValue,
    double fieldValueMinLimit,
    ContextType type)
    : BadRequestFieldsError(DefaultErrorMessageKeys.InvalidMinValueMessageKey,
        type,
        entity,
        new Dictionary<string, object>
        {
            {fieldName, fieldValue},
            {$"{fieldName}.min-value", fieldValueMinLimit}
        });