using IATec.Shared.Domain.Contracts.Entities;
using IATec.Shared.Domain.Identifies.Base;

namespace IATec.Shared.Domain.SeedWorks;

/// <summary>
/// Abstract base class for all domain entities with a generic identifier type.
/// </summary>
/// <typeparam name="T">The type of the entity identifier.</typeparam>
public abstract class Entity<T> : IEntity
{
    /// <summary>
    /// Gets or sets the unique identifier of the entity.
    /// </summary>
    public virtual T? Id { get; set; }

    /// <summary>
    /// Determines whether the entity identifier is unassigned or default.
    /// </summary>
    /// <returns>True if the identifier is unassigned; otherwise, false.</returns>
    public abstract bool IsUnassigned();

    /// <summary>
    /// Gets the source type of the entity for identification purposes.
    /// </summary>
    /// <returns>The source type identifier, or null if not defined.</returns>
    public virtual BaseIdentify? GetSourceType()
    {
        return null;
    }

    /// <summary>
    /// Gets the content to be logged for this entity.
    /// </summary>
    /// <returns>The log content object, or null if not defined.</returns>
    public virtual object? GetLogContent()
    {
        return null;
    }

    /// <summary>
    /// Gets the owner identifier of the entity.
    /// </summary>
    /// <returns>A string representing the owner.</returns>
    public virtual string GetOwner()
    {
        return string.Empty;
    }

    /// <summary>
    /// Returns a string representation of the entity.
    /// </summary>
    /// <returns>A string that represents the entity including its type name and identifier.</returns>
    public override string ToString()
    {
        return $"{GetType().Name} [Id={Id}]";
    }
}
