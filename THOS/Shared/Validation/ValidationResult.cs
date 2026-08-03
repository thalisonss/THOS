using System.Collections.ObjectModel;

namespace THOS.Client.Shared.Validation
{
    /// <summary>
    /// Resultado final de uma execução de validação.
    /// </summary>
    public sealed class ValidationResult
    {
        private readonly List<ValidationIssue> _issues = new();

        public bool IsValid => _issues.Count == 0;

        public IReadOnlyList<ValidationIssue> Issues => new ReadOnlyCollection<ValidationIssue>(_issues);

        public void AddIssue(string fieldName, string message)
        {
            _issues.Add(new ValidationIssue(fieldName, message));
        }

        public void AddIssue(ValidationIssue issue)
        {
            _issues.Add(issue);
        }

        public void AddRange(IEnumerable<ValidationIssue> issues)
        {
            _issues.AddRange(issues);
        }
    }
}
