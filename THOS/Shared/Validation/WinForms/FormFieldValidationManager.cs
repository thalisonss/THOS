using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace THOS.Client.Shared.Validation.WinForms
{
    /// <summary>
    /// Gerencia validação visual por campo no WinForms.
    /// Centraliza ErrorProvider, cores e atualização por foco/perda de foco.
    /// </summary>
    public sealed class FormFieldValidationManager : Component
    {
        private static readonly Color InvalidBackColor = Color.Firebrick;
        private static readonly Color InvalidForeColor = Color.White;
        private static readonly Color ValidBackColor = Color.White;
        private static readonly Color ValidForeColor = Color.Black;

        private readonly ErrorProvider _errorProvider;
        private readonly Dictionary<string, FieldValidationDefinition> _definitions = new(StringComparer.OrdinalIgnoreCase);
        private readonly Dictionary<Control, string> _fieldNames = new();
        private readonly List<ValidationIssue> _issues = new();

        private bool _suspendLiveValidation;

        public event EventHandler? ValidationStateChanged;

        public FormFieldValidationManager(ContainerControl container)
        {
            _errorProvider = new ErrorProvider
            {
                ContainerControl = container,
                BlinkStyle = ErrorBlinkStyle.NeverBlink
            };
        }

        public IReadOnlyList<ValidationIssue> Issues => _issues;

        public void AddDefinition(FieldValidationDefinition definition)
        {
            _definitions[definition.FieldName] = definition;
            _fieldNames[definition.Control] = definition.FieldName;

            // Valida somente quando o usuário sai do campo.
            // Isso evita falsos erros enquanto ele ainda está digitando, especialmente em MaskedTextBox.
            definition.Control.Leave += Control_Leave;
        }

        public void BeginBulkUpdate()
        {
            _suspendLiveValidation = true;
        }

        public void EndBulkUpdate()
        {
            _suspendLiveValidation = false;
        }

        public void Clear()
        {
            _issues.Clear();
            _errorProvider.Clear();

            foreach (FieldValidationDefinition definition in _definitions.Values)
            {
                ApplyValidStyle(definition.Control);
            }

            RaiseStateChanged();
        }

        public void ApplyResult(ValidationResult result)
        {
            Clear();

            foreach (ValidationIssue issue in result.Issues)
            {
                if (_definitions.TryGetValue(issue.FieldName, out FieldValidationDefinition? definition))
                {
                    ApplyInvalidStyle(definition.Control);
                    _errorProvider.SetError(definition.Control, issue.Message);
                    _issues.Add(issue);
                }
            }

            RaiseStateChanged();
        }

        public ValidationResult ValidateAll()
        {
            foreach (FieldValidationDefinition definition in _definitions.Values)
            {
                ValidateDefinition(definition);
            }

            ValidationResult result = BuildResult();
            RaiseStateChanged();
            return result;
        }

        public ValidationResult ValidateField(string fieldName)
        {
            if (!_definitions.TryGetValue(fieldName, out FieldValidationDefinition? definition))
            {
                return BuildResult();
            }

            ValidateDefinition(definition);
            ValidationResult result = BuildResult();
            RaiseStateChanged();
            return result;
        }

        public ValidationResult ValidateField(Control control)
        {
            if (!_fieldNames.TryGetValue(control, out string? fieldName))
            {
                return BuildResult();
            }

            return ValidateField(fieldName);
        }

        public bool TryGetControl(string fieldName, out Control? control)
        {
            if (_definitions.TryGetValue(fieldName, out FieldValidationDefinition? definition))
            {
                control = definition.Control;
                return true;
            }

            control = null;
            return false;
        }

        private void RaiseStateChanged()
        {
            ValidationStateChanged?.Invoke(this, EventArgs.Empty);
        }

        private void Control_Leave(object? sender, EventArgs e)
        {
            if (_suspendLiveValidation)
            {
                return;
            }

            if (sender is Control control)
            {
                ValidateField(control);
            }
        }

        private void ValidateDefinition(FieldValidationDefinition definition)
        {
            bool isValid = definition.IsValid();
            SetControlState(definition.Control, isValid, definition.ErrorMessage);
            UpdateIssue(definition.FieldName, definition.ErrorMessage, isValid);
        }

        private void SetControlState(Control control, bool isValid, string errorMessage)
        {
            if (isValid)
            {
                ApplyValidStyle(control);
                _errorProvider.SetError(control, string.Empty);
                return;
            }

            ApplyInvalidStyle(control);
            _errorProvider.SetError(control, errorMessage);
        }

        private void ApplyInvalidStyle(Control control)
        {
            control.BackColor = InvalidBackColor;
            control.ForeColor = InvalidForeColor;
        }

        private void ApplyValidStyle(Control control)
        {
            control.BackColor = ValidBackColor;
            control.ForeColor = ValidForeColor;
        }

        private void UpdateIssue(string fieldName, string message, bool isValid)
        {
            _issues.RemoveAll(issue => string.Equals(issue.FieldName, fieldName, StringComparison.OrdinalIgnoreCase));

            if (!isValid)
            {
                _issues.Add(new ValidationIssue(fieldName, message));
            }
        }

        private ValidationResult BuildResult()
        {
            var result = new ValidationResult();
            result.AddRange(_issues);
            return result;
        }
    }
}
