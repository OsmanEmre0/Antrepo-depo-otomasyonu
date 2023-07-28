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
    public partial class MobilyaRaporForm : Form
    {
        public MobilyaRaporForm()
        {
            InitializeComponent();
        }

        private void MobilyaRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.Mobilya' table. You can move, or remove it, as needed.
            this.MobilyaTableAdapter.Fill(this.db_usersDataSet.Mobilya);

            this.reportViewer1.RefreshReport();
        }
    }
}
