using IATec.Shared.Domain.Identifies.Contexts;
using IATec.Shared.Domain.Messages;
using IATec.Shared.Domain.Results.Errors.Base;

namespace IATec.Shared.Domain.Results.Errors.Default;

public class EmptyFieldError(string entity, string fieldName, ContextType type)
    : BadRequestFieldsError(DefaultErrorMessageKeys.EmptyFieldMessageKey, type, entity,
        new Dictionary<string, object> {{fieldName, string.Empty}});