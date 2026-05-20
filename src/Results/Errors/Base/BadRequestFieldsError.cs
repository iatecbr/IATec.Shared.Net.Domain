using FluentResults;
using IATec.Shared.Domain.Identifies.Contexts;

namespace IATec.Shared.Domain.Results.Errors.Base;

/// <summary>
/// Base class for errors related to bad request field validations.
/// </summary>
public class BadRequestFieldsError : Error
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BadRequestFieldsError"/> class with an empty field values dictionary.
    /// </summary>
    /// <param name="messageKey">The message key for the error.</param>
    /// <param name="type">The context type.</param>
    /// <param name="entityName">The name of the entity.</param>
    protected BadRequestFieldsError(string messageKey, ContextType type, string entityName)
        : this(messageKey, type, entityName, new Dictionary<string, object>())
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BadRequestFieldsError"/> class.
    /// </summary>
    /// <param name="messageKey">The message key for the error.</param>
    /// <param name="type">The context type.</param>
    /// <param name="entityName">The name of the entity.</param>
    /// <param name="valueParams">Dictionary of field values.</param>
    protected BadRequestFieldsError(string messageKey, ContextType type, string entityName,
        Dictionary<string, object> valueParams)
    {
        valueParams = TransformKeys(valueParams, type, entityName);
        Message = messageKey;
        Metadata.Add("entityName", $"api.{type.Value}.entity.{entityName}.entity-name".ToLowerInvariant());
        Metadata.Add("valueParams", valueParams);
    }

    /// <summary>
    /// Transforms the field keys into a standardized API format.
    /// </summary>
    /// <param name="valueParams">The dictionary of field values.</param>
    /// <param name="type">The context type.</param>
    /// <param name="entityName">The name of the entity.</param>
    /// <returns>A new dictionary with transformed keys.</returns>
    private static Dictionary<string, object> TransformKeys(Dictionary<string, object> valueParams, ContextType type, string entityName)
    {
        Dictionary<string, object> result = new();

        foreach (var item in valueParams)
            result.Add($"api.{type.Value}.entity.{entityName}.field.{item.Key}".ToLowerInvariant(), item.Value);

        return result;
    }
}
