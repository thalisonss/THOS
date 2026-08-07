using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using THOS.Client.Infrastructure.Data;
using THOS.Client;
using THOS.Forms;

namespace THOS.Client
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // 1. Inicializa o Banco SQLite Local via EF Core
            InitializeAndVerifyDatabase();
            
            // 2. Apresenta a tela de Login
            using (var loginForm = new THOS.Client.Presentation.Forms.LoginForm())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                                        var user = loginForm.AuthenticatedUser;
                    if (user == null) { Application.Exit(); return; }
                    
                    // Se nao tem perfil ou eh vazio, força a selecionar
                    if (user.ProfileLastAccessId == null || user.ProfileLastAccessId == Guid.Empty)
                    {
                        using (var profileForm = new THOS.Client.Presentation.Forms.SelectProfileForm(user.Id))
                        {
                            if (profileForm.ShowDialog() != DialogResult.OK)
                            {
                                Application.Exit();
                                return;
                            }
                        }
                    }

                    // 3. Inicia o formulário principal
                    Application.Run(new THOS.Client.Presentation.Forms.MainForm(user.Id));
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private static void InitializeAndVerifyDatabase()
        {
            try
            {
                using var db = new ThosContext();

                // Cria o arquivo thos_local.db e gera o Schema (Tabelas) se não existirem
                bool createdNew = db.Database.EnsureCreated();

                // Verificação de teste no SQLite
                int patientCount = db.Patients.Count();

                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "THOS",
                    "thos_local.db"
                );

                Debug.WriteLine($"[THOS DB] Banco SQLite localizado em: {dbPath}");
                Debug.WriteLine($"[THOS DB] Status da Inicialização: {(createdNew ? "Novo banco criado com sucesso!" : "Banco existente carregado.")}");
                Debug.WriteLine($"[THOS DB] Total de pacientes cadastrados: {patientCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Erro crítico ao inicializar o banco de dados SQLite local:\n\n{ex.Message}\n\nInner Exception: {ex.InnerException?.Message}",
                    "THOS - Erro de Banco de Dados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}


