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
    public partial class YurtDışıSevkiyatEkle : Form
    {
        public YurtDışıSevkiyatEkle()
        {
            InitializeComponent();
        }

        public void KayitEkle2()
        {
            try
            {
                Sevkiyatİslemleri.BaglantiAc();
                string Sorgu = "Insert Into YurtDisisevkiyat (GidecekMalzeme,MalzemeAdet,MalzemeFiyati,GondermeTarihi,Tasit,GonderilenYer) Values (@GidecekMalzeme,@MalzemeAdet,@MalzemeFiyati,@GondermeTarihi,@Tasit,@GonderilenYer)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Sevkiyatİslemleri.Baglanti);
                EkleKomut.Parameters.AddWithValue("@GidecekMalzeme", cmbMalzeme.Text);
                EkleKomut.Parameters.AddWithValue("@MalzemeAdet", txtAdet.Text);
                EkleKomut.Parameters.AddWithValue("@MalzemeFiyati", txtYfiyat.Text);
                EkleKomut.Parameters.AddWithValue("@GondermeTarihi", txtGTarihi.Text);
                EkleKomut.Parameters.AddWithValue("@Tasit", cmbTasit.Text);
                EkleKomut.Parameters.AddWithValue("@GonderilenYer", cmbGyer.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Sevkiyatİslemleri.Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
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
            Tanımlama frm5 = new Tanımlama();
            frm5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cmbMalzeme.Text = "";
            cmbTasit.Text = "";
            cmbGyer.Text = "";
            txtAdet.Text = "";
            txtGTarihi.Text = "";
            txtYfiyat.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tanımlama frm5 = new Tanımlama();
            frm5.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle2();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            cmbMalzeme.Text = "";
            cmbTasit.Text = "";
            cmbGyer.Text = "";
            txtAdet.Text = "";
            txtGTarihi.Text = "";
            txtYfiyat.Text = "";
        }
    }
}
