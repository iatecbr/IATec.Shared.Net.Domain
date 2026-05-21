using System.Linq.Expressions;

namespace IATec.Shared.Domain.Extensions;

/// <summary>
/// Provides extension methods for enum operations.
/// </summary>
public static class EnumExtension
{
    /// <summary>
    /// Converts a property expression to a property identifier name.
    /// </summary>
    /// <typeparam name="T">The type containing the property.</typeparam>
    /// <param name="propertyExpression">The property expression.</param>
    /// <returns>The processed property identifier name.</returns>
    /// <exception cref="ArgumentException">Thrown when the expression does not refer to a property.</exception>
    public static string ToPropertyIdName<T>(Expression<Func<T, object>> propertyExpression)
    {
        return propertyExpression.Body switch
        {
            MemberExpression member => ProcessPropertyName(member.Member.Name),
            UnaryExpression {Operand: MemberExpression memberExpression} =>
                ProcessPropertyName(memberExpression.Member.Name),
            _ => throw new ArgumentException("The expression does not refer to a property.")
        };
    }

    /// <summary>
    /// Processes the property name by replacing "Enum" suffix with "Id" or appending "Id".
    /// </summary>
    /// <param name="propertyName">The original property name.</param>
    /// <returns>The processed property name.</returns>
    private static string ProcessPropertyName(string propertyName)
    {
        return propertyName.EndsWith("Enum")
            ? propertyName.Replace("Enum", "Id")
            : propertyName + "Id";
    }
}
