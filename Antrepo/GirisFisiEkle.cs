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
    public partial class GirisFisiEkle : Form
    {
        public GirisFisiEkle()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Insert Into GirişFişiİşlemleri (Gonderici,Alici,Nakliyeci,Ülkesi,Plaka,TasimaTipi,MalinDeğeri,MalinCinsi,MalDegeriKur,GirisTarihi,TasfiyeTarihi,TahakkukTarihi) Values (@Gonderici,@Alici,@Nakliyeci,@Ülkesi,@Plaka,@TasimaTipi,@MalinDeğeri,@MalinCinsi,@MalDegeriKur,@GirisTarihi,@TasfiyeTarihi,@TahakkukTarihi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Gonderici", cmbGonder.Text);
                EkleKomut.Parameters.AddWithValue("@Alici", cmbAl.Text);
                EkleKomut.Parameters.AddWithValue("@Nakliyeci", cmbNakliyat.Text);
                EkleKomut.Parameters.AddWithValue("@Ülkesi", cmbUlke.Text);
                EkleKomut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                EkleKomut.Parameters.AddWithValue("@TasimaTipi", cmbTTipi.Text);
                EkleKomut.Parameters.AddWithValue("@MalinDeğeri", txtMdeger2.Text);
                EkleKomut.Parameters.AddWithValue("@MalinCinsi", cmbCins.Text);
                EkleKomut.Parameters.AddWithValue("@MalDegeriKur", txtMKurDeger.Text);
                EkleKomut.Parameters.AddWithValue("@GirisTarihi", txtGTarihi.Text);
                EkleKomut.Parameters.AddWithValue("@TasfiyeTarihi", txtTasfiyeT.Text);
                EkleKomut.Parameters.AddWithValue("@TahakkukTarihi", txtTahakkukT.Text);
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
            cmbGonder.BackColor = Color.White;
            cmbAl.BackColor = Color.White;
            cmbNakliyat.BackColor = Color.White;
            cmbUlke.BackColor = Color.White;
            txtPlaka.BackColor = Color.White;
            cmbTTipi.BackColor = Color.White;
            txtMdeger2.BackColor = Color.White;
            cmbCins.BackColor = Color.White;
            txtMKurDeger.BackColor = Color.White;
            txtGTarihi.BackColor = Color.White;
            txtTasfiyeT.BackColor = Color.White;
            txtTahakkukT.BackColor = Color.White;


            if (cmbGonder.Text == "Gönderici Seçiniz" || cmbGonder.Text == "")
            {
                cmbGonder.BackColor = Color.Red;
                cmbGonder.Focus();
                bos = true;

            }


            if (cmbAl.Text == "Alıcı Seçiniz" || cmbAl.Text == "")
            {
                cmbAl.BackColor = Color.Red;
                cmbAl.Focus();
                bos = true;
            }

            if (cmbNakliyat.Text == "Nakliyeci Seçiniz" || cmbNakliyat.Text == "")
            {
                cmbNakliyat.BackColor = Color.Red;
                cmbNakliyat.Focus();
                bos = true;
            }

            if (cmbUlke.Text == "Ülke Seçiniz" || cmbUlke.Text == "")
            {
                cmbUlke.BackColor = Color.Red;
                cmbUlke.Focus();
                bos = true;
            }
            

            if (txtPlaka.Text == "")
            {
                txtPlaka.BackColor = Color.Red;
                txtPlaka.Focus();
                bos = true;

            }

            if (cmbTTipi.Text == "Taşıma Tipi Seçiniz" || cmbTTipi.Text == "")
            {
                cmbTTipi.BackColor = Color.Red;
                cmbTTipi.Focus();
                bos = true;
            }

            if (txtMdeger2.Text == "") 
            {
                txtMdeger2.BackColor = Color.Red;
                txtMdeger2.Focus();
                bos = true;

            }

            if (cmbCins.Text == "Cins Seçiniz" || cmbCins.Text == "")
            {
                cmbCins.BackColor = Color.Red;
                cmbCins.Focus();
                bos = true;
            }

            if (txtMKurDeger.Text == "")
            {
                txtMKurDeger.BackColor = Color.Red;
                txtMKurDeger.Focus();
                bos = true;

            }

            if (txtGTarihi.Text == "  .  ." || txtGTarihi.Text.Length < txtGTarihi.TextLength)
            {
                txtGTarihi.BackColor = Color.Red;
                txtGTarihi.Focus();
                bos = true;
            }

            if (txtTasfiyeT.Text == "  .  ." || txtTasfiyeT.Text.Length < txtTasfiyeT.TextLength)
            {
                txtTasfiyeT.BackColor = Color.Red;
                txtTasfiyeT.Focus();
                bos = true;
            }

            if (txtTahakkukT.Text == "  .  ." || txtTahakkukT.Text.Length < txtTahakkukT.TextLength)
            {
                txtTahakkukT.BackColor = Color.Red;
                txtTahakkukT.Focus();
                bos = true;
            }

           
            return bos;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbGonder.Text = "";
            cmbAl.Text = "";
            cmbNakliyat.Text = "";
            cmbUlke.Text = "";
            txtPlaka.Text = "";
            cmbTTipi.Text = "";
            txtMdeger2.Text = "";
            cmbCins.Text = "";
            txtMKurDeger.Text = "";
            txtGTarihi.Text = "";
            txtTasfiyeT.Text = "";
            txtTahakkukT.Text = "";
            cmbGonder.Focus();
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
            Tanımlama frmtan = new Tanımlama();
            frmtan.Show();
            this.Hide();
        }
    }
}
