﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antrepo
{
    public partial class FaturaRaporForm : Form
    {
        public FaturaRaporForm()
        {
            InitializeComponent();
        }

        private void FaturaRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.Fatura' table. You can move, or remove it, as needed.
            this.FaturaTableAdapter.Fill(this.db_usersDataSet.Fatura);

            this.reportViewer1.RefreshReport();
        }
    }
}
