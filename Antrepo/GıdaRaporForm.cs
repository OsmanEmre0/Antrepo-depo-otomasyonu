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
    public partial class GıdaRaporForm : Form
    {
        public GıdaRaporForm()
        {
            InitializeComponent();
        }

        private void GıdaRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.Gıda' table. You can move, or remove it, as needed.
            this.GıdaTableAdapter.Fill(this.db_usersDataSet.Gıda);

            this.reportViewer1.RefreshReport();
        }
    }
}
