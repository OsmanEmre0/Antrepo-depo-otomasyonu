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
    public partial class PersonelBirimRaporForm : Form
    {
        public PersonelBirimRaporForm()
        {
            InitializeComponent();
        }

        private void PersonelBirimRaporForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_usersDataSet.Personel' table. You can move, or remove it, as needed.
            this.PersonelTableAdapter.Fill(this.db_usersDataSet.Personel);

            this.reportViewer1.RefreshReport();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            PersonelBindingSource.Filter = "Soyadi='" + txtSoyadAra.Text + "'";

            this.reportViewer1.RefreshReport();
        }
    }
}
