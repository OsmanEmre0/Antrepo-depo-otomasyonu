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
    public partial class FaturaGuncelle : Form
    {
        public FaturaGuncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Fatura.BaglantiAc();
                string Sorgu = "Update Fatura Set GirisFisiNo=@GirisFisiNo,FaturaTarihi=@FaturaTarihi,VadeTarihi=@VadeTarihi,MalinDegeri=@MalinDegeri,MalinKurDegeri=@MalinKurDegeri,KurTarihi=@KurTarihi,FaturaCinsi=@FaturaCinsi,GirisTarihi=@GirisTarihi,UrunAgirligi=@UrunAgirligi,Bayi=@Bayi where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Fatura.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@GirisFisiNo", txtGFis.Text);
                DegistirKomut.Parameters.AddWithValue("@FaturaTarihi", txtFaturaT.Text);
                DegistirKomut.Parameters.AddWithValue("@VadeTarihi", txtVadeT.Text);
                DegistirKomut.Parameters.AddWithValue("@MalinDegeri", txtMDeger.Text);
                DegistirKomut.Parameters.AddWithValue("@MalinKurDegeri", txtMalKurDeger.Text);
                DegistirKomut.Parameters.AddWithValue("@KurTarihi", txtKurTarih.Text);
                DegistirKomut.Parameters.AddWithValue("@FaturaCinsi", cmbFaturaCins.Text);
                DegistirKomut.Parameters.AddWithValue("@GirisTarihi", txtGirisTarih.Text);
                DegistirKomut.Parameters.AddWithValue("@UrunAgirligi", txtUrunAgirlik.Text);
                DegistirKomut.Parameters.AddWithValue("@Bayi", cmbBayi.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtID13.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtGFis.Text + "" + txtFaturaT.Text + "isimli kayıt Değiştirildi");
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
            txtGFis.BackColor = Color.White;
            txtFaturaT.BackColor = Color.White;
            txtVadeT.BackColor = Color.White;
            txtMDeger.BackColor = Color.White;
            txtMalKurDeger.BackColor = Color.White;
            txtKurTarih.BackColor = Color.White;
            cmbFaturaCins.BackColor = Color.White;
            txtGirisTarih.BackColor = Color.White;
            txtUrunAgirlik.BackColor = Color.White;
            cmbBayi.BackColor = Color.White;


            if (txtGFis.Text == "")
            {
                txtGFis.BackColor = Color.Red;
                txtGFis.Focus();
                bos = true;

            }

            if (txtFaturaT.Text == "  .  ." || txtFaturaT.Text.Length < txtFaturaT.TextLength)
            {
                txtFaturaT.BackColor = Color.Red;
                txtFaturaT.Focus();
                bos = true;
            }

            if (txtVadeT.Text == "  .  ." || txtVadeT.Text.Length < txtFaturaT.TextLength)
            {
                txtVadeT.BackColor = Color.Red;
                txtVadeT.Focus();
                bos = true;
            }

            if (txtMDeger.Text == "")
            {
                txtMDeger.BackColor = Color.Red;
                txtMDeger.Focus();
                bos = true;

            }

            if (txtMalKurDeger.Text == "")
            {
                txtMalKurDeger.BackColor = Color.Red;
                txtMalKurDeger.Focus();
                bos = true;

            }

            if (txtKurTarih.Text == "  .  ." || txtKurTarih.Text.Length < txtKurTarih.TextLength)
            {
                txtKurTarih.BackColor = Color.Red;
                txtKurTarih.Focus();
                bos = true;
            }

            if (cmbFaturaCins.Text == "" || cmbFaturaCins.Text == "Fatura Seçiniz")
            {
                cmbFaturaCins.BackColor = Color.Red;
                cmbFaturaCins.Focus();
                bos = true;
            }

            if (txtGirisTarih.Text == "  .  ." || txtGirisTarih.Text.Length < txtGirisTarih.TextLength)
            {
                txtGirisTarih.BackColor = Color.Red;
                txtGirisTarih.Focus();
                bos = true;
            }

            if (txtUrunAgirlik.Text == "")
            {
                txtUrunAgirlik.BackColor = Color.Red;
                txtUrunAgirlik.Focus();
                bos = true;

            }

            if (cmbBayi.Text == "" || cmbBayi.Text == "Bayi Seçiniz")
            {
                cmbBayi.BackColor = Color.Red;
                cmbBayi.Focus();
                bos = true;
            }


            return bos;

        }

        private void label11_Click(object sender, EventArgs e)
        {

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
            Fatura frm5 = new Fatura();
            frm5.Show();
            this.Hide();
        }
    }
}
