﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBSavior.Forms;

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
    }
}
