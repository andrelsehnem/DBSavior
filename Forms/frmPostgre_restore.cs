using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSavior.Class;
using static DBSavior.Class.Globals;

namespace DBSavior.Forms
{
    

    public partial class frmPostgre_restore : MetroFramework.Forms.MetroForm
    {
        public Banco banco { get; set; }
        public Postgres pg_con;
        private PostgresType p;
        private string caminhoArquivo;
        public Powershell power = new Powershell();
        private string comando = "";
        public frmPostgre_restore(PostgresType _p)
        {
            InitializeComponent();
            p = _p;

            fileDialog.CheckFileExists = false;
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Arquivos (*.*)|*.*";
        }


        private void frmPostgre_restore_Load(object sender, EventArgs e)
        {

        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            ConectarBanco();

            switch (p)
            {
                case PostgresType.psql:
                    comando = $@"Postgres\psql.exe -h {banco.server} -p {banco.porta} -U {banco.user} -d {banco.banco} -f ""D:\\Importacoes\\Prioridade 10\\backup\\TMP_BACKUP_EMP_2091_1.backup""";
                    break;
                case PostgresType.pg_restore:
                    comando = $@"Postgres\pg_restore.exe --host {banco.server} --port {banco.porta} --username {banco.user} --no-password --dbname {banco.banco} --verbose ""D:\\Importacoes\\Prioridade 10\\backup\\TMP_BACKUP_EMP_2091_1.backup""";
                    //pg_restore.exe --host "localhost" --port "5432" --username "postgres" --no-password --dbname "prioridade10_1" --verbose "D:\\Importacoes\\Prioridade 10\\backup\\TMP_BACKUP_EMP_2091_1.backup"
                    break;
            }

            txtConsole.AppendText(NovaLinha + comando + NovaLinha + NovaLinha + " AGUARDE!! ");

            Restaurar(comando);

            txtConsole.AppendText(NovaLinha + NovaLinha + "Finalizado.");

        }

        private void ConectarBanco()
        {
            banco = new Banco(txtBanco.Text, txtServidor.Text, txtPorta.Text, txtUser.Text, txtSenha.Text, TipoBanco.Postgress);
            

            pg_con = new Postgres(banco);

            if(pg_con.Open()) txtConsole.AppendText(NovaLinha + NovaLinha + "Conectado ao Banco ");
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txtArquivo.Text = caminhoArquivo;
            }
            txtArquivo.Focus();
        }

        private void Restaurar(string _comando)
        {
            try
                {
                    Runspace runspace = RunspaceFactory.CreateRunspace();
                    runspace.Open();
                    Pipeline pipeline = runspace.CreatePipeline();
                    pipeline.Commands.AddScript(_comando);
                    pipeline.Commands.Add("Out-String");
                    Collection<PSObject> results = pipeline.Invoke();
                    runspace.Close();
                    foreach (PSObject pSObject in results)
                        txtConsole.AppendText(pSObject.ToString());
                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    txtConsole.AppendText(ex.ToString());
                }
            }
        
    }
}
