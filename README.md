# IATec.Shared.Net.Domain

A shared domain library for .NET projects developed at IATec. This package provides common building blocks for domain-driven design, including entities, results, errors, successes, logging models, contracts, and utility extensions used across multiple IATec applications.

## Installation

Install the package via NuGet:

```bash
dotnet add package IATec.Shared.Domain
```

Or via Package Manager:

```powershell
Install-Package IATec.Shared.Domain
```

## Requirements

- .NET 8.0, .NET 9.0, or .NET 10.0

## Dependencies

- [FluentResults](https://www.nuget.org/packages/FluentResults) (4.0.0)
- [FluentValidation](https://www.nuget.org/packages/FluentValidation) (12.1.1)
- [Ulid](https://www.nuget.org/packages/Ulid) (1.4.1)

## Project Structure

### SeedWorks
Base entity classes for domain models:

| Class | Description |
|-------|-------------|
| `Entity<T>` | Abstract base entity with a generic identifier type |
| `EntityInt32` | Entity with a 32-bit integer identifier |
| `EntityUlidInt32` | Entity with a 32-bit integer identifier and an external ULID |
| `EntityNullable` | Entity with a nullable string identifier |

### Results
Error and success result classes built on top of FluentResults:

#### Errors
| Class | Description |
|-------|-------------|
| `BadRequestFieldsError` | Base class for bad-request field validation errors |
| `ConflictError` | Error when a conflict occurs |
| `EmptyFieldError` | Error when a required field is empty |
| `EntityNotFoundError` | Error when an entity is not found |
| `InternalServerError` | Error for internal server failures |
| `InvalidFieldError` | Error when a field has an invalid value |
| `InvalidLengthError` | Error when a field value length is out of range |
| `InvalidMinValueError` | Error when a field value is below the minimum |
| `ResourceNotFoundError` | Error when a requested resource is not found |
| `ServiceUnavailableError` | Error when a service is unavailable |

#### Successes
| Class | Description |
|-------|-------------|
| `CreatedSuccess` | Success result for resource creation |
| `EmptyResult` | Success result with no content |
| `NoContentSuccess` | Success result for no-content responses |

### Contracts
Interfaces defining contracts for common services and patterns:

| Interface | Description |
|-----------|-------------|
| `IEntity` | Contract for domain entities |
| `ILogDispatcher` | Contract for dispatching log entries |
| `ILogService` | Contract for logging service implementation |
| `IValidatorGeneric` | Contract for generic validator provider |

### Models
Data transfer objects for logging:

| Class | Description |
|-------|-------------|
| `LogDto` | Log entry data transfer object |
| `LogCreateDto` | Data transfer object for creating a new log entry |

### Identifies
Type-safe identifiers for contexts and logging actions:

| Class | Description |
|-------|-------------|
| `BaseIdentify` | Abstract base class for identification types |
| `ContextType` | Context type for categorizing errors (Domain, Application) |
| `LogActionType` | Log action types (Added, Modified, Deleted) |

### Messages
Constants for error and status code message keys:

| Class | Description |
|-------|-------------|
| `DefaultErrorMessageKeys` | Default error message key constants |
| `StatusCodeMessageKeys` | Status code message key constants |

### Options
Configuration option classes:

| Class | Description |
|-------|-------------|
| `ContainerOption` | Configuration options for containers |
| `LogServiceOption` | Configuration options for the logging service |

### Extensions
Utility extension methods:

| Class | Description |
|-------|-------------|
| `EnumExtension` | Extension methods for enum operations |
| `IntExtension` | Extension methods for integer and date calculations |
| `ResultExtension` | Extension methods for FluentResults |
| `StringExtension` | Extension methods for string manipulation |

## Usage Examples

### Entity

```csharp
using IATec.Shared.Domain.SeedWorks;

public class Product : EntityInt32
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}
```

### Error Results

```csharp
using IATec.Shared.Domain.Results.Errors.Default;
using IATec.Shared.Domain.Identifies.Contexts;

var error = new EmptyFieldError("Product", "Name", ContextType.Domain);
```

### Success Results

```csharp
using IATec.Shared.Domain.Results.Successes.Default;

var success = new CreatedSuccess(123);
```

### Extensions

```csharp
using IATec.Shared.Domain.Extensions;

// String extensions
bool isValid = "hello".IsValid();
string appended = "root".AppendString("child"); // "root.child"

// Integer extensions
bool inRange = 5.IsBetween(1, 10);
int age = birthDate.GetAge();

// Result extensions
bool isCreated = result.IsCreatedSuccess();
bool isNotFound = result.IsResourceNotFoundError();
```

## License

Copyright © IATec Solutions. All rights reserved.

## Contributing

This library is maintained by the IATec | Solution | Platform Team. For issues or contributions, please visit the [GitHub repository](https://github.com/iatecbr/IATec.Shared.Net.Domain).
