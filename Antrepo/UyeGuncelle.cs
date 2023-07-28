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
    public partial class UyeGuncelle : Form
    {
        public UyeGuncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Update Kallanıcı Set Kullaniciadi=@Kullaniciadi,Sifre=@Sifre where Uye_id=@Uye_id";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@İsim", txtKul.Text);
                DegistirKomut.Parameters.AddWithValue("@Tür", txtSif.Text);
                DegistirKomut.Parameters.AddWithValue("@ID", txtid.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtKul.Text + "" + txtKul.Text + "isimli kayıt Değiştirildi");
                Stoklar.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Değistir hata penceresi");
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtKul.BackColor = Color.White;
            txtSif.BackColor = Color.White;
            
            if(txtKul.Text=="")
            {
                txtKul.BackColor = Color.Red;
                txtKul.Focus();
                bos = true;
            }

            if (txtSif.Text == "")
            {
                txtSif.BackColor = Color.Red;
                txtSif.Focus();
                bos = true;
            }

            return bos;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Personel frmPer = new Personel();
            frmPer.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayıtDegistir();
        }
    }
}
