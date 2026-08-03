using System.Windows.Forms;

namespace THOS.Client.Shared.Validation.WinForms
{
    /// <summary>
    /// Define uma validação de campo com seu controle visual correspondente.
    /// </summary>
    public sealed record FieldValidationDefinition(
        string FieldName,
        Control Control,
        Func<bool> IsValid,
        string ErrorMessage);
}
