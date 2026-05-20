namespace IATec.Shared.Domain.Identifies.Base;

/// <summary>
/// Abstract base class for identification types.
/// </summary>
public abstract class BaseIdentify(string type)
{
    /// <summary>
    /// Gets the value representing the identification type.
    /// </summary>
    public string Value { get; private set; } = type;
}
