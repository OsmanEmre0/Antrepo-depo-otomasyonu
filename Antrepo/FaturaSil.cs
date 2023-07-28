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
    public partial class FaturaSil : Form
    {
        public FaturaSil()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Fatura.BaglantiAc();
                string Sorgu = "Delete from Fatura where Kimlik=" + txtID.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Fatura.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtID.Text + "Kayıt Silindi", "UYARI");
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
            cevap = MessageBox.Show(txtID.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "UAYRI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fatura frmGeri2 = new Fatura();
            frmGeri2.Show();
            this.Hide();
        }
    }
}
