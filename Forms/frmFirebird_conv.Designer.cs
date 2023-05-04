namespace DBSavior.Forms
{
    partial class frmFirebird_conv
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
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.painelFirebird = new MetroFramework.Controls.MetroPanel();
            this.txtConsoleFire = new MetroFramework.Controls.MetroTextBox();
            this.groupDriveFire = new System.Windows.Forms.GroupBox();
            this.lblDrive = new MetroFramework.Controls.MetroLabel();
            this.radioFire40 = new MetroFramework.Controls.MetroRadioButton();
            this.radioFire30 = new MetroFramework.Controls.MetroRadioButton();
            this.radioFire25 = new MetroFramework.Controls.MetroRadioButton();
            this.radioFire20 = new MetroFramework.Controls.MetroRadioButton();
            this.btBtoK = new MetroFramework.Controls.MetroButton();
            this.btKtoB = new MetroFramework.Controls.MetroButton();
            this.btBuscarB = new MetroFramework.Controls.MetroButton();
            this.btBuscarK = new MetroFramework.Controls.MetroButton();
            this.txtArquivoB = new MetroFramework.Controls.MetroTextBox();
            this.lblArquivoB = new MetroFramework.Controls.MetroLabel();
            this.txtArquivoK = new MetroFramework.Controls.MetroTextBox();
            this.lblArquivoK = new MetroFramework.Controls.MetroLabel();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.painelFirebird.SuspendLayout();
            this.groupDriveFire.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // painelFirebird
            // 
            this.painelFirebird.Controls.Add(this.txtConsoleFire);
            this.painelFirebird.Controls.Add(this.groupDriveFire);
            this.painelFirebird.Controls.Add(this.btBtoK);
            this.painelFirebird.Controls.Add(this.btKtoB);
            this.painelFirebird.Controls.Add(this.btBuscarB);
            this.painelFirebird.Controls.Add(this.btBuscarK);
            this.painelFirebird.Controls.Add(this.txtArquivoB);
            this.painelFirebird.Controls.Add(this.lblArquivoB);
            this.painelFirebird.Controls.Add(this.txtArquivoK);
            this.painelFirebird.Controls.Add(this.lblArquivoK);
            this.painelFirebird.HorizontalScrollbarBarColor = true;
            this.painelFirebird.HorizontalScrollbarHighlightOnWheel = false;
            this.painelFirebird.HorizontalScrollbarSize = 10;
            this.painelFirebird.Location = new System.Drawing.Point(0, 0);
            this.painelFirebird.Name = "painelFirebird";
            this.painelFirebird.Size = new System.Drawing.Size(792, 374);
            this.painelFirebird.TabIndex = 4;
            this.painelFirebird.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.painelFirebird.VerticalScrollbarBarColor = true;
            this.painelFirebird.VerticalScrollbarHighlightOnWheel = false;
            this.painelFirebird.VerticalScrollbarSize = 10;
            // 
            // txtConsoleFire
            // 
            // 
            // 
            // 
            this.txtConsoleFire.CustomButton.Image = null;
            this.txtConsoleFire.CustomButton.Location = new System.Drawing.Point(566, 1);
            this.txtConsoleFire.CustomButton.Name = "";
            this.txtConsoleFire.CustomButton.Size = new System.Drawing.Size(187, 187);
            this.txtConsoleFire.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsoleFire.CustomButton.TabIndex = 1;
            this.txtConsoleFire.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsoleFire.CustomButton.UseSelectable = true;
            this.txtConsoleFire.CustomButton.Visible = false;
            this.txtConsoleFire.Lines = new string[] {
        "Aguardando início..."};
            this.txtConsoleFire.Location = new System.Drawing.Point(20, 175);
            this.txtConsoleFire.MaxLength = 32767;
            this.txtConsoleFire.Multiline = true;
            this.txtConsoleFire.Name = "txtConsoleFire";
            this.txtConsoleFire.PasswordChar = '\0';
            this.txtConsoleFire.ReadOnly = true;
            this.txtConsoleFire.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsoleFire.SelectedText = "";
            this.txtConsoleFire.SelectionLength = 0;
            this.txtConsoleFire.SelectionStart = 0;
            this.txtConsoleFire.ShortcutsEnabled = true;
            this.txtConsoleFire.Size = new System.Drawing.Size(754, 189);
            this.txtConsoleFire.Style = MetroFramework.MetroColorStyle.Red;
            this.txtConsoleFire.TabIndex = 11;
            this.txtConsoleFire.Text = "Aguardando início...";
            this.txtConsoleFire.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtConsoleFire.UseSelectable = true;
            this.txtConsoleFire.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsoleFire.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupDriveFire
            // 
            this.groupDriveFire.BackColor = System.Drawing.Color.Transparent;
            this.groupDriveFire.Controls.Add(this.lblDrive);
            this.groupDriveFire.Controls.Add(this.radioFire40);
            this.groupDriveFire.Controls.Add(this.radioFire30);
            this.groupDriveFire.Controls.Add(this.radioFire25);
            this.groupDriveFire.Controls.Add(this.radioFire20);
            this.groupDriveFire.Location = new System.Drawing.Point(380, 118);
            this.groupDriveFire.Name = "groupDriveFire";
            this.groupDriveFire.Size = new System.Drawing.Size(394, 51);
            this.groupDriveFire.TabIndex = 10;
            this.groupDriveFire.TabStop = false;
            // 
            // lblDrive
            // 
            this.lblDrive.AutoSize = true;
            this.lblDrive.Location = new System.Drawing.Point(7, -3);
            this.lblDrive.Name = "lblDrive";
            this.lblDrive.Size = new System.Drawing.Size(39, 19);
            this.lblDrive.Style = MetroFramework.MetroColorStyle.Red;
            this.lblDrive.TabIndex = 5;
            this.lblDrive.Text = "Drive";
            this.lblDrive.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // radioFire40
            // 
            this.radioFire40.AutoSize = true;
            this.radioFire40.Location = new System.Drawing.Point(303, 23);
            this.radioFire40.Name = "radioFire40";
            this.radioFire40.Size = new System.Drawing.Size(81, 15);
            this.radioFire40.Style = MetroFramework.MetroColorStyle.Red;
            this.radioFire40.TabIndex = 3;
            this.radioFire40.Text = "Firebird 4.0";
            this.radioFire40.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioFire40.UseSelectable = true;
            // 
            // radioFire30
            // 
            this.radioFire30.AutoSize = true;
            this.radioFire30.Location = new System.Drawing.Point(204, 23);
            this.radioFire30.Name = "radioFire30";
            this.radioFire30.Size = new System.Drawing.Size(81, 15);
            this.radioFire30.Style = MetroFramework.MetroColorStyle.Red;
            this.radioFire30.TabIndex = 2;
            this.radioFire30.Text = "Firebird 3.0";
            this.radioFire30.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioFire30.UseSelectable = true;
            // 
            // radioFire25
            // 
            this.radioFire25.AutoSize = true;
            this.radioFire25.Location = new System.Drawing.Point(105, 23);
            this.radioFire25.Name = "radioFire25";
            this.radioFire25.Size = new System.Drawing.Size(81, 15);
            this.radioFire25.Style = MetroFramework.MetroColorStyle.Red;
            this.radioFire25.TabIndex = 1;
            this.radioFire25.Text = "Firebird 2.5";
            this.radioFire25.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioFire25.UseSelectable = true;
            // 
            // radioFire20
            // 
            this.radioFire20.AutoSize = true;
            this.radioFire20.Location = new System.Drawing.Point(7, 23);
            this.radioFire20.Name = "radioFire20";
            this.radioFire20.Size = new System.Drawing.Size(81, 15);
            this.radioFire20.Style = MetroFramework.MetroColorStyle.Red;
            this.radioFire20.TabIndex = 0;
            this.radioFire20.Text = "Firebird 2.0";
            this.radioFire20.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.radioFire20.UseSelectable = true;
            // 
            // btBtoK
            // 
            this.btBtoK.Enabled = false;
            this.btBtoK.Location = new System.Drawing.Point(132, 126);
            this.btBtoK.Name = "btBtoK";
            this.btBtoK.Size = new System.Drawing.Size(96, 35);
            this.btBtoK.Style = MetroFramework.MetroColorStyle.Red;
            this.btBtoK.TabIndex = 9;
            this.btBtoK.Text = ".FDB -> .FBK";
            this.btBtoK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btBtoK.UseSelectable = true;
            // 
            // btKtoB
            // 
            this.btKtoB.Location = new System.Drawing.Point(20, 126);
            this.btKtoB.Name = "btKtoB";
            this.btKtoB.Size = new System.Drawing.Size(97, 35);
            this.btKtoB.Style = MetroFramework.MetroColorStyle.Red;
            this.btKtoB.TabIndex = 8;
            this.btKtoB.Text = ".FBK -> .FDB";
            this.btKtoB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btKtoB.UseSelectable = true;
            this.btKtoB.Click += new System.EventHandler(this.btKtoB_Click);
            // 
            // btBuscarB
            // 
            this.btBuscarB.Location = new System.Drawing.Point(699, 89);
            this.btBuscarB.Name = "btBuscarB";
            this.btBuscarB.Size = new System.Drawing.Size(75, 23);
            this.btBuscarB.Style = MetroFramework.MetroColorStyle.Red;
            this.btBuscarB.TabIndex = 7;
            this.btBuscarB.Text = "Buscar";
            this.btBuscarB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btBuscarB.UseSelectable = true;
            this.btBuscarB.Click += new System.EventHandler(this.btBuscarB_Click);
            // 
            // btBuscarK
            // 
            this.btBuscarK.Location = new System.Drawing.Point(699, 41);
            this.btBuscarK.Name = "btBuscarK";
            this.btBuscarK.Size = new System.Drawing.Size(75, 23);
            this.btBuscarK.Style = MetroFramework.MetroColorStyle.Red;
            this.btBuscarK.TabIndex = 6;
            this.btBuscarK.Text = "Buscar";
            this.btBuscarK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btBuscarK.UseSelectable = true;
            this.btBuscarK.Click += new System.EventHandler(this.btBuscarK_Click);
            // 
            // txtArquivoB
            // 
            // 
            // 
            // 
            this.txtArquivoB.CustomButton.Image = null;
            this.txtArquivoB.CustomButton.Location = new System.Drawing.Point(644, 1);
            this.txtArquivoB.CustomButton.Name = "";
            this.txtArquivoB.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtArquivoB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArquivoB.CustomButton.TabIndex = 1;
            this.txtArquivoB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtArquivoB.CustomButton.UseSelectable = true;
            this.txtArquivoB.CustomButton.Visible = false;
            this.txtArquivoB.Lines = new string[] {
        "C:\\"};
            this.txtArquivoB.Location = new System.Drawing.Point(20, 89);
            this.txtArquivoB.MaxLength = 32767;
            this.txtArquivoB.Multiline = true;
            this.txtArquivoB.Name = "txtArquivoB";
            this.txtArquivoB.PasswordChar = '\0';
            this.txtArquivoB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArquivoB.SelectedText = "";
            this.txtArquivoB.SelectionLength = 0;
            this.txtArquivoB.SelectionStart = 0;
            this.txtArquivoB.ShortcutsEnabled = true;
            this.txtArquivoB.Size = new System.Drawing.Size(666, 23);
            this.txtArquivoB.Style = MetroFramework.MetroColorStyle.Red;
            this.txtArquivoB.TabIndex = 5;
            this.txtArquivoB.Text = "C:\\";
            this.txtArquivoB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtArquivoB.UseSelectable = true;
            this.txtArquivoB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArquivoB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblArquivoB
            // 
            this.lblArquivoB.AutoSize = true;
            this.lblArquivoB.Location = new System.Drawing.Point(20, 67);
            this.lblArquivoB.Name = "lblArquivoB";
            this.lblArquivoB.Size = new System.Drawing.Size(86, 19);
            this.lblArquivoB.Style = MetroFramework.MetroColorStyle.Red;
            this.lblArquivoB.TabIndex = 4;
            this.lblArquivoB.Text = "Arquivo .FDB";
            this.lblArquivoB.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtArquivoK
            // 
            // 
            // 
            // 
            this.txtArquivoK.CustomButton.Image = null;
            this.txtArquivoK.CustomButton.Location = new System.Drawing.Point(644, 1);
            this.txtArquivoK.CustomButton.Name = "";
            this.txtArquivoK.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtArquivoK.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtArquivoK.CustomButton.TabIndex = 1;
            this.txtArquivoK.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtArquivoK.CustomButton.UseSelectable = true;
            this.txtArquivoK.CustomButton.Visible = false;
            this.txtArquivoK.Lines = new string[] {
        "C:\\"};
            this.txtArquivoK.Location = new System.Drawing.Point(20, 41);
            this.txtArquivoK.MaxLength = 32767;
            this.txtArquivoK.Name = "txtArquivoK";
            this.txtArquivoK.PasswordChar = '\0';
            this.txtArquivoK.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtArquivoK.SelectedText = "";
            this.txtArquivoK.SelectionLength = 0;
            this.txtArquivoK.SelectionStart = 0;
            this.txtArquivoK.ShortcutsEnabled = true;
            this.txtArquivoK.Size = new System.Drawing.Size(666, 23);
            this.txtArquivoK.Style = MetroFramework.MetroColorStyle.Red;
            this.txtArquivoK.TabIndex = 3;
            this.txtArquivoK.Text = "C:\\";
            this.txtArquivoK.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtArquivoK.UseSelectable = true;
            this.txtArquivoK.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtArquivoK.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtArquivoK.Leave += new System.EventHandler(this.txtArquivoK_Leave);
            // 
            // lblArquivoK
            // 
            this.lblArquivoK.AutoSize = true;
            this.lblArquivoK.Location = new System.Drawing.Point(20, 19);
            this.lblArquivoK.Name = "lblArquivoK";
            this.lblArquivoK.Size = new System.Drawing.Size(84, 19);
            this.lblArquivoK.Style = MetroFramework.MetroColorStyle.Red;
            this.lblArquivoK.TabIndex = 2;
            this.lblArquivoK.Text = "Arquivo .FBK";
            this.lblArquivoK.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // frmFirebird_conv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.painelFirebird);
            this.MaximizeBox = false;
            this.Name = "frmFirebird_conv";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = " F";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFirebird_conv_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.painelFirebird.ResumeLayout(false);
            this.painelFirebird.PerformLayout();
            this.groupDriveFire.ResumeLayout(false);
            this.groupDriveFire.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton btKtoB;
        private MetroFramework.Controls.MetroButton btBuscarB;
        private MetroFramework.Controls.MetroButton btBuscarK;
        private MetroFramework.Controls.MetroTextBox txtArquivoB;
        private MetroFramework.Controls.MetroLabel lblArquivoB;
        private MetroFramework.Controls.MetroTextBox txtArquivoK;
        private MetroFramework.Controls.MetroLabel lblArquivoK;
        private System.Windows.Forms.GroupBox groupDriveFire;
        private MetroFramework.Controls.MetroButton btBtoK;
        private MetroFramework.Controls.MetroRadioButton radioFire40;
        private MetroFramework.Controls.MetroRadioButton radioFire30;
        private MetroFramework.Controls.MetroRadioButton radioFire25;
        private MetroFramework.Controls.MetroRadioButton radioFire20;
        private MetroFramework.Controls.MetroTextBox txtConsoleFire;
        public MetroFramework.Controls.MetroPanel painelFirebird;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private MetroFramework.Controls.MetroLabel lblDrive;
    }
}