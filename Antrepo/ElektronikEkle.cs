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
    public partial class ElektronikEkle : Form
    {
        public ElektronikEkle()
        {
            InitializeComponent();
        }


        public void KayitEkle()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Insert Into Elektronik (isim,GelişTarihi,Tür,Marka,Adet,GelişYeri,GelisFiyati,TaneFiyat) Values (@isim,@GelişTarihi,@Tür,@Marka,@Adet,@GelişYeri,@GelisFiyati,@TaneFiyat)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@isim", txtisim.Text);
                EkleKomut.Parameters.AddWithValue("@GelişTarihi", txtGelisTarihi1.Text);
                EkleKomut.Parameters.AddWithValue("@Tür", cmbTur.Text);
                EkleKomut.Parameters.AddWithValue("@Marka", cmbMarka.Text);
                EkleKomut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                EkleKomut.Parameters.AddWithValue("@GelişYeri", cmbGelisYeri.Text);
                EkleKomut.Parameters.AddWithValue("@GelisFiyati", txtGelisFiyati.Text);
                EkleKomut.Parameters.AddWithValue("@TaneFiyat", txtTaneFiyati.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }
        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtisim.BackColor = Color.White;
            txtAdet.BackColor = Color.White;
            txtGelisFiyati.BackColor = Color.White;
            txtGelisTarihi1.BackColor = Color.White;
            txtTaneFiyati.BackColor = Color.White;
            cmbGelisYeri.BackColor = Color.White;
            cmbMarka.BackColor = Color.White;
            cmbTur.BackColor = Color.White;


            if (cmbGelisYeri.Text == "Geliş Yeri Seçiniz" || cmbGelisYeri.Text == "")
            {
                cmbGelisYeri.BackColor = Color.Red;
                cmbGelisYeri.Focus();
                bos = true;

            }


            if (cmbTur.Text == "Tür Seçiniz" || cmbTur.Text == "")
            {
                cmbTur.BackColor = Color.Red;
                cmbTur.Focus();
                bos = true;
            }

            if (cmbMarka.Text == "Marka Seçiniz" || cmbMarka.Text == "")
            {
                cmbMarka.BackColor = Color.Red;
                cmbMarka.Focus();
                bos = true;
            }

            //datetime kullanırsak txtDtar.Text==DateTime.Now.ToShortDateString() diye yazılabilir.

            if (txtGelisTarihi1.Text == "  .  ." || txtGelisTarihi1.Text.Length < txtGelisTarihi1.TextLength)
            {
                txtGelisTarihi1.BackColor = Color.Red;
                txtGelisTarihi1.Focus();
                bos = true;
            }

            if (txtisim.Text == "")
            {
                txtisim.BackColor = Color.Red;
                txtisim.Focus();
                bos = true;

            }

            if (txtAdet.Text == "")
            {
                txtAdet.BackColor = Color.Red;
                txtAdet.Focus();
                bos = true;

            }


            

            if (txtTaneFiyati.Text == "")
            {
                txtTaneFiyati.BackColor = Color.Red;
                txtTaneFiyati.Focus();
                bos = true;

            }

            if (txtGelisFiyati.Text == "")
            {
                txtGelisFiyati.BackColor = Color.Red;
                txtGelisFiyati.Focus();
                bos = true;

            }

            return bos;

        }







        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtisim.Text = "";
            txtGelisTarihi1.Text = "";
            cmbTur.Text = "";
            cmbMarka.Text = "";
            txtAdet.Text = "";
            cmbGelisYeri.Text = "";
            txtGelisFiyati.Text = "";
            txtTaneFiyati.Text = "";
            txtisim.Focus();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Tanımlama frmElektronik = new Tanımlama();
            frmElektronik.Show();
            this.Hide();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }
    }
}
