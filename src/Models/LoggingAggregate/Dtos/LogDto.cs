namespace IATec.Shared.Domain.Models.LoggingAggregate.Dtos;

public record LogDto
{
    public string Id { get; init; }
    public string ContainerKey { get; init; }
    public string Source { get; init; }
    public string Owner { get; init; }
    public string Action { get; init; }
    public string UserId { get; init; }
    public DateTime Date { get; init; }
    public string Content { get; init; }
}