namespace DBSavior
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabMySQL = new MetroFramework.Controls.MetroTabPage();
            this.tabFirebird = new MetroFramework.Controls.MetroTabPage();
            this.btGkbGbd = new MetroFramework.Controls.MetroButton();
            this.painelFirebird = new MetroFramework.Controls.MetroPanel();
            this.btFbkFdb = new MetroFramework.Controls.MetroButton();
            this.tabPostgre = new MetroFramework.Controls.MetroTabPage();
            this.btPostgSql = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btPgdmp = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabFirebird.SuspendLayout();
            this.tabPostgre.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.tabMySQL);
            this.metroTabControl1.Controls.Add(this.tabFirebird);
            this.metroTabControl1.Controls.Add(this.tabPostgre);
            this.metroTabControl1.HotTrack = true;
            this.metroTabControl1.Location = new System.Drawing.Point(2, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(792, 467);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Yellow;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabMySQL
            // 
            this.tabMySQL.HorizontalScrollbarBarColor = true;
            this.tabMySQL.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMySQL.HorizontalScrollbarSize = 10;
            this.tabMySQL.Location = new System.Drawing.Point(4, 41);
            this.tabMySQL.Name = "tabMySQL";
            this.tabMySQL.Size = new System.Drawing.Size(784, 422);
            this.tabMySQL.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tabMySQL.TabIndex = 0;
            this.tabMySQL.Text = "MySQL";
            this.tabMySQL.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabMySQL.VerticalScrollbarBarColor = true;
            this.tabMySQL.VerticalScrollbarHighlightOnWheel = false;
            this.tabMySQL.VerticalScrollbarSize = 10;
            // 
            // tabFirebird
            // 
            this.tabFirebird.Controls.Add(this.btGkbGbd);
            this.tabFirebird.Controls.Add(this.painelFirebird);
            this.tabFirebird.Controls.Add(this.btFbkFdb);
            this.tabFirebird.HorizontalScrollbarBarColor = true;
            this.tabFirebird.HorizontalScrollbarHighlightOnWheel = false;
            this.tabFirebird.HorizontalScrollbarSize = 10;
            this.tabFirebird.Location = new System.Drawing.Point(4, 41);
            this.tabFirebird.Name = "tabFirebird";
            this.tabFirebird.Size = new System.Drawing.Size(784, 422);
            this.tabFirebird.Style = MetroFramework.MetroColorStyle.Green;
            this.tabFirebird.TabIndex = 1;
            this.tabFirebird.Text = "Firebird";
            this.tabFirebird.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabFirebird.VerticalScrollbarBarColor = true;
            this.tabFirebird.VerticalScrollbarHighlightOnWheel = false;
            this.tabFirebird.VerticalScrollbarSize = 10;
            // 
            // btGkbGbd
            // 
            this.btGkbGbd.Location = new System.Drawing.Point(109, 15);
            this.btGkbGbd.Name = "btGkbGbd";
            this.btGkbGbd.Size = new System.Drawing.Size(98, 30);
            this.btGkbGbd.TabIndex = 4;
            this.btGkbGbd.Text = ".GBK -> .GDB";
            this.btGkbGbd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btGkbGbd.UseSelectable = true;
            // 
            // painelFirebird
            // 
            this.painelFirebird.HorizontalScrollbarBarColor = true;
            this.painelFirebird.HorizontalScrollbarHighlightOnWheel = false;
            this.painelFirebird.HorizontalScrollbarSize = 10;
            this.painelFirebird.Location = new System.Drawing.Point(-4, 51);
            this.painelFirebird.Name = "painelFirebird";
            this.painelFirebird.Size = new System.Drawing.Size(792, 374);
            this.painelFirebird.TabIndex = 3;
            this.painelFirebird.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.painelFirebird.VerticalScrollbarBarColor = true;
            this.painelFirebird.VerticalScrollbarHighlightOnWheel = false;
            this.painelFirebird.VerticalScrollbarSize = 10;
            // 
            // btFbkFdb
            // 
            this.btFbkFdb.Location = new System.Drawing.Point(5, 15);
            this.btFbkFdb.Name = "btFbkFdb";
            this.btFbkFdb.Size = new System.Drawing.Size(98, 30);
            this.btFbkFdb.TabIndex = 2;
            this.btFbkFdb.Text = ".FBK -> .FDB";
            this.btFbkFdb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btFbkFdb.UseSelectable = true;
            this.btFbkFdb.Click += new System.EventHandler(this.btFbkFdb_Click);
            // 
            // tabPostgre
            // 
            this.tabPostgre.Controls.Add(this.btPostgSql);
            this.tabPostgre.Controls.Add(this.metroPanel2);
            this.tabPostgre.Controls.Add(this.btPgdmp);
            this.tabPostgre.HorizontalScrollbarBarColor = true;
            this.tabPostgre.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPostgre.HorizontalScrollbarSize = 10;
            this.tabPostgre.Location = new System.Drawing.Point(4, 41);
            this.tabPostgre.Name = "tabPostgre";
            this.tabPostgre.Size = new System.Drawing.Size(784, 422);
            this.tabPostgre.Style = MetroFramework.MetroColorStyle.Green;
            this.tabPostgre.TabIndex = 3;
            this.tabPostgre.Text = "PostgreSQL";
            this.tabPostgre.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabPostgre.VerticalScrollbarBarColor = true;
            this.tabPostgre.VerticalScrollbarHighlightOnWheel = false;
            this.tabPostgre.VerticalScrollbarSize = 10;
            // 
            // btPostgSql
            // 
            this.btPostgSql.Location = new System.Drawing.Point(109, 15);
            this.btPostgSql.Name = "btPostgSql";
            this.btPostgSql.Size = new System.Drawing.Size(98, 30);
            this.btPostgSql.TabIndex = 4;
            this.btPostgSql.Text = "Restaurar .SQL";
            this.btPostgSql.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btPostgSql.UseSelectable = true;
            // 
            // metroPanel2
            // 
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(-4, 51);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(792, 375);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btPgdmp
            // 
            this.btPgdmp.Location = new System.Drawing.Point(5, 15);
            this.btPgdmp.Name = "btPgdmp";
            this.btPgdmp.Size = new System.Drawing.Size(98, 30);
            this.btPgdmp.TabIndex = 2;
            this.btPgdmp.Text = "Restaurar Pgdmp";
            this.btPgdmp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btPgdmp.UseSelectable = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 531);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmPrincipal";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "DBSavior";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabFirebird.ResumeLayout(false);
            this.tabPostgre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabMySQL;
        private MetroFramework.Controls.MetroTabPage tabFirebird;
        private MetroFramework.Controls.MetroButton btFbkFdb;
        private MetroFramework.Controls.MetroPanel painelFirebird;
        private MetroFramework.Controls.MetroButton btGkbGbd;
        private MetroFramework.Controls.MetroTabPage tabPostgre;
        private MetroFramework.Controls.MetroButton btPostgSql;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton btPgdmp;
    }
}

