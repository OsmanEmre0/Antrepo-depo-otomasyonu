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
    public partial class CikisFisiSil : Form
    {
        public CikisFisiSil()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Delete from ÇıkışFişiİşlemleri where Cikis_id=" + txtID16.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtID16.Text + "Kayıt Silindi", "UYARI");
                Stoklar.Baglanti.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, " Kayıt Sil Hata Penceresi");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtID16.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "UAYRI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparisİslemleri frmGeri2 = new Siparisİslemleri();
            frmGeri2.Show();
            this.Hide();
        }
    }
}
