using System.Globalization;
using System.Text.RegularExpressions;

namespace THOS.Client.Shared.Validation
{
    /// <summary>
    /// Biblioteca de regras universais de validação.
    /// Aqui ficam apenas regras reutilizáveis e independentes de tela.
    /// </summary>
    public static class ValidationRules
    {
        public static ValidationRule Required(string fieldName, Func<string?> valueAccessor, string message)
        {
            return new ValidationRule(fieldName, message, () => !string.IsNullOrWhiteSpace(valueAccessor()));
        }

        public static ValidationRule OptionalMaxLength(string fieldName, Func<string?> valueAccessor, int maxLength, string message)
        {
            return new ValidationRule(fieldName, message, () =>
            {
                string? value = valueAccessor();
                return string.IsNullOrWhiteSpace(value) || value.Trim().Length <= maxLength;
            });
        }

        public static ValidationRule OptionalEmail(string fieldName, Func<string?> valueAccessor, string message)
        {
            return new ValidationRule(fieldName, message, () => IsValidEmail(valueAccessor()));
        }

        public static ValidationRule OptionalPhone(string fieldName, Func<string?> valueAccessor, string message, int minDigits = 10, int maxDigits = 11)
        {
            return new ValidationRule(fieldName, message, () => IsValidPhone(valueAccessor(), minDigits, maxDigits));
        }

        public static ValidationRule OptionalPostalCode(string fieldName, Func<string?> valueAccessor, string message)
        {
            return new ValidationRule(fieldName, message, () => IsValidPostalCode(valueAccessor()));
        }

        public static ValidationRule OptionalCpf(string fieldName, Func<string?> valueAccessor, string message)
        {
            return new ValidationRule(fieldName, message, () => IsValidCpf(valueAccessor()));
        }

        public static ValidationRule FutureDateNotAllowed(string fieldName, Func<DateTime?> valueAccessor, string message)
        {
            return new ValidationRule(fieldName, message, () =>
            {
                DateTime? value = valueAccessor();
                return !value.HasValue || value.Value.Date <= DateTime.Today;
            });
        }

        public static ValidationRule RequiredDate(string fieldName, Func<DateTime?> valueAccessor, string message)
        {
            return new ValidationRule(fieldName, message, () => valueAccessor().HasValue);
        }

        public static ValidationRule AllowedValues(string fieldName, Func<string?> valueAccessor, IReadOnlyCollection<string> allowedValues, string message, bool allowEmpty = true)
        {
            return new ValidationRule(fieldName, message, () =>
            {
                string? value = valueAccessor();
                if (string.IsNullOrWhiteSpace(value))
                {
                    return allowEmpty;
                }

                return allowedValues.Any(allowedValue => string.Equals(allowedValue, value.Trim(), StringComparison.OrdinalIgnoreCase));
            });
        }

        public static string OnlyDigits(string? value)
        {
            return string.IsNullOrWhiteSpace(value) ? string.Empty : Regex.Replace(value, @"\D", string.Empty);
        }

        public static bool IsValidEmail(string? value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return true;
            }

            try
            {
                _ = new System.Net.Mail.MailAddress(value.Trim());
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhone(string? value, int minDigits = 10, int maxDigits = 11)
        {
            string digits = OnlyDigits(value);
            return string.IsNullOrWhiteSpace(digits) || (digits.Length >= minDigits && digits.Length <= maxDigits);
        }

        public static bool IsValidPostalCode(string? value)
        {
            string digits = OnlyDigits(value);
            return string.IsNullOrWhiteSpace(digits) || digits.Length == 8;
        }

        public static bool IsAllowedValue(string? value, IReadOnlyCollection<string> allowedValues, bool allowEmpty = true)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return allowEmpty;
            }

            return allowedValues.Any(allowedValue => string.Equals(allowedValue, value.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static bool IsValidCpf(string? value)
        {
            string cpfDigits = OnlyDigits(value);

            if (cpfDigits.Length != 11)
            {
                return false;
            }

            if (cpfDigits.Distinct().Count() == 1)
            {
                return false;
            }

            int[] multipliersFirstDigit = [10, 9, 8, 7, 6, 5, 4, 3, 2];
            int[] multipliersSecondDigit = [11, 10, 9, 8, 7, 6, 5, 4, 3, 2];

            string baseDigits = cpfDigits[..9];
            string firstDigit = CalculateCpfDigit(baseDigits, multipliersFirstDigit).ToString(CultureInfo.InvariantCulture);
            string secondDigit = CalculateCpfDigit(baseDigits + firstDigit, multipliersSecondDigit).ToString(CultureInfo.InvariantCulture);

            return cpfDigits.EndsWith(firstDigit + secondDigit, StringComparison.Ordinal);
        }

        private static int CalculateCpfDigit(string digits, int[] multipliers)
        {
            int sum = 0;

            for (int index = 0; index < multipliers.Length; index++)
            {
                sum += (digits[index] - '0') * multipliers[index];
            }

            int remainder = sum % 11;
            return remainder < 2 ? 0 : 11 - remainder;
        }
    }
}
