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
    public partial class GıdaKayıtSil : Form
    {
        public GıdaKayıtSil()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Delete from Gıda where ID=" + txtID2.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtID2.Text + "Kayıt Silindi", "UYARI");
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
            cevap = MessageBox.Show(txtID2.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stoklar frmgeri = new Stoklar();
            frmgeri.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
