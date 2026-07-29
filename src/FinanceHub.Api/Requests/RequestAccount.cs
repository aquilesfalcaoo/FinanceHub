using FinanceHub.Domain.Enums;

namespace FinanceHub.Api.Requests;

public class RequestAccount
{
    public required string Name { get; set; }
    public string BankCode { get; set; } = string.Empty;
    public string BankName { get; set; } = string.Empty;
    public string Agency { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public required AccountType Type { get; set; }
    public required decimal Balance { get; set; }
    public required string Currency { get; set; }
    public required bool IsActive { get; set; }
}