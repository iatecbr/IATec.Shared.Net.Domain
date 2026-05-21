namespace IATec.Shared.Domain.Options;

/// <summary>
/// Represents configuration options for a container.
/// </summary>
public class ContainerOption
{
    /// <summary>
    /// The configuration section key for container options.
    /// </summary>
    public const string Key = "Container";

    /// <summary>
    /// Gets the name of the container.
    /// </summary>
    public string Name { get; init; } = string.Empty;

    /// <summary>
    /// Gets the unique identifier of the container.
    /// </summary>
    public string ContainerId { get; init; } = string.Empty;
}
