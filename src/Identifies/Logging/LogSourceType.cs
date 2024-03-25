using IATec.Shared.Domain.Identifies.Base;

namespace IATec.Shared.Domain.Identifies.Logging;

public class LogSourceType(string type) : BaseIdentify(type)
{
    public static LogSourceType AccountPeople => new("accounts.People");
    public static LogSourceType InventoryAsset => new("inventory.Assets");
}