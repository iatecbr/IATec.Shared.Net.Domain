namespace IATec.Shared.Domain.Options;

/// <summary>
/// Represents configuration options for the logging service.
/// </summary>
public class LogServiceOption
{
    /// <summary>
    /// The configuration section key for log service options.
    /// </summary>
    public const string Key = "IATec:Services:Log";

    /// <summary>
    /// Gets the URL of the logging service.
    /// </summary>
    public string Url { get; init; } = string.Empty;
}
