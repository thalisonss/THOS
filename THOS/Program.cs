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

            // 2. Inicia o formulário principal
            Application.Run(new PatientManagementForm());
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