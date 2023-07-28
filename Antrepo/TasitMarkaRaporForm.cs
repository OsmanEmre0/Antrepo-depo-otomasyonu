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
    public partial class TasitMarkaRaporForm : Form
    {
        public TasitMarkaRaporForm()
        {
            InitializeComponent();
        }

        private void TasitMarkaRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.KaraTasit' table. You can move, or remove it, as needed.
            this.KaraTasitTableAdapter.Fill(this.db_usersDataSet.KaraTasit);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KaraTasitBindingSource.Filter = "Plaka='" + txtPlakaAra.Text + "'";

            this.reportViewer1.RefreshReport();
        }
    }
}
