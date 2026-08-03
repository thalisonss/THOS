namespace THOS.Client.Shared.Validation
{
    /// <summary>
    /// Representa um erro individual de validação.
    /// Mantém o modelo simples para ser reutilizado em qualquer tela.
    /// </summary>
    public sealed record ValidationIssue(string FieldName, string Message);
}
