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
    public partial class CikisFisiEkle : Form
    {
        public CikisFisiEkle()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Insert Into ÇıkışFişiİşlemleri (Alici,TasimaTipi,Cekiciad,CekiciSoyad,MalinDegeri,MalDegeriKur,Malincinsi,Plaka,CikisTarihi,TasfiyeTarihi) Values (@Alici,@TasimaTipi,@Cekiciad,@CekiciSoyad,@MalinDegeri,@MalDegeriKur,@Malincinsi,@Plaka,@CikisTarihi,@TasfiyeTarihi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Alici", cmbAlici.Text);
                EkleKomut.Parameters.AddWithValue("@TasimaTipi", cmbTTipi.Text);
                EkleKomut.Parameters.AddWithValue("@Cekiciad", txtAdi.Text);
                EkleKomut.Parameters.AddWithValue("@CekiciSoyad", txtSoyadi.Text);
                EkleKomut.Parameters.AddWithValue("@MalinDegeri", txtMdegeri.Text);
                EkleKomut.Parameters.AddWithValue("@MalDegeriKur", txtMKurDegeri.Text);
                EkleKomut.Parameters.AddWithValue("@Malincinsi", cmbMcinsi.Text);
                EkleKomut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                EkleKomut.Parameters.AddWithValue("@CikisTarihi", txtCTarihi.Text);
                EkleKomut.Parameters.AddWithValue("@TasfiyeTarihi", txtTTarih.Text);
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
            cmbAlici.BackColor = Color.White;
            cmbTTipi.BackColor = Color.White;
            txtAdi.BackColor = Color.White;
            txtSoyadi.BackColor = Color.White;
            txtMdegeri.BackColor = Color.White;
            txtMKurDegeri.BackColor = Color.White;
            cmbMcinsi.BackColor = Color.White;
            txtPlaka.BackColor = Color.White;
            txtCTarihi.BackColor = Color.White;
            txtTTarih.BackColor = Color.White;


            if (cmbAlici.Text == "Alıcı Seçiniz" || cmbAlici.Text == "")
            {
                cmbAlici.BackColor = Color.Red;
                cmbAlici.Focus();
                bos = true;

            }


            if (cmbTTipi.Text == "Taşıma Seçiniz" || cmbTTipi.Text == "")
            {
                cmbTTipi.BackColor = Color.Red;
                cmbTTipi.Focus();
                bos = true;
            }

            if (txtAdi.Text == "")
            {
                txtAdi.BackColor = Color.Red;
                txtAdi.Focus();
                bos = true;

            }

            if (txtSoyadi.Text == "")
            {
                txtSoyadi.BackColor = Color.Red;
                txtSoyadi.Focus();
                bos = true;

            }

            if (txtMdegeri.Text == "")
            {
                txtMdegeri.BackColor = Color.Red;
                txtMdegeri.Focus();
                bos = true;

            }

            if (txtMKurDegeri.Text == "")
            {
                txtMKurDegeri.BackColor = Color.Red;
                txtMKurDegeri.Focus();
                bos = true;

            }

            if (cmbMcinsi.Text == "Malın Cins Seçiniz" || cmbMcinsi.Text == "")
            {
                cmbMcinsi.BackColor = Color.Red;
                cmbMcinsi.Focus();
                bos = true;
            }

          

            if (txtPlaka.Text == "")
            {
                txtPlaka.BackColor = Color.Red;
                txtPlaka.Focus();
                bos = true;

            }

            if (txtCTarihi.Text == "  .  ." || txtCTarihi.Text.Length < txtCTarihi.TextLength)
            {
                txtCTarihi.BackColor = Color.Red;
                txtCTarihi.Focus();
                bos = true;
            }

            if (txtTTarih.Text == "  .  ." || txtTTarih.Text.Length < txtTTarih.TextLength)
            {
                txtTTarih.BackColor = Color.Red;
                txtTTarih.Focus();
                bos = true;
            }

            
            return bos;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tanımlama frmElektronik = new Tanımlama();
            frmElektronik.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbAlici.Text = "";
            cmbTTipi.Text = "";
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtMdegeri.Text = "";
            txtMKurDegeri.Text = "";
            cmbMcinsi.Text = "";
            txtPlaka.Text = "";
            txtCTarihi.Text = "";
            txtTTarih.Text = "";
            cmbAlici.Focus();
        }
    }
}
