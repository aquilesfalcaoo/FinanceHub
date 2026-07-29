namespace FinanceHub.Domain.Enums;

/// <summary>
/// Representa o papel (role) de um usuário no sistema.
/// </summary>
public enum UserRole
{
    /// <summary>
    /// Usuário comum, com acesso padrão às próprias contas e transações.
    /// </summary>
    User = 1,

    /// <summary>
    /// Administrador, com acesso privilegiado ao sistema.
    /// </summary>
    Admin = 2
}