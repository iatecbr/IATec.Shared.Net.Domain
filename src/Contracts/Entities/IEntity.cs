using IATec.Shared.Domain.Identifies.Base;

namespace IATec.Shared.Domain.Contracts.Entities;

public interface IEntity
{
    public bool IsUnassigned();

    public BaseIdentify? GetSourceType();

    public string GetOwner();

    public object? GetLogContent();

    public string ToString();
}