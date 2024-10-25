namespace IATec.Shared.Domain.SeedWorks;

public class EntityUlidInt32 : Entity<int>
{
    public string SecondId { get; private set; } = Ulid.NewUlid().ToString();
    
    public override string GetOwner()
    {
        return $"{Id}";
    }
    
    public override bool IsUnassigned()
    {
        return Id == 0;
    }
}