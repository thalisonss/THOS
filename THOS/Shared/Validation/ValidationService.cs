namespace THOS.Client.Shared.Validation
{
    /// <summary>
    /// Executor genérico de regras de validação.
    /// Mantém a tela limpa e deixa a regra concentrada em um único ponto.
    /// </summary>
    public static class ValidationService
    {
        public static ValidationResult Validate(IEnumerable<ValidationRule> rules)
        {
            var result = new ValidationResult();

            foreach (ValidationRule rule in rules)
            {
                if (!rule.IsValid())
                {
                    result.AddIssue(rule.FieldName, rule.Message);
                }
            }

            return result;
        }
    }
}
