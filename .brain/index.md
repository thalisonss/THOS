# THOS Schema Brain

## Tabelas Core
| Tabela | PK | Descrição |
|--------|-----|-----------|
| THOS_User | cIDUser (UUID) | Login, senha hash, perfil ativo |
| THOS_Profile | cIDProfile (UUID) | Nome, descrição, permissões |
| THOS_UserProfile | cIDUserProfile (UUID) | Relacionamento M:N User-Profile |
| THOS_Patient | cIDPatient (UUID) | Dados demográficos paciente |
| THOS_Anamnesis | cIDAnamnesis (UUID) | Histórico médico paciente |

## Campos Críticos
**THOS_User:** cIDUser, stLogin, stPasswordHash, cIDProfileLastAccess, bIsActive
**THOS_Profile:** cIDProfile, stName, bIsActive
**THOS_UserProfile:** cIDUser, cIDProfile, bIsActive (FK restrita)
**THOS_Patient:** stFullName, stTaxId, dtBirthDate, stEmail, stMobilePhone
**THOS_Anamnesis:** cIDPatient, bHasHeartDisease, bHasDiabetes, stContinuousMedications

## Converter Guid
EF: `ValueConverter<Guid, string>` → lowercase no SQLite (case-sensitive comparison)

## Fluxo Autenticação
1. Login → busca THOS_User por stLogin
2. Se sem cIDProfileLastAccess → SelectProfileForm
3. SelectProfileForm busca THOS_UserProfile (IsActive=1) via EF Include
4. Salva cIDProfileLastAccess → MainForm carrega menu conforme stName perfil

## Menu Dinâmico
- ADMIN: Paciente (tabbed), Usuários (tabbed)
- RECEPCIONISTA: Paciente (tabbed)
- DOUTOR: Paciente (tabbed)
- Barra pesquisa: filtra menu dinamicamente

## UI Controls
- **PatientSearchControl:** DataGridView pacientes, busca nome/CPF
- **PatientRegistrationControl:** Form cadastro/edição paciente + anamnesis
- **PacienteControl:** UserControl TabControl customizado (abas invisíveis, botões "Consultar|Cadastrar")
- **UserSearchControl:** DataGridView usuários, clica 2x pra editar
- **UserRegistrationControl:** Form cadastro/edição usuário + perfis M:N
- **UsuarioControl:** UserControl TabControl customizado (Consultar|Cadastrar)
- **MainForm:** Sidebar com menu, header user/perfil, content dinâmico, searchbar

## Último Commit
- UserSearchControl + UsuarioControl criados
- Menu consolidado: Paciente (Admin+Recep+Doutor) | Usuários (Admin)
- UserRegistrationControl.LoadUser() implementado para edição
