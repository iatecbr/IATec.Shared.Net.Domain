namespace IATec.Shared.Domain.SeedWorks;

/// <summary>
/// Represents an entity with a nullable string identifier.
/// </summary>
public class EntityNullable : Entity<string?>
{
    /// <summary>
    /// Gets the owner identifier, which is the entity's Id.
    /// </summary>
    /// <returns>A string representing the owner identifier.</returns>
    public override string GetOwner()
    {
        return $"{Id}";
    }

    /// <summary>
    /// Determines whether the entity identifier is unassigned (null or empty).
    /// </summary>
    /// <returns>True if the identifier is null or empty; otherwise, false.</returns>
    public override bool IsUnassigned()
    {
        return string.IsNullOrEmpty(Id);
    }
}
