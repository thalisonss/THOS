namespace THOS.Client.Shared.Validation
{
    /// <summary>
    /// Regra genérica que pode ser combinada em qualquer formulário.
    /// A regra conhece apenas o nome do campo, a mensagem e a condição de sucesso.
    /// </summary>
    public sealed record ValidationRule(string FieldName, string Message, Func<bool> IsValid);
}
