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
    public partial class YurtdisiRaporForm : Form
    {
        public YurtdisiRaporForm()
        {
            InitializeComponent();
        }

        private void YurtdisiRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.YurtDisisevkiyat' table. You can move, or remove it, as needed.
            this.YurtDisisevkiyatTableAdapter.Fill(this.db_usersDataSet.YurtDisisevkiyat);

            this.reportViewer1.RefreshReport();
        }
    }
}
