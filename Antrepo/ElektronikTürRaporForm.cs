using System;
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
    public partial class ElektronikTürRaporForm : Form
    {
        public ElektronikTürRaporForm()
        {
            InitializeComponent();
        }

        private void ElektronikTürRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.Elektronik' table. You can move, or remove it, as needed.
            this.ElektronikTableAdapter.Fill(this.db_usersDataSet.Elektronik);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ElektronikBindingSource.Filter = "Marka='" + cmbMarkaArama.Text + "'";
            this.reportViewer1.RefreshReport();
        }
    }
}
