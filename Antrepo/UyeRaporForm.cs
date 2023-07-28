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
    public partial class UyeRaporForm : Form
    {
        public UyeRaporForm()
        {
            InitializeComponent();
        }

        private void UyeRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.Kallanıcı' table. You can move, or remove it, as needed.
            this.KallanıcıTableAdapter.Fill(this.db_usersDataSet.Kallanıcı);

            this.reportViewer1.RefreshReport();
        }
    }
}
