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
    public partial class GıdaEkle : Form
    {
        public GıdaEkle()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Insert Into Gıda (isim,Tür,Adet,SonTuketim,GelişTarihi,GelişYeri,KGGelişFiyati) Values (@isim,@Tür,@Adet,@SonTuketim,@GelişTarihi,@GelişYeri,@KGGelişFiyati)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@isim", cmbÜrün.Text);
                EkleKomut.Parameters.AddWithValue("@Tür", cmdTür.Text);
                EkleKomut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                EkleKomut.Parameters.AddWithValue("@SonTuketim", txtSonTarih.Text);
                EkleKomut.Parameters.AddWithValue("@GelişTarihi", txtGelisTarih.Text);
                EkleKomut.Parameters.AddWithValue("@GelişYeri", cmbGelis.Text);
                EkleKomut.Parameters.AddWithValue("@KGGelişFiyati", txtFiyat.Text);
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
            txtAdet.BackColor = Color.White;
            txtGelisTarih.BackColor = Color.White;
            cmbGelis.BackColor = Color.White;
            txtSonTarih.BackColor = Color.White;
            cmbÜrün.BackColor = Color.White;
            cmdTür.BackColor = Color.White;
            txtFiyat.BackColor = Color.White;


            if (cmbÜrün.Text == "Ürün Seçiniz" || cmbÜrün.Text == "")
            {
                cmbÜrün.BackColor = Color.Red;
                cmbÜrün.Focus();
                bos = true;

            }


            if (cmdTür.Text == "Tür Seçiniz" || cmdTür.Text=="")
            {
                cmdTür.BackColor = Color.Red;
                cmdTür.Focus();
                bos = true;
            }

            //datetime kullanırsak txtDtar.Text==DateTime.Now.ToShortDateString() diye yazılabilir.

            if (txtSonTarih.Text == "  .  ." || txtSonTarih.Text.Length < txtSonTarih.TextLength)
            {
                txtSonTarih.BackColor = Color.Red;
                txtSonTarih.Focus();
                bos = true;
            }


            if (txtAdet.Text == "")
            {
                txtAdet.BackColor = Color.Red;
                txtAdet.Focus();
                bos = true;

            }


            if (txtGelisTarih.Text == "  .  ." || txtGelisTarih.Text.Length < txtSonTarih.TextLength)
            {
                txtGelisTarih.BackColor = Color.Red;
                txtGelisTarih.Focus();
                bos = true;
            }


            if (cmbGelis.Text == "Geliş Seçiniz" || cmbÜrün.Text == "")
            {
                cmbGelis.BackColor = Color.Red;
                cmbGelis.Focus();
                bos = true;
            }

            if (txtFiyat.Text == "")
            {
                txtFiyat.BackColor = Color.Red;
                txtFiyat.Focus();
                bos = true;

            }

            return bos;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tanımlama frm5 = new Tanımlama();
            frm5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbÜrün.Text = "";
            txtAdet.Text = "";
            txtGelisTarih.Text = "";
            txtSonTarih.Text = "";
            cmbÜrün.Text = "";
            cmdTür.Text = "";
            cmbGelis.Text = "";
            txtFiyat.Text = "";
            cmbÜrün.Focus();
        }

        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        private void GıdaEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
