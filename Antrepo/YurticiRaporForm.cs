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
    public partial class YurticiRaporForm : Form
    {
        public YurticiRaporForm()
        {
            InitializeComponent();
        }

        private void YurticiRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.Yurticisevkiyat' table. You can move, or remove it, as needed.
            this.YurticisevkiyatTableAdapter.Fill(this.db_usersDataSet.Yurticisevkiyat);

            this.reportViewer1.RefreshReport();
        }
    }
}
