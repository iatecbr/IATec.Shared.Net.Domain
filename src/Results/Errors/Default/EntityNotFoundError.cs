using IATec.Shared.Domain.Identifies.Contexts;
using IATec.Shared.Domain.Messages;
using IATec.Shared.Domain.Results.Errors.Base;

namespace IATec.Shared.Domain.Results.Errors.Default;

/// <summary>
/// Represents an error that occurs when an entity is not found.
/// </summary>
public class EntityNotFoundError(string entity)
    : BadRequestFieldsError(DefaultErrorMessageKeys.EmptyFieldMessageKey, ContextType.Domain, entity, new());
