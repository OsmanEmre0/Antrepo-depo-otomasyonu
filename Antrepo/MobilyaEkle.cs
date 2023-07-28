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
    public partial class MobilyaEkle : Form
    {
        public MobilyaEkle()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Insert Into Mobilya (GelişTarihi,Marka,Adet,GelişYeri,Tür,GelisFiyati,TaneFiyat) Values (@GelişTarihi,@Marka,@Adet,@GelişYeri,@Tür,@GelisFiyati,@TaneFiyati)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@GelişTarihi", txtGelisTarihi2.Text);
                EkleKomut.Parameters.AddWithValue("@Marka", cmbMarka2.Text);
                EkleKomut.Parameters.AddWithValue("@Adet", txtAdet2.Text);
                EkleKomut.Parameters.AddWithValue("@GelişYeri", cmbGelisYeri2.Text);
                EkleKomut.Parameters.AddWithValue("@Tür", cmbTur2.Text);
                EkleKomut.Parameters.AddWithValue("@GelisFiyati", txtGelisFiyati2.Text);
                EkleKomut.Parameters.AddWithValue("@TaneFiyat", txtTaneFiyati2.Text);
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
            txtAdet2.BackColor = Color.White;
            txtGelisFiyati2.BackColor = Color.White;
            txtGelisTarihi2.BackColor = Color.White;
            txtTaneFiyati2.BackColor = Color.White;
            cmbGelisYeri2.BackColor = Color.White;
            cmbMarka2.BackColor = Color.White;
            cmbTur2.BackColor = Color.White;


            if (cmbGelisYeri2.Text == "Geliş Yeri Seçiniz" || cmbGelisYeri2.Text == "")
            {
                cmbGelisYeri2.BackColor = Color.Red;
                cmbGelisYeri2.Focus();
                bos = true;

            }


            if (cmbTur2.Text == "Tür Seçiniz" || cmbTur2.Text == "")
            {
                cmbTur2.BackColor = Color.Red;
                cmbTur2.Focus();
                bos = true;
            }

            if (cmbMarka2.Text == "Marka Seçiniz" || cmbMarka2.Text == "")
            {
                cmbMarka2.BackColor = Color.Red;
                cmbMarka2.Focus();
                bos = true;
            }

            //datetime kullanırsak txtDtar.Text==DateTime.Now.ToShortDateString() diye yazılabilir.

            if (txtGelisTarihi2.Text == "  .  ." || txtGelisTarihi2.Text.Length < txtGelisTarihi2.TextLength)
            {
                txtGelisTarihi2.BackColor = Color.Red;
                txtGelisTarihi2.Focus();
                bos = true;
            }

            if (txtAdet2.Text == "")
            {
                txtAdet2.BackColor = Color.Red;
                txtAdet2.Focus();
                bos = true;

            }




            if (txtTaneFiyati2.Text == "")
            {
                txtTaneFiyati2.BackColor = Color.Red;
                txtTaneFiyati2.Focus();
                bos = true;

            }

            if (txtGelisFiyati2.Text == "")
            {
                txtGelisFiyati2.BackColor = Color.Red;
                txtGelisFiyati2.Focus();
                bos = true;

            }

            return bos;

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
            txtGelisTarihi2.Text = "";
            cmbTur2.Text = "";
            cmbMarka2.Text = "";
            txtAdet2.Text = "";
            cmbGelisYeri2.Text = "";
            txtGelisFiyati2.Text = "";
            txtTaneFiyati2.Text = "";
            txtGelisTarihi2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tanımlama frmMobilya = new Tanımlama();
            frmMobilya.Show();
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
