# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

For project overview and usage examples, see the [README](README.md) .

## [2.0.1] - 2026-05-26

### FIXED
- Remove `required` modifier from log properties in `LogDto` and `LogCreateDto`.

## [2.0.0] - 2026-05-20

### BREAKING CHANGES
- `BadRequestFieldsError` constructor parameter `valueParams` changed from `Dictionary<string, object>?` (nullable) to `Dictionary<string, object>` (non-nullable). Code calling this constructor with an explicit `null` will fail to compile.
- Removed nullable collection (`Dictionary?`) definitions in favor of initializing empty collections.

### ADDED
- Added comprehensive XML documentation summaries to all public classes, methods, properties, and interfaces.
- Added a new overload of `BadRequestFieldsError` without a dictionary parameter, defaulting to an empty collection.

### CHANGED
- `EntityNotFoundError` now explicitly passes an empty dictionary to the base constructor.

### FIXED
- `HasMinWords` now correctly ignores empty entries caused by multiple spaces.
- `GetLongOrDefault` now uses `long.TryParse` to safely return 0 for invalid or non-numeric inputs instead of throwing `FormatException`.
- Fixed malformed XML documentation tags (`<see cref="Result{T}"/>`) in `StringExtension` methods.
- Fixed incorrect constructor summary in `BadRequestFieldsError` overload.

## [1.2.0] - 2026-01-09

### CHANGED
- Updated package versions.

## [1.1.0] - 2025-10-22

### ADDED
- Added `ContainerId` property to `ContainerOption`.

## [1.0.0] - 2025-08-11

### CHANGED
- Changed `InternalServerError` class from `class` to `sealed`.
- Updated package version to 1.0.0.

### ADDED
- Added internal server error option with custom message support.

## [0.9.1] - 2025-02-04

### CHANGED
- Enhanced property name processing in `EnumExtension`.

## [0.9.0] - 2025-01-03

### ADDED
- Added `InvalidFieldError` for invalid field result errors.

## [0.8.0] - 2024-11-18

### CHANGED
- Updated `AppendString` method separator from `-` to `.`.

## [0.7.0] - 2024-10-28

### ADDED
- Added `EntityUlidInt32` class with external ULID support.
- Added `Ulid` package dependency.

### CHANGED
- Renamed `SecondId` property to `ExternalId` in `EntityUlidInt32`.

## [0.6.0] - 2024-09-23

### ADDED
- Added `LogCreateDto` for creating log entries.
- Added `AppendString` string extension method.

### CHANGED
- Refactored `LogDto` structure and properties.
- Improved `LogDto` data transfer object.

### FIXED
- Fixed NuGet package packing issues.
- Fixed message keys for unavailable services.

## [0.5.0] - 2024-09-10

### ADDED
- Added `ServiceUnavailableError` for service unavailability scenarios.
- Added new entity type `EntityNullable`.

### FIXED
- Fixed NuGet package packing configuration.

## [0.4.0] - 2024-05-02

### ADDED
- Added `EntityNotFoundError` for entity lookup failures.
- Added `IValidatorGeneric` contract for generic validation.

## [0.3.0] - 2024-03-25

### ADDED
- Added `EntityInt32` entity type.
- Added `ResultExtension` methods for FluentResults.
- Added `StringExtension` utility methods.
- Added `IntExtension` utility methods.
- Added `EnumExtension` utility methods.
- Added `DefaultErrorMessageKeys` constants.
- Added `StatusCodeMessageKeys` constants.
- Added `ContextType` and `LogActionType` identifiers.
- Added `LogDto` and logging contracts.
- Added `ContainerOption` and `LogServiceOption` configuration options.
- Added `BadRequestFieldsError` base error class.
- Added `EmptyFieldError`, `InvalidLengthError`, `InvalidMinValueError` errors.
- Added `CreatedSuccess`, `NoContentSuccess`, `EmptyResult` success classes.
- Added `ResourceNotFoundError` and `InternalServerError` errors.

### CHANGED
- Moved shared domain classes from other libraries to this project.
- Improved CI/CD pipeline configuration.

## [0.1.0] - 2024-03-25

### ADDED
- Initial project setup and folder structure.
- Created base `Entity<T>` abstract class.
- Added `IEntity` contract interface.
