namespace IATec.Shared.Domain.Models.LoggingAggregate.Dtos;

public record LogDto
{
    public string Id { get; set; }
    public string ContainerKey { get; set; }
    public string Source { get; set; }
    public string Owner { get; set; }
    public string Action { get; set; }
    public string UserId { get; set; }
    public DateTime Date { get; set; }
    public string Content { get; set; }

    public LogDto(string id, string containerKey, string source, string owner, string action, string userId,
        DateTime date, string content)
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
}