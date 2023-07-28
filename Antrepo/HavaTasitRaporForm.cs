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
    public partial class HavaTasitRaporForm : Form
    {
        public HavaTasitRaporForm()
        {
            InitializeComponent();
        }

        private void HavaTasitRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.HavaTasiti' table. You can move, or remove it, as needed.
            this.HavaTasitiTableAdapter.Fill(this.db_usersDataSet.HavaTasiti);

            this.reportViewer1.RefreshReport();
        }
    }
}
