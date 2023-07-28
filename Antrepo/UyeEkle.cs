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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }


        public void KayitEkle()
        {
            try
            {
                Personel.BaglantiAc();
                string Sorgu = "Insert Into Kallanıcı (Kullaniciadi,Sifre) Values (@Kullaniciadi,@Sifre)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Personel.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Kullaniciadi", txtKullanici.Text);
                EkleKomut.Parameters.AddWithValue("@Sifre", txtSifre.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSifre.Text = "";
            txtKullanici.Text = "";
            txtKullanici.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tanımlama frmper = new Tanımlama();
            frmper.Show();
            this.Hide();
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtKullanici.BackColor = Color.White;
            txtSifre.BackColor = Color.White;
            
            if(txtKullanici.Text=="")
            {
                txtKullanici.BackColor = Color.Red;
                txtKullanici.Focus();
                bos = true;
            }

            if (txtSifre.Text == "")
            {
                txtSifre.BackColor = Color.Red;
                txtSifre.Focus();
                bos = true;
            }

            return bos;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }
    }
}
