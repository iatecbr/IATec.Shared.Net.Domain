using FluentValidation;

namespace IATec.Shared.Domain.Contracts.Validator;

/// <summary>
/// Defines a generic validator provider contract.
/// </summary>
public interface IValidatorGeneric
{
    /// <summary>
    /// Gets the validator for the specified type.
    /// </summary>
    /// <typeparam name="T">The type to validate.</typeparam>
    /// <returns>The validator instance, or null if not found.</returns>
    IValidator<T>? GetValidator<T>();
}
