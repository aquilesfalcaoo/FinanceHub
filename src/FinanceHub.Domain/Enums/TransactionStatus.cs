namespace FinanceHub.Domain.Enums;

/// <summary>
/// Representa o status de uma transação financeira.
/// </summary>
public enum TransactionStatus
{
    /// <summary>
    /// Transação pendente, ainda não confirmada.
    /// </summary>
    Pending = 1,

    /// <summary>
    /// Transação concluída com sucesso.
    /// </summary>
    Completed = 2,

    /// <summary>
    /// Transação cancelada.
    /// </summary>
    Cancelled = 3
}