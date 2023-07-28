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
    public partial class ElektronikRaporForm : Form
    {
        public ElektronikRaporForm()
        {
            InitializeComponent();
        }

        private void ElektronikRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.Elektronik' table. You can move, or remove it, as needed.
            this.ElektronikTableAdapter.Fill(this.db_usersDataSet.Elektronik);

            this.reportViewer1.RefreshReport();
        }
    }
}
