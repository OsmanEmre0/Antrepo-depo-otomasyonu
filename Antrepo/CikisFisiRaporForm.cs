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
    public partial class CikisFisiRaporForm : Form
    {
        public CikisFisiRaporForm()
        {
            InitializeComponent();
        }

        private void CikisFisiRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.ÇıkışFişiİşlemleri' table. You can move, or remove it, as needed.
            this.ÇıkışFişiİşlemleriTableAdapter.Fill(this.db_usersDataSet.ÇıkışFişiİşlemleri);

            this.reportViewer1.RefreshReport();
        }
    }
}
