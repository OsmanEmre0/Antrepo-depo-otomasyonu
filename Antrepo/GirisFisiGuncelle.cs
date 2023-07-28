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
    public partial class GirisFisiGuncelle : Form
    {
        public GirisFisiGuncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Update GirişFişiİşlemleri Set Gonderici=@Gonderici,Alici=@Alici,Nakliyeci=@Nakliyeci,Ülkesi=@Ülkesi,Plaka=@Plaka,TasimaTipi=@TasimaTipi,MalinDeğeri=@MalinDeğeri,MalinCinsi=@MalinCinsi,MalDegeriKur=@MalDegeriKur,GirisTarihi=@GirisTarihi,TasfiyeTarihi=@TasfiyeTarihi,TahakkukTarihi=@TahakkukTarihi where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Gonderici", cmbGonder.Text);
                DegistirKomut.Parameters.AddWithValue("@Alici", cmbAl.Text);
                DegistirKomut.Parameters.AddWithValue("@Nakliyeci", cmbNakliyat.Text);
                DegistirKomut.Parameters.AddWithValue("@Ülkesi", cmbUlke.Text);
                DegistirKomut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                DegistirKomut.Parameters.AddWithValue("@TasimaTipi", cmbTTipi.Text);
                DegistirKomut.Parameters.AddWithValue("@MalinDeğeri", txtMdeger2.Text);
                DegistirKomut.Parameters.AddWithValue("@MalinCinsi", cmbCins.Text);
                DegistirKomut.Parameters.AddWithValue("@MalDegeriKur", txtMKurDeger.Text);
                DegistirKomut.Parameters.AddWithValue("@GirisTarihi", txtGTarihi.Text);
                DegistirKomut.Parameters.AddWithValue("@TasfiyeTarihi", txtTasfiyeT.Text);
                DegistirKomut.Parameters.AddWithValue("@TahakkukTarihi", txtTahakkukT.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtID.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(cmbGonder.Text + "" + cmbUlke.Text + "isimli kayıt Değiştirildi");
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
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayıtDegistir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparisİslemleri frmsip = new Siparisİslemleri();
            frmsip.Show();
            this.Hide();
        }
    }
}
