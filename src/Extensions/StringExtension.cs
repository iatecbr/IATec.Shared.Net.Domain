using System.Globalization;
using FluentResults;

namespace IATec.Shared.Domain.Extensions;

/// <summary>
/// Provides extension methods for string operations.
/// </summary>
public static class StringExtension
{
    /// <summary>
    /// Appends a string to the current string separated by a dot and converts to lowercase.
    /// </summary>
    /// <param name="stringRoot">The base string.</param>
    /// <param name="stringToAppend">The string to append.</param>
    /// <returns>The concatenated string in lowercase.</returns>
    public static string AppendString(this string stringRoot, string stringToAppend)
    {
        return $"{stringRoot}.{stringToAppend}".ToLower();
    }

    /// <summary>
    /// Determines whether the string has at least a minimum number of words.
    /// </summary>
    /// <param name="value">The string to evaluate.</param>
    /// <param name="min">The minimum number of words required.</param>
    /// <returns>True if the string has at least the minimum number of words; otherwise, false.</returns>
    public static bool HasMinhWords(this string value, int min)
    {
        var items = value.Split(" ");
        return items.Length >= min;
    }

    /// <summary>
    /// Determines whether the string has a non-whitespace value.
    /// </summary>
    /// <param name="value">The string to evaluate.</param>
    /// <returns>True if the string is not null or whitespace; otherwise, false.</returns>
    public static bool HasValue(this string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }

    /// <summary>
    /// Converts the string to a long value, returning 0 if the string is null or empty.
    /// </summary>
    /// <param name="value">The string to convert.</param>
    /// <returns>The parsed long value, or 0 if parsing fails.</returns>
    public static long GetLongOrDefault(this string? value)
    {
        return !value.HasValue() ? 0 : long.Parse(value!);
    }

    /// <summary>
    /// Converts the string to camel case.
    /// </summary>
    /// <param name="str">The string to convert.</param>
    /// <param name="firstUpper">If true, makes the first character lowercase.</param>
    /// <returns>The string in camel case format.</returns>
    public static string ToCamelCase(this string str, bool firstUpper = false)
    {
        var cultInfo = new CultureInfo("en-US", false).TextInfo;

        str = cultInfo.ToTitleCase(str);
        str = str.Replace(" ", "");

        if (firstUpper) str = char.ToLower(str[0]) + str[1..];

        return str;
    }

    /// <summary>
    /// Determines whether the string is valid (not null or whitespace).
    /// </summary>
    /// <param name="value">The string to evaluate.</param>
    /// <returns>True if the string is valid; otherwise, false.</returns>
    public static bool IsValid(this string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }

    /// <summary>
    /// Validates the string and returns a FluentResults boolean.
    /// </summary>
    /// <param name="value">The string to evaluate.</param>
    /// <returns>A <see cref="Result{T}"/> of bool indicating validity.</returns>
    public static Result<bool> IsValidResult(this string? value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }

    /// <summary>
    /// Validates that the string is not empty.
    /// </summary>
    /// <param name="value">The string to evaluate.</param>
    /// <returns>A <see cref="Result{T}"/> of bool indicating validity.</returns>
    public static Result<bool> IsValidNotEmpty(this string value)
    {
        return value.IsValid();
    }

    /// <summary>
    /// Validates that the string length is within the specified range.
    /// </summary>
    /// <param name="value">The string to evaluate.</param>
    /// <param name="fieldMinLength">The minimum allowed length.</param>
    /// <param name="fieldMaxLength">The maximum allowed length.</param>
    /// <returns>A <see cref="Result{T}"/> of bool indicating whether the length is valid.</returns>
    public static Result<bool> IsValidLength(this string value, int fieldMinLength, int fieldMaxLength)
    {
        return value.Length.IsBetween(fieldMinLength, fieldMaxLength);
    }
}
