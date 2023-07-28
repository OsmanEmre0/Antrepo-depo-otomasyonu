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
    public partial class HavaSil : Form
    {
        public HavaSil()
        {
            InitializeComponent();
        }

        public void KayitSil()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Delete from HavaTasiti where hava_id=" + txtID18.Text;
                OleDbCommand SilKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                if (SilKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtID18.Text + "Kayıt Silindi", "UYARI");
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
            cevap = MessageBox.Show(txtID18.Text + "Nolu Kayıt Silinecek\nOnaylıyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (cevap == DialogResult.Yes)


                KayitSil();
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "UAYRI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Taşıt frmgeri = new Taşıt();
            frmgeri.Show();
            this.Hide();
        }
    }
}
