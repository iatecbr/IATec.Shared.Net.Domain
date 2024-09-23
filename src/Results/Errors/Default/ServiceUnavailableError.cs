using FluentResults;

namespace IATec.Shared.Domain.Results.Errors.Default;

public class ServiceUnavailableError : Error
{
    public ServiceUnavailableError()
    {
        Message = "Serviço indisponível, contate com o time de suporte: suporte.arq@iatec.com.";
    }
}