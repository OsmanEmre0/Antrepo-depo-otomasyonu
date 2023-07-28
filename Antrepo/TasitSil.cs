using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Antrepo
{
    public partial class TasitSil : Form
    {
        public TasitSil()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Delete from KaraTasit where ID=" + txtTasitID.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtTasitID.Text + "Kayıt Silindi", "UYARI");
                Stoklar.Baglanti.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, " Kayıt Sil Hata Penceresi");

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtTasitID.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "UAYRI",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Taşıt frmgeri = new Taşıt();
            frmgeri.Show();
            this.Hide();
        }
    }
}
