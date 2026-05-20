namespace IATec.Shared.Domain.Extensions;

/// <summary>
/// Provides extension methods for integer and date operations.
/// </summary>
public static class IntExtension
{
    /// <summary>
    /// Determines whether the number is within the specified range.
    /// </summary>
    /// <param name="num">The number to evaluate.</param>
    /// <param name="min">The minimum value.</param>
    /// <param name="max">The maximum value.</param>
    /// <param name="includeMin">If true, includes the minimum value in the range.</param>
    /// <param name="includeMax">If true, includes the maximum value in the range.</param>
    /// <returns>True if the number is within the range; otherwise, false.</returns>
    public static bool IsBetween(this int num,
        int min,
        int max,
        bool includeMin = true,
        bool includeMax = true)
    {
        return IsGreaterThan(num, min, includeMin) && IsLessThan(num, max, includeMax);
    }

    /// <summary>
    /// Determines whether the value is greater than the specified minimum.
    /// </summary>
    /// <param name="value">The value to evaluate.</param>
    /// <param name="minValue">The minimum value.</param>
    /// <param name="includeMin">If true, includes the minimum value.</param>
    /// <returns>True if the value is greater than the minimum; otherwise, false.</returns>
    public static bool IsGreaterThan(int value, int minValue, bool includeMin)
    {
        return (includeMin && value >= minValue) || value > minValue;
    }

    /// <summary>
    /// Determines whether the value is less than the specified maximum.
    /// </summary>
    /// <param name="value">The value to evaluate.</param>
    /// <param name="maxValue">The maximum value.</param>
    /// <param name="includeMax">If true, includes the maximum value.</param>
    /// <returns>True if the value is less than the maximum; otherwise, false.</returns>
    public static bool IsLessThan(int value, int maxValue, bool includeMax)
    {
        return (includeMax && value <= maxValue) || value < maxValue;
    }

    /// <summary>
    /// Calculates the age based on the birth date.
    /// </summary>
    /// <param name="birthDate">The birth date.</param>
    /// <returns>The age in years, or 0 if the birth date is null.</returns>
    public static int GetAge(this DateTime? birthDate)
    {
        if (birthDate == null) return 0;

        return new DateTime(DateTime.Now.Subtract((DateTime) birthDate).Ticks).Year - 1;
    }

    /// <summary>
    /// Calculates the age based on a birth date string.
    /// </summary>
    /// <param name="birthDate">The birth date as a string.</param>
    /// <returns>The age in years, or 0 if parsing fails.</returns>
    public static int GetAge(this string? birthDate)
    {
        if (birthDate == null) return 0;

        try
        {
#pragma warning disable CA1806
            DateTime.TryParse(birthDate, out var birthDateParsed);
#pragma warning restore CA1806

            return new DateTime(DateTime.Now.Subtract(birthDateParsed).Ticks).Year - 1;
        }
        catch (Exception)
        {
            return 0;
        }
    }
}
