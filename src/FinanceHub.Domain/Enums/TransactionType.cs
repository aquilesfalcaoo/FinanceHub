namespace FinanceHub.Domain.Enums;

/// <summary>
/// Representa o tipo de uma transação financeira.
/// </summary>
public enum TransactionType
{
    /// <summary>
    /// Entrada de dinheiro (receita).
    /// </summary>
    Income = 1,

    /// <summary>
    /// Saída de dinheiro (despesa).
    /// </summary>
    Expense = 2
}