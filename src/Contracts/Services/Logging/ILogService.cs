using IATec.Shared.Domain.Models.LoggingAggregate.Dtos;

namespace IATec.Shared.Domain.Contracts.Services.Logging;

public interface ILogService
{
    Task SendAsync(LogDto log, CancellationToken cancellationToken = default);
}