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
    public partial class UyeSil : Form
    {
        public UyeSil()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Personel.BaglantiAc();
                string Sorgu = "Delete from Kallanıcı where Uye_id=" + txtID11.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Personel.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtID11.Text + "Kayıt Silindi", "UYARI");
                Stoklar.Baglanti.Close();


            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, " Kayıt Sil Hata Penceresi");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personel frmPer = new Personel();
            frmPer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show(txtKUL.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "UAYRI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
