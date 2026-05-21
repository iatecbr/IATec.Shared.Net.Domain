namespace IATec.Shared.Domain.Identifies.Contexts;

/// <summary>
/// Represents the context type for categorizing errors and operations.
/// </summary>
public class ContextType
{
    /// <summary>
    /// Gets the value of the context type.
    /// </summary>
    public string Value { get; private set; }

    private ContextType(string type)
    {
        Value = type;
    }

    /// <summary>
    /// Gets the Domain context type.
    /// </summary>
    public static ContextType Domain => new("Domain");

    /// <summary>
    /// Gets the Application context type.
    /// </summary>
    public static ContextType Application => new("Application");
}
