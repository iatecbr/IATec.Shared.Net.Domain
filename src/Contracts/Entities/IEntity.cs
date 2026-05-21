using IATec.Shared.Domain.Identifies.Base;

namespace IATec.Shared.Domain.Contracts.Entities;

/// <summary>
/// Defines the contract for a domain entity.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Determines whether the entity identifier is unassigned.
    /// </summary>
    /// <returns>True if the identifier is unassigned; otherwise, false.</returns>
    public bool IsUnassigned();

    /// <summary>
    /// Gets the source type of the entity.
    /// </summary>
    /// <returns>The source type identifier, or null if not defined.</returns>
    public BaseIdentify? GetSourceType();

    /// <summary>
    /// Gets the owner of the entity.
    /// </summary>
    /// <returns>A string representing the owner.</returns>
    public string GetOwner();

    /// <summary>
    /// Gets the content to be logged for this entity.
    /// </summary>
    /// <returns>The log content object, or null if not defined.</returns>
    public object? GetLogContent();

    /// <summary>
    /// Returns a string representation of the entity.
    /// </summary>
    /// <returns>A string that represents the entity.</returns>
    public string ToString();
}
