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
    public partial class YurtdışıSevkiyatSil : Form
    {
        public YurtdışıSevkiyatSil()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Sevkiyatİslemleri.BaglantiAc();
                string Sorgu = "Delete from YurtDisisevkiyat where Kimlik=" + txtYID.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Sevkiyatİslemleri.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtYID.Text + "Kayıt Silindi", "UYARI");
                Sevkiyatİslemleri.Baglanti.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, " Kayıt Sil Hata Penceresi");

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Sevkiyatİslemleri frm5 = new Sevkiyatİslemleri();
            frm5.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtYID.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "UAYRI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            Sevkiyatİslemleri frm5 = new Sevkiyatİslemleri();
            frm5.Show();
            this.Hide();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtYID.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "UAYRI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
