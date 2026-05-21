namespace IATec.Shared.Domain.SeedWorks;

/// <summary>
/// Represents an entity with a 32-bit integer identifier and an external ULID.
/// </summary>
public class EntityUlidInt32 : Entity<int>
{
    /// <summary>
    /// Gets the external unique identifier generated as a ULID.
    /// </summary>
    public string ExternalId { get; private set; } = Ulid.NewUlid().ToString();

    /// <summary>
    /// Gets the owner identifier, which is the entity's Id.
    /// </summary>
    /// <returns>A string representing the owner identifier.</returns>
    public override string GetOwner()
    {
        return $"{Id}";
    }

    /// <summary>
    /// Determines whether the entity identifier is unassigned (equal to zero).
    /// </summary>
    /// <returns>True if the identifier is zero; otherwise, false.</returns>
    public override bool IsUnassigned()
    {
        return Id == 0;
    }
}
