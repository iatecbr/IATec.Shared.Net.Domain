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
    
    public LogDto()
    {
    }
    
    public LogDto(string id, string containerKey, string source, string owner, string action, string userId, DateTime date, string content)
    {
        Id = id;
        ContainerKey = containerKey;
        Source = source;
        Owner = owner;
        Action = action;
        UserId = userId;
        Date = date;
        Content = content;
    }
    
    public LogDto(string containerKey, string source, string owner, string action, string userId, DateTime date, string content)
    {
        ContainerKey = containerKey;
        Source = source;
        Owner = owner;
        Action = action;
        UserId = userId;
        Date = date;
        Content = content;
    }
}