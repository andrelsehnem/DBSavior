namespace DBSavior.Forms
{
    partial class frmPostgre_restore
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
            this.painelPostg = new MetroFramework.Controls.MetroPanel();
            this.txtConsole = new MetroFramework.Controls.MetroTextBox();
            this.groupBanco = new System.Windows.Forms.GroupBox();
            this.txtBanco = new MetroFramework.Controls.MetroTextBox();
            this.lblBanco = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.lblUser = new MetroFramework.Controls.MetroLabel();
            this.txtPorta = new MetroFramework.Controls.MetroTextBox();
            this.lblPorta = new MetroFramework.Controls.MetroLabel();
            this.txtServidor = new MetroFramework.Controls.MetroTextBox();
            this.lblServ = new MetroFramework.Controls.MetroLabel();
            this.btBuscar = new MetroFramework.Controls.MetroButton();
            this.txtArquivo = new MetroFramework.Controls.MetroTextBox();
            this.lblArquivo = new MetroFramework.Controls.MetroLabel();
            this.btIniciar = new MetroFramework.Controls.MetroButton();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.lblSenha = new MetroFramework.Controls.MetroLabel();
            this.painelPostg.SuspendLayout();
            this.groupBanco.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelPostg
            // 
            this.painelPostg.Controls.Add(this.btIniciar);
            this.painelPostg.Controls.Add(this.btBuscar);
            this.painelPostg.Controls.Add(this.txtArquivo);
            this.painelPostg.Controls.Add(this.lblArquivo);
            this.painelPostg.Controls.Add(this.txtConsole);
            this.painelPostg.Controls.Add(this.groupBanco);
            this.painelPostg.HorizontalScrollbarBarColor = true;
            this.painelPostg.HorizontalScrollbarHighlightOnWheel = false;
            this.painelPostg.HorizontalScrollbarSize = 10;
            this.painelPostg.Location = new System.Drawing.Point(0, 0);
            this.painelPostg.Name = "painelPostg";
            this.painelPostg.Size = new System.Drawing.Size(792, 375);
            this.painelPostg.Style = MetroFramework.MetroColorStyle.Blue;
            this.painelPostg.TabIndex = 0;
            this.painelPostg.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.painelPostg.VerticalScrollbarBarColor = true;
            this.painelPostg.VerticalScrollbarHighlightOnWheel = false;
            this.painelPostg.VerticalScrollbarSize = 10;
            // 
            // txtConsole
            // 
            // 
            // 
            // 
            this.txtConsole.CustomButton.Image = null;
            this.txtConsole.CustomButton.Location = new System.Drawing.Point(528, 1);
            this.txtConsole.CustomButton.Name = "";
            this.txtConsole.CustomButton.Size = new System.Drawing.Size(239, 239);
            this.txtConsole.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsole.CustomButton.TabIndex = 1;
            this.txtConsole.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsole.CustomButton.UseSelectable = true;
            this.txtConsole.CustomButton.Visible = false;
            this.txtConsole.Lines = new string[] {
        "Aguardando início..."};
            this.txtConsole.Location = new System.Drawing.Point(9, 122);
            this.txtConsole.MaxLength = 32767;
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.PasswordChar = '\0';
            this.txtConsole.ReadOnly = true;
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsole.SelectedText = "";
            this.txtConsole.SelectionLength = 0;
            this.txtConsole.SelectionStart = 0;
            this.txtConsole.ShortcutsEnabled = true;
            this.txtConsole.ShowClearButton = true;
            this.txtConsole.Size = new System.Drawing.Size(768, 241);
            this.txtConsole.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsole.TabIndex = 12;
            this.txtConsole.Text = "Aguardando início...";
            this.txtConsole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtConsole.UseSelectable = true;
            this.txtConsole.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsole.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.groupBanco.Location = new System.Drawing.Point(9, 3);
            this.groupBanco.Name = "groupBanco";
            this.groupBanco.Size = new System.Drawing.Size(253, 113);
            this.groupBanco.TabIndex = 2;
            this.groupBanco.TabStop = false;
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
            this.txtBanco.Style = MetroFramework.MetroColorStyle.Blue;
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
        "postgres"};
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
            this.txtUser.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "postgres";
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
        "5432"};
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
            this.txtPorta.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorta.TabIndex = 3;
            this.txtPorta.Text = "5432";
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
            this.txtServidor.Style = MetroFramework.MetroColorStyle.Blue;
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
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(702, 34);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btBuscar.TabIndex = 15;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btBuscar.UseSelectable = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txtArquivo
            // 
            // 
            // 
            // 
            this.txtArquivo.CustomButton.Image = null;
            this.txtArquivo.CustomButton.Location = new System.Drawing.Point(406, 1);
            this.txtArquivo.CustomButton.Name = "";
            this.txtArquivo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtArquivo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArquivo.CustomButton.TabIndex = 1;
            this.txtArquivo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtArquivo.CustomButton.UseSelectable = true;
            this.txtArquivo.CustomButton.Visible = false;
            this.txtArquivo.Lines = new string[] {
        "C:\\"};
            this.txtArquivo.Location = new System.Drawing.Point(268, 34);
            this.txtArquivo.MaxLength = 32767;
            this.txtArquivo.Multiline = true;
            this.txtArquivo.Name = "txtArquivo";
            this.txtArquivo.PasswordChar = '\0';
            this.txtArquivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArquivo.SelectedText = "";
            this.txtArquivo.SelectionLength = 0;
            this.txtArquivo.SelectionStart = 0;
            this.txtArquivo.ShortcutsEnabled = true;
            this.txtArquivo.Size = new System.Drawing.Size(428, 23);
            this.txtArquivo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArquivo.TabIndex = 14;
            this.txtArquivo.Text = "C:\\";
            this.txtArquivo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtArquivo.UseSelectable = true;
            this.txtArquivo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArquivo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArquivo
            // 
            this.lblArquivo.AutoSize = true;
            this.lblArquivo.Location = new System.Drawing.Point(268, 12);
            this.lblArquivo.Name = "lblArquivo";
            this.lblArquivo.Size = new System.Drawing.Size(122, 19);
            this.lblArquivo.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblArquivo.TabIndex = 13;
            this.lblArquivo.Text = "Arquivo a restaurar";
            this.lblArquivo.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(702, 71);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 45);
            this.btIniciar.Style = MetroFramework.MetroColorStyle.Blue;
            this.btIniciar.TabIndex = 16;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btIniciar.UseSelectable = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
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
            this.txtSenha.Style = MetroFramework.MetroColorStyle.Blue;
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
            // frmPostgre_restore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelPostg);
            this.Name = "frmPostgre_restore";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "frmPostgre_restore";
            this.Load += new System.EventHandler(this.frmPostgre_restore_Load);
            this.painelPostg.ResumeLayout(false);
            this.painelPostg.PerformLayout();
            this.groupBanco.ResumeLayout(false);
            this.groupBanco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBanco;
        private MetroFramework.Controls.MetroTextBox txtBanco;
        private MetroFramework.Controls.MetroLabel lblBanco;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroLabel lblUser;
        private MetroFramework.Controls.MetroTextBox txtPorta;
        private MetroFramework.Controls.MetroLabel lblPorta;
        private MetroFramework.Controls.MetroTextBox txtServidor;
        private MetroFramework.Controls.MetroLabel lblServ;
        private MetroFramework.Controls.MetroButton btBuscar;
        private MetroFramework.Controls.MetroTextBox txtArquivo;
        private MetroFramework.Controls.MetroLabel lblArquivo;
        private MetroFramework.Controls.MetroButton btIniciar;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        public MetroFramework.Controls.MetroTextBox txtConsole;
        public MetroFramework.Controls.MetroPanel painelPostg;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroLabel lblSenha;
    }
}