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
    public partial class GirişFişiRaporForm : Form
    {
        public GirişFişiRaporForm()
        {
            InitializeComponent();
        }

        private void GirişFişiRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.GirişFişiİşlemleri' table. You can move, or remove it, as needed.
            this.GirişFişiİşlemleriTableAdapter.Fill(this.db_usersDataSet.GirişFişiİşlemleri);

            this.reportViewer1.RefreshReport();
        }
    }
}
