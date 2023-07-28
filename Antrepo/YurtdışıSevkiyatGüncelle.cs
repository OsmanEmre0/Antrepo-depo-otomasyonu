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
    public partial class YurtdışıSevkiyatGüncelle : Form
    {
        public YurtdışıSevkiyatGüncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Sevkiyatİslemleri.BaglantiAc();
                string Sorgu = "Update YurtDisisevkiyat Set GidecekMalzeme=@GidecekMalzeme,MalzemeAdet=@MalzemeAdet,MalzemeFiyati=@MalzemeFiyati ,GondermeTarihi=@GondermeTarihi ,Tasit=@Tasit,GonderilenYer=@GonderilenYer  where Kimlik=@Kimlik";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Sevkiyatİslemleri.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@GidecekMalzeme", cmbMalzeme.Text);
                DegistirKomut.Parameters.AddWithValue("@MalzemeAdet", txtAdet.Text);
                DegistirKomut.Parameters.AddWithValue("@MalzemeFiyati", txtYfiyat.Text);
                DegistirKomut.Parameters.AddWithValue("@GondermeTarihi", txtGTarihi.Text);
                DegistirKomut.Parameters.AddWithValue("@Tasit", cmbTasit.Text);
                DegistirKomut.Parameters.AddWithValue("@GonderilenYer", cmbGyer.Text);
                DegistirKomut.Parameters.AddWithValue("@Kimlik", txtYGID.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(cmbMalzeme.Text + "" + txtAdet.Text + "isimli kayıt Değiştirildi");
                Sevkiyatİslemleri.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Değistir hata penceresi");
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu

            cmbMalzeme.BackColor = Color.White;
            cmbTasit.BackColor = Color.White;
            cmbGyer.BackColor = Color.White;
            txtAdet.BackColor = Color.White;
            txtGTarihi.BackColor = Color.White;
            txtYfiyat.BackColor = Color.White;





            if (cmbMalzeme.Text == "Malzeme Seçiniz" || cmbMalzeme.Text == "")
            {
                cmbMalzeme.BackColor = Color.Red;
                cmbMalzeme.Focus();
                bos = true;

            }

            if (cmbTasit.Text == "Taşıt Seçiniz" || cmbTasit.Text == "")
            {
                cmbTasit.BackColor = Color.Red;
                cmbTasit.Focus();
                bos = true;

            }

            if (cmbGyer.Text == "Yer Seçin" || cmbGyer.Text == "")
            {
                cmbGyer.BackColor = Color.Red;
                cmbGyer.Focus();
                bos = true;

            }

            if (txtGTarihi.Text == "  .  ." || txtGTarihi.Text.Length < txtGTarihi.TextLength)
            {
                txtGTarihi.BackColor = Color.Red;
                txtGTarihi.Focus();
                bos = true;
            }


            if (txtAdet.Text == "")
            {
                txtAdet.BackColor = Color.Red;
                txtAdet.Focus();
                bos = true;
            }

            if (txtYfiyat.Text == "")
            {
                txtYfiyat.BackColor = Color.Red;
                txtYfiyat.Focus();
                bos = true;
            }


            return bos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sevkiyatİslemleri frmPer = new Sevkiyatİslemleri();
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
