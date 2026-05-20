namespace IATec.Shared.Domain.Identifies.Logging;

/// <summary>
/// Represents the type of action performed in a log entry.
/// </summary>
public class LogActionType
{
    /// <summary>
    /// Gets the value of the log action type.
    /// </summary>
    public string Value { get; private set; }

    private LogActionType(string type)
    {
        Value = type;
    }

    /// <summary>
    /// Gets the Added action type.
    /// </summary>
    public static LogActionType Added => new("ADDED");

    /// <summary>
    /// Gets the Modified action type.
    /// </summary>
    public static LogActionType Modified => new("MODIFIED");

    /// <summary>
    /// Gets the Deleted action type.
    /// </summary>
    public static LogActionType Deleted => new("DELETED");
}
