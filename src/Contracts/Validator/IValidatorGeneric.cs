using FluentValidation;

namespace IATec.Shared.Domain.Contracts.Validator;

public interface IValidatorGeneric
{
    IValidator<T>? GetValidator<T>();
}