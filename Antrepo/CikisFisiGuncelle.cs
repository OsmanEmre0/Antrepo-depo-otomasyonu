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
    public partial class CikisFisiGuncelle : Form
    {
        public CikisFisiGuncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Update ÇıkışFişiİşlemleri Set Alici=@Alici,TasimaTipi=@TasimaTipi,Cekiciad=@Cekiciad,CekiciSoyad=@CekiciSoyad,MalinDegeri=@MalinDegeri,MalDegeriKur=@MalDegeriKur,Malincinsi=@Malincinsi,Plaka=@Plaka,CikisTarihi=@CikisTarihi,TasfiyeTarihi=@TasfiyeTarihi where Cikis_id=@Cikis_id";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Alici", cmbAlici.Text);
                DegistirKomut.Parameters.AddWithValue("@TasimaTipi", cmbTTipi.Text);
                DegistirKomut.Parameters.AddWithValue("@Cekiciad", txtAdi.Text);
                DegistirKomut.Parameters.AddWithValue("@CekiciSoyad", txtSoyadi.Text);
                DegistirKomut.Parameters.AddWithValue("@MalinDegeri", txtMdegeri.Text);
                DegistirKomut.Parameters.AddWithValue("@MalDegeriKur", txtMKurDegeri.Text);
                DegistirKomut.Parameters.AddWithValue("@Malincinsi", cmbMcinsi.Text);
                DegistirKomut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                DegistirKomut.Parameters.AddWithValue("@CikisTarihi", txtCTarihi.Text);
                DegistirKomut.Parameters.AddWithValue("@TasfiyeTarihi", txtTTarih.Text);
                DegistirKomut.Parameters.AddWithValue("@Cikis_id", txtID.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtAdi.Text + "" + txtSoyadi.Text + "isimli kayıt Değiştirildi");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayıtDegistir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Siparisİslemleri frm5 = new Siparisİslemleri();
            frm5.Show();
            this.Hide();
        }
    }
}
