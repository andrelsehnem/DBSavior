using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSavior.Class;
using static DBSavior.Class.Globals;

namespace DBSavior.Forms
{
    public partial class frmFirebird_conv : MetroFramework.Forms.MetroForm
    {
        private Powershell power = new Powershell();
        private FirebirdType fbT;
        public string comando, nomeBanco, caminhoArquivo, porta, usuario, senha;
        public frmFirebird_conv(FirebirdType _fbT)
        {
            InitializeComponent();
            fbT = _fbT;
            PersonalizaForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void frmFirebird_conv_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void PersonalizaForm()
        {
            switch (fbT)
            {
                case FirebirdType.fbkFbd:
                    lblArquivoK.Text = "Arquivo .FBK";
                    lblArquivoB.Text = "Arquivo .FDB";
                    btKtoB.Text = ".FBK -> .FDB";
                    btBtoK.Text = ".FDB -> .FBK";
                    break;
                case FirebirdType.gbkGbd:
                    lblArquivoK.Text = "Arquivo .GBK";
                    lblArquivoB.Text = "Arquivo .GDB";
                    btKtoB.Text = ".GBK -> .GDB";
                    btBtoK.Text = ".GDB -> .GBK";
                    break;
            }
        }

        private void btKtoB_Click(object sender, EventArgs e)
        {
            if (radioFire20.Checked)
            {
                comando = @"Fire2.0\gbak ";
            }
            else if (radioFire25.Checked)
            {
                comando = @"Fire2.5\gbak ";
            }
            else if (radioFire30.Checked)
            {
                comando = @"Fire3.0\gbak ";
            }
            else if (radioFire40.Checked)
            {
                comando = @"Fire4.0\gbak ";
            }
            else
            {
                MessageBox.Show("Selecione um drive");
            }

            comando = comando + @" -c -user sysdba -password masterkey """ + txtArquivoK.Text + @""" """ + txtArquivoB.Text + @"""";
            txtConsoleFire.Text = "Aguarde... \r\n \r\n" + comando + "\r\n \r\n";

            Application.DoEvents();
            power.PowerShell(comando);

            txtConsoleFire.Text = txtConsoleFire.Text + (File.Exists(txtArquivoB.Text) ? "Processo executado com sucesso! \r\n \r\n" : "Erro \r\n \r\n");

            txtConsoleFire.Text = txtConsoleFire.Text + power.mensagem;
        }

        private void btBuscarK_Click(object sender, EventArgs e)
        {
            fileDialog.CheckFileExists = false;
            fileDialog.Multiselect = false;
            switch (fbT)
            {
                case FirebirdType.fbkFbd:
                    fileDialog.Filter = "Arquivos FBK (*.fbk)|*.fbk";
                    break;
                case FirebirdType.gbkGbd:
                    fileDialog.Filter = "Arquivos GBK (*.gbk)|*.gbk";
                    break;
            }
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txtArquivoK.Text = caminhoArquivo;
            }
            txtArquivoK.Focus();
        }

        private void btBuscarB_Click(object sender, EventArgs e)
        {
            fileDialog.CheckFileExists = false;
            fileDialog.Multiselect = false;
            switch (fbT)
            {
                case FirebirdType.fbkFbd:
                    fileDialog.Filter = "Arquivos FDB (*.fdb)|*.fdb";
                    break;
                case FirebirdType.gbkGbd:
                    fileDialog.Filter = "Arquivos GDB (*.Gdb)|*.gdb";
                    break;
            }
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoArquivo = fileDialog.FileName;
                txtArquivoB.Text = caminhoArquivo;
            }
        }

        private void txtArquivoK_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtArquivoK.Text == @"C:\")
                {
                    txtArquivoB.Text = @"C:\";
                }
                else
                {
                    switch (fbT)
                    {
                        case FirebirdType.fbkFbd:
                            txtArquivoB.Text = txtArquivoK.Text.Substring(0, txtArquivoK.Text.Length - 3) + "fdb";
                            break;
                        case FirebirdType.gbkGbd:
                            txtArquivoB.Text = txtArquivoK.Text.Substring(0, txtArquivoK.Text.Length - 3) + "gdb";
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                txtArquivoB.Text = @"C:\";
            }
        }

        public void geraComando() //esse é pro postgre
        {
            //usuario = "postgres";
            nomeBanco = "3834";
            caminhoArquivo = "D:\\Importacoes\\3834 - JRA Parafusos - Totall\\Backup\\arquivos\\backup\\PGSQL\\20220913\\totall_20220913 - 115201.pgdmp";
            comando = "psql -U " + usuario + "- d " + nomeBanco + "  -f \"" + caminhoArquivo + "\"";
        }
    }
}
