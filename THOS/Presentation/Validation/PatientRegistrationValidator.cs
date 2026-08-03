using THOS.Client.Shared.Validation;

namespace THOS.Client.Presentation.Validation
{
    /// <summary>
    /// Concentra as regras da ficha de paciente em um único lugar.
    /// As regras reutilizáveis ficam no namespace Shared.Validation.
    /// </summary>
    public static class PatientRegistrationValidator
    {
        private static readonly string[] AllowedGenders =
        [
            "Masculino",
            "Feminino",
            "Outro",
            "Prefiro não informar",
            "PreferNotToSay"
        ];

        private static readonly string[] AllowedStates =
        [
            "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG",
            "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO"
        ];

        public static ValidationResult Validate(PatientRegistrationData data)
        {
            // Assumimos como obrigatórios os dados mínimos de identificação e contato
            // para uma ficha de paciente funcional.
            var rules = new List<ValidationRule>
            {
                ValidationRules.Required("FullName", () => data.FullName, "O nome completo é obrigatório."),
                ValidationRules.Required("TaxId", () => data.TaxId, "O CPF é obrigatório."),
                ValidationRules.RequiredDate("BirthDate", () => data.BirthDate, "A data de nascimento é obrigatória."),
                ValidationRules.Required("MobilePhone", () => data.MobilePhone, "O telefone celular é obrigatório."),
                ValidationRules.Required("Email", () => data.Email, "O e-mail é obrigatório."),
                ValidationRules.Required("PostalCode", () => data.PostalCode, "O CEP é obrigatório."),
                ValidationRules.Required("StreetAddress", () => data.StreetAddress, "O logradouro é obrigatório."),
                ValidationRules.Required("City", () => data.City, "A cidade é obrigatória."),
                ValidationRules.Required("State", () => data.State, "A UF é obrigatória."),
                ValidationRules.OptionalCpf("TaxId", () => data.TaxId, "CPF inválido."),
                ValidationRules.OptionalPhone("MobilePhone", () => data.MobilePhone, "Telefone celular inválido."),
                ValidationRules.OptionalEmail("Email", () => data.Email, "E-mail inválido."),
                ValidationRules.OptionalPhone("EmergencyPhone", () => data.EmergencyPhone, "Telefone de emergência inválido."),
                ValidationRules.OptionalPostalCode("PostalCode", () => data.PostalCode, "CEP inválido."),
                ValidationRules.FutureDateNotAllowed("BirthDate", () => data.BirthDate, "A data de nascimento não pode ser futura."),
                ValidationRules.AllowedValues("Gender", () => data.Gender, AllowedGenders, "Selecione um gênero válido."),
                ValidationRules.AllowedValues("State", () => data.State, AllowedStates, "Selecione uma UF válida.")
            };

            return ValidationService.Validate(rules);
        }
    }
}
