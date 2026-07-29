namespace FinanceHub.Domain.Enums;

/// <summary>
/// Representa os tipos de contas financeiras.
/// </summary>
public enum AccountType
{
    /// <summary>
    /// Conta Corrente.
    /// </summary>
    Checking = 1,

    /// <summary>
    /// Conta Poupança.
    /// </summary>
    Savings = 2,

    /// <summary>
    /// Conta Digital.
    /// </summary>
    Digital = 3,

    /// <summary>
    /// Carteira.
    /// </summary>
    Wallet = 4,

    /// <summary>
    /// Conta de Investimentos.
    /// </summary>
    Investment = 5,

    /// <summary>
    /// Dinheiro em espécie.
    /// </summary>
    Cash = 6
}