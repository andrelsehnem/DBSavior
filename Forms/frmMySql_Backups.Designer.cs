namespace DBSavior.Forms
{
    partial class frmMySql_Backups
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.painelMysql = new MetroFramework.Controls.MetroPanel();
            this.btSelecionarArquivo = new MetroFramework.Controls.MetroButton();
            this.txtCaminhoArquivo = new MetroFramework.Controls.MetroTextBox();
            this.radioSelecionaTabelas = new MetroFramework.Controls.MetroRadioButton();
            this.radioCompleto = new MetroFramework.Controls.MetroRadioButton();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtLog = new MetroFramework.Controls.MetroTextBox();
            this.btIniciar = new MetroFramework.Controls.MetroButton();
            this.groupBanco = new System.Windows.Forms.GroupBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.txtBanco = new MetroFramework.Controls.MetroTextBox();
            this.lblBanco = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.txtPorta = new MetroFramework.Controls.MetroTextBox();
            this.lblPorta = new MetroFramework.Controls.MetroLabel();
            this.txtServidor = new MetroFramework.Controls.MetroTextBox();
            this.lblServ = new MetroFramework.Controls.MetroLabel();
            this.btVerificaConexao = new MetroFramework.Controls.MetroButton();
            this.checkListBancos = new System.Windows.Forms.CheckedListBox();
            this.painelMysql.SuspendLayout();
            this.groupBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelMysql
            // 
            this.painelMysql.Controls.Add(this.checkListBancos);
            this.painelMysql.Controls.Add(this.btVerificaConexao);
            this.painelMysql.Controls.Add(this.groupBanco);
            this.painelMysql.Controls.Add(this.btIniciar);
            this.painelMysql.Controls.Add(this.txtLog);
            this.painelMysql.Controls.Add(this.btSelecionarArquivo);
            this.painelMysql.Controls.Add(this.txtCaminhoArquivo);
            this.painelMysql.Controls.Add(this.radioSelecionaTabelas);
            this.painelMysql.Controls.Add(this.radioCompleto);
            this.painelMysql.HorizontalScrollbarBarColor = true;
            this.painelMysql.HorizontalScrollbarHighlightOnWheel = false;
            this.painelMysql.HorizontalScrollbarSize = 10;
            this.painelMysql.Location = new System.Drawing.Point(0, 0);
            this.painelMysql.Name = "painelMysql";
            this.painelMysql.Size = new System.Drawing.Size(792, 374);
            this.painelMysql.Style = MetroFramework.MetroColorStyle.Yellow;
            this.painelMysql.TabIndex = 5;
            this.painelMysql.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.painelMysql.VerticalScrollbarBarColor = true;
            this.painelMysql.VerticalScrollbarHighlightOnWheel = false;
            this.painelMysql.VerticalScrollbarSize = 10;
            // 
            // btSelecionarArquivo
            // 
            this.btSelecionarArquivo.Location = new System.Drawing.Point(707, 23);
            this.btSelecionarArquivo.Name = "btSelecionarArquivo";
            this.btSelecionarArquivo.Size = new System.Drawing.Size(65, 23);
            this.btSelecionarArquivo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btSelecionarArquivo.TabIndex = 5;
            this.btSelecionarArquivo.Text = "Buscar";
            this.btSelecionarArquivo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btSelecionarArquivo.UseSelectable = true;
            this.btSelecionarArquivo.Click += new System.EventHandler(this.btSelecionarArquivo_Click);
            // 
            // txtCaminhoArquivo
            // 
            // 
            // 
            // 
            this.txtCaminhoArquivo.CustomButton.Image = null;
            this.txtCaminhoArquivo.CustomButton.Location = new System.Drawing.Point(408, 2);
            this.txtCaminhoArquivo.CustomButton.Name = "";
            this.txtCaminhoArquivo.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtCaminhoArquivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCaminhoArquivo.CustomButton.TabIndex = 1;
            this.txtCaminhoArquivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCaminhoArquivo.CustomButton.UseSelectable = true;
            this.txtCaminhoArquivo.CustomButton.Visible = false;
            this.txtCaminhoArquivo.Lines = new string[] {
        "C:\\"};
            this.txtCaminhoArquivo.Location = new System.Drawing.Point(271, 22);
            this.txtCaminhoArquivo.MaxLength = 32767;
            this.txtCaminhoArquivo.Name = "txtCaminhoArquivo";
            this.txtCaminhoArquivo.PasswordChar = '\0';
            this.txtCaminhoArquivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCaminhoArquivo.SelectedText = "";
            this.txtCaminhoArquivo.SelectionLength = 0;
            this.txtCaminhoArquivo.SelectionStart = 0;
            this.txtCaminhoArquivo.ShortcutsEnabled = true;
            this.txtCaminhoArquivo.Size = new System.Drawing.Size(430, 24);
            this.txtCaminhoArquivo.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtCaminhoArquivo.TabIndex = 4;
            this.txtCaminhoArquivo.Text = "C:\\";
            this.txtCaminhoArquivo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCaminhoArquivo.UseSelectable = true;
            this.txtCaminhoArquivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCaminhoArquivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // radioSelecionaTabelas
            // 
            this.radioSelecionaTabelas.AutoSize = true;
            this.radioSelecionaTabelas.Location = new System.Drawing.Point(409, 61);
            this.radioSelecionaTabelas.Name = "radioSelecionaTabelas";
            this.radioSelecionaTabelas.Size = new System.Drawing.Size(118, 15);
            this.radioSelecionaTabelas.Style = MetroFramework.MetroColorStyle.Yellow;
            this.radioSelecionaTabelas.TabIndex = 3;
            this.radioSelecionaTabelas.Text = "Selecionar Tabelas";
            this.radioSelecionaTabelas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioSelecionaTabelas.UseSelectable = true;
            this.radioSelecionaTabelas.CheckedChanged += new System.EventHandler(this.radioSelecionaTabelas_CheckedChanged);
            // 
            // radioCompleto
            // 
            this.radioCompleto.AutoSize = true;
            this.radioCompleto.Checked = true;
            this.radioCompleto.Location = new System.Drawing.Point(271, 61);
            this.radioCompleto.Name = "radioCompleto";
            this.radioCompleto.Size = new System.Drawing.Size(118, 15);
            this.radioCompleto.Style = MetroFramework.MetroColorStyle.Yellow;
            this.radioCompleto.TabIndex = 2;
            this.radioCompleto.TabStop = true;
            this.radioCompleto.Text = "Backup Completo";
            this.radioCompleto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioCompleto.UseSelectable = true;
            this.radioCompleto.CheckedChanged += new System.EventHandler(this.radioCompleto_CheckedChanged);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // txtLog
            // 
            // 
            // 
            // 
            this.txtLog.CustomButton.Image = null;
            this.txtLog.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtLog.CustomButton.Name = "";
            this.txtLog.CustomButton.Size = new System.Drawing.Size(225, 225);
            this.txtLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLog.CustomButton.TabIndex = 1;
            this.txtLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLog.CustomButton.UseSelectable = true;
            this.txtLog.CustomButton.Visible = false;
            this.txtLog.Lines = new string[] {
        "..."};
            this.txtLog.Location = new System.Drawing.Point(12, 132);
            this.txtLog.MaxLength = 32767;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.PasswordChar = '\0';
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLog.SelectedText = "";
            this.txtLog.SelectionLength = 0;
            this.txtLog.SelectionStart = 0;
            this.txtLog.ShortcutsEnabled = true;
            this.txtLog.Size = new System.Drawing.Size(760, 230);
            this.txtLog.TabIndex = 6;
            this.txtLog.Text = "...";
            this.txtLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtLog.UseSelectable = true;
            this.txtLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(677, 61);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(95, 34);
            this.btIniciar.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btIniciar.TabIndex = 7;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btIniciar.UseSelectable = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // groupBanco
            // 
            this.groupBanco.BackColor = System.Drawing.Color.Transparent;
            this.groupBanco.Controls.Add(this.txtSenha);
            this.groupBanco.Controls.Add(this.lblSenha);
            this.groupBanco.Controls.Add(this.txtBanco);
            this.groupBanco.Controls.Add(this.lblBanco);
            this.groupBanco.Controls.Add(this.txtUser);
            this.groupBanco.Controls.Add(this.lblUser);
            this.groupBanco.Controls.Add(this.txtPorta);
            this.groupBanco.Controls.Add(this.lblPorta);
            this.groupBanco.Controls.Add(this.txtServidor);
            this.groupBanco.Controls.Add(this.lblServ);
            this.groupBanco.Location = new System.Drawing.Point(12, 13);
            this.groupBanco.Name = "groupBanco";
            this.groupBanco.Size = new System.Drawing.Size(253, 113);
            this.groupBanco.TabIndex = 8;
            this.groupBanco.TabStop = false;
            // 
            // txtSenha
            // 
            // 
            // 
            // 
            this.txtSenha.CustomButton.Image = null;
            this.txtSenha.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtSenha.CustomButton.Name = "";
            this.txtSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSenha.CustomButton.TabIndex = 1;
            this.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSenha.CustomButton.UseSelectable = true;
            this.txtSenha.CustomButton.Visible = false;
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(131, 79);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.ShortcutsEnabled = true;
            this.txtSenha.Size = new System.Drawing.Size(114, 23);
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtSenha.TabIndex = 9;
            this.txtSenha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtSenha.UseSelectable = true;
            this.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(131, 57);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(44, 19);
            this.lblSenha.TabIndex = 8;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtBanco
            // 
            // 
            // 
            // 
            this.txtBanco.CustomButton.Image = null;
            this.txtBanco.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtBanco.CustomButton.Name = "";
            this.txtBanco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBanco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBanco.CustomButton.TabIndex = 1;
            this.txtBanco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBanco.CustomButton.UseSelectable = true;
            this.txtBanco.CustomButton.Visible = false;
            this.txtBanco.Lines = new string[0];
            this.txtBanco.Location = new System.Drawing.Point(6, 79);
            this.txtBanco.MaxLength = 32767;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.PasswordChar = '\0';
            this.txtBanco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBanco.SelectedText = "";
            this.txtBanco.SelectionLength = 0;
            this.txtBanco.SelectionStart = 0;
            this.txtBanco.ShortcutsEnabled = true;
            this.txtBanco.Size = new System.Drawing.Size(114, 23);
            this.txtBanco.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtBanco.TabIndex = 7;
            this.txtBanco.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtBanco.UseSelectable = true;
            this.txtBanco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBanco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(6, 57);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(45, 19);
            this.lblBanco.TabIndex = 6;
            this.lblBanco.Text = "Banco";
            this.lblBanco.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(39, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[] {
        "root"};
            this.txtUser.Location = new System.Drawing.Point(131, 31);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(61, 23);
            this.txtUser.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "root";
            this.txtUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(131, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 19);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            this.lblUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPorta
            // 
            // 
            // 
            // 
            this.txtPorta.CustomButton.Image = null;
            this.txtPorta.CustomButton.Location = new System.Drawing.Point(19, 1);
            this.txtPorta.CustomButton.Name = "";
            this.txtPorta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorta.CustomButton.TabIndex = 1;
            this.txtPorta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorta.CustomButton.UseSelectable = true;
            this.txtPorta.CustomButton.Visible = false;
            this.txtPorta.Lines = new string[] {
        "3306"};
            this.txtPorta.Location = new System.Drawing.Point(204, 31);
            this.txtPorta.MaxLength = 32767;
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.PasswordChar = '\0';
            this.txtPorta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorta.SelectedText = "";
            this.txtPorta.SelectionLength = 0;
            this.txtPorta.SelectionStart = 0;
            this.txtPorta.ShortcutsEnabled = true;
            this.txtPorta.Size = new System.Drawing.Size(41, 23);
            this.txtPorta.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtPorta.TabIndex = 3;
            this.txtPorta.Text = "3306";
            this.txtPorta.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPorta.UseSelectable = true;
            this.txtPorta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(204, 9);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(41, 19);
            this.lblPorta.TabIndex = 2;
            this.lblPorta.Text = "Porta";
            this.lblPorta.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtServidor
            // 
            // 
            // 
            // 
            this.txtServidor.CustomButton.Image = null;
            this.txtServidor.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtServidor.CustomButton.Name = "";
            this.txtServidor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtServidor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtServidor.CustomButton.TabIndex = 1;
            this.txtServidor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtServidor.CustomButton.UseSelectable = true;
            this.txtServidor.CustomButton.Visible = false;
            this.txtServidor.Lines = new string[] {
        "localhost"};
            this.txtServidor.Location = new System.Drawing.Point(6, 31);
            this.txtServidor.MaxLength = 32767;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.PasswordChar = '\0';
            this.txtServidor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtServidor.SelectedText = "";
            this.txtServidor.SelectionLength = 0;
            this.txtServidor.SelectionStart = 0;
            this.txtServidor.ShortcutsEnabled = true;
            this.txtServidor.Size = new System.Drawing.Size(114, 23);
            this.txtServidor.Style = MetroFramework.MetroColorStyle.Yellow;
            this.txtServidor.TabIndex = 1;
            this.txtServidor.Text = "localhost";
            this.txtServidor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtServidor.UseSelectable = true;
            this.txtServidor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtServidor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.Location = new System.Drawing.Point(6, 9);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(59, 19);
            this.lblServ.TabIndex = 0;
            this.lblServ.Text = "Servidor";
            this.lblServ.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btVerificaConexao
            // 
            this.btVerificaConexao.Location = new System.Drawing.Point(271, 103);
            this.btVerificaConexao.Name = "btVerificaConexao";
            this.btVerificaConexao.Size = new System.Drawing.Size(110, 23);
            this.btVerificaConexao.Style = MetroFramework.MetroColorStyle.Yellow;
            this.btVerificaConexao.TabIndex = 9;
            this.btVerificaConexao.Text = "Verificar Conexão";
            this.btVerificaConexao.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btVerificaConexao.UseSelectable = true;
            this.btVerificaConexao.Click += new System.EventHandler(this.btVerificaConexao_Click);
            // 
            // checkListBancos
            // 
            this.checkListBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.checkListBancos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkListBancos.CheckOnClick = true;
            this.checkListBancos.ForeColor = System.Drawing.Color.Gray;
            this.checkListBancos.FormattingEnabled = true;
            this.checkListBancos.Location = new System.Drawing.Point(387, 132);
            this.checkListBancos.MultiColumn = true;
            this.checkListBancos.Name = "checkListBancos";
            this.checkListBancos.Size = new System.Drawing.Size(390, 227);
            this.checkListBancos.TabIndex = 10;
            this.checkListBancos.Visible = false;
            // 
            // frmMySql_Backups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.painelMysql);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMySql_Backups";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frmMySql_Backups_Load);
            this.painelMysql.ResumeLayout(false);
            this.painelMysql.PerformLayout();
            this.groupBanco.ResumeLayout(false);
            this.groupBanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroPanel painelMysql;
        private MetroFramework.Controls.MetroRadioButton radioCompleto;
        private MetroFramework.Controls.MetroRadioButton radioSelecionaTabelas;
        private MetroFramework.Controls.MetroTextBox txtCaminhoArquivo;
        private MetroFramework.Controls.MetroButton btSelecionarArquivo;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
        private MetroFramework.Controls.MetroTextBox txtLog;
        private MetroFramework.Controls.MetroButton btIniciar;
        private System.Windows.Forms.GroupBox groupBanco;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel lblSenha;
        private MetroFramework.Controls.MetroTextBox txtBanco;
        private MetroFramework.Controls.MetroLabel lblBanco;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroTextBox txtPorta;
        private MetroFramework.Controls.MetroLabel lblPorta;
        private MetroFramework.Controls.MetroTextBox txtServidor;
        private MetroFramework.Controls.MetroLabel lblServ;
        private MetroFramework.Controls.MetroButton btVerificaConexao;
        private System.Windows.Forms.CheckedListBox checkListBancos;
    }
}