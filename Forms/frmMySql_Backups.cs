using DBSavior.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSavior.Class;
using static DBSavior.Class.Globals;
using System.Diagnostics;

namespace DBSavior.Forms
{
    public partial class frmMySql_Backups : MetroFramework.Forms.MetroForm
    {
        private string caminhoArquivo = "";
        private Banco banco;
        private Mysql my_con = new Mysql("");

        public frmMySql_Backups()
        {
            InitializeComponent();
        }

        private void frmMySql_Backups_Load(object sender, EventArgs e)
        {

        }

        private void radioCompleto_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCompleto.Checked) txtLog.Size = new System.Drawing.Size(765, 230);            checkListBancos.Visible = !radioCompleto.Checked;
        }

        private void radioSelecionaTabelas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSelecionaTabelas.Checked)
            {
                txtLog.Size = new System.Drawing.Size(369, 230);
                checkListBancos.Visible = true;
               // if (!VerificaConexao()) return;
                ListarTabelas();
            }
        }

        private void btSelecionarArquivo_Click(object sender, EventArgs e)
        {
            fileDialog.Title = "Selecione a pasta para salvar o backup...";
            fileDialog.CheckFileExists = false;
            fileDialog.Multiselect = false;
            fileDialog.Filter = "Arquivos SQL (*.sql)|*.sql";
            fileDialog.FileName = "MyBackup.sql";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txtCaminhoArquivo.Text = caminhoArquivo;
            }

            txtCaminhoArquivo.Focus();
        }

        private bool VerificaConexao()
        {

            return false;
        }

        private void btVerificaConexao_Click(object sender, EventArgs e)
        {
            ConectarBanco();
            if (radioSelecionaTabelas.Checked) ListarTabelas();
        }
        private void ConectarBanco()
        {
            txtLog.Text = "";
            if (my_con.IsOpen())
            {
                my_con.Close();
            }

            banco = new Banco(txtBanco.Text, txtServidor.Text, txtPorta.Text, txtUser.Text, txtSenha.Text, TipoBanco.MySql);

            my_con = new Mysql(banco);

            if (my_con.Open()) txtLog.AppendText(NovaLinha + NovaLinha + "Conectado ao Banco ");
            else txtLog.AppendText(NovaLinha + NovaLinha + "Erro na Conexão ");
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            ConectarBanco();
        }

        private void ListarTabelas()
        {
            txtLog.Text = "";
            if (!my_con.IsOpen())
            {
                txtLog.AppendText(NovaLinha + NovaLinha + "Conexão não encontrada. Ajuste os dados do banco e verifique a conexão");
                return;
            }

            DataTable dt = my_con.ExecuteQuery("show tables");
            foreach(DataRow row in dt.Rows)
            {
                checkListBancos.Items.Add(row[0]);
            }
        }
    }
}
