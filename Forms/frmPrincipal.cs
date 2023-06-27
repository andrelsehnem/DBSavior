using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSavior.Forms;
using static DBSavior.Class.Globals;

namespace DBSavior
{
    public partial class frmPrincipal : MetroFramework.Forms.MetroForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btFbkFdb_Click(object sender, EventArgs e)
        {
            painelFirebird.Controls.Clear();    
            frmFirebird_conv f = new frmFirebird_conv(FirebirdType.fbkFbd);
            painelFirebird.Controls.Add(f.painelFirebird);
            //f.ShowDialog();
        }

        private void btGkbGbd_Click(object sender, EventArgs e)
        {
            painelFirebird.Controls.Clear();
            frmFirebird_conv f = new frmFirebird_conv(FirebirdType.gbkGbd);
            painelFirebird.Controls.Add(f.painelFirebird);
        }

        private void btPostgPsql_Click(object sender, EventArgs e)
        {
            painelPostgres.Controls.Clear();
            frmPostgre_restore f = new frmPostgre_restore(PostgresType.psql);
            painelPostgres.Controls.Add(f.painelPostg);
        }

        private void btPgdmp_Click(object sender, EventArgs e)
        {
            painelPostgres.Controls.Clear();
            frmPostgre_restore f = new frmPostgre_restore(PostgresType.pg_restore);
            painelPostgres.Controls.Add(f.painelPostg);   
        }

        public void ChangeStyle(MetroFramework.MetroColorStyle color)
        {
            metroStyleManager.Style = color;
            this.Style = metroStyleManager.Style;
            metroTabControl1.Style = metroStyleManager.Style;
            this.Refresh(); 
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (metroTabControl1.SelectedIndex)
            {
                case 0:
                    ChangeStyle(MetroFramework.MetroColorStyle.Yellow);
                    break;
                case 1:
                    ChangeStyle(MetroFramework.MetroColorStyle.Red);
                    break;
                case 2:
                    ChangeStyle(MetroFramework.MetroColorStyle.Blue);
                    break;
            }
        }
    }
}
