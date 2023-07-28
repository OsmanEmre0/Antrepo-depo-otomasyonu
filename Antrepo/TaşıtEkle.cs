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
    public partial class TaşıtEkle : Form
    {
        public TaşıtEkle()
        {
            InitializeComponent();
        }


        public void KayitEkle()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Insert Into KaraTasit (Marka,Model,Renk,UretimYili,Vites,KM,Yakit,Plaka,AracinPiyasaDegeri,HGSNo,SasiNo,DepoHacmi,RuhsatNo,NetAgirlik,MotorGucu) Values (@Marka,@Model,@Renk,@UretimYili,@Vites,@KM,@Yakit,@Plaka,@AracinPiyasaDegeri,@HGSNo,@SasiNo,@DepoHacmi,@RuhsatNo,@NetAgirlik,@MotorGucu)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Marka", cmbMarka.Text);
                EkleKomut.Parameters.AddWithValue("@Model", cmbModel.Text);
                EkleKomut.Parameters.AddWithValue("@Renk", cmbRenk.Text);
                EkleKomut.Parameters.AddWithValue("@UretimYili", txtUretimYili.Text);
                EkleKomut.Parameters.AddWithValue("@Vites", cmbVites.Text);
                EkleKomut.Parameters.AddWithValue("@KM", txtKM.Text);
                EkleKomut.Parameters.AddWithValue("@Yakit", cmbYakit.Text);
                EkleKomut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                EkleKomut.Parameters.AddWithValue("@AracinPiyasaDegeri", txtADeger.Text);
                EkleKomut.Parameters.AddWithValue("@HGSNo", txtHgs.Text);
                EkleKomut.Parameters.AddWithValue("@SasiNo", txtSasi.Text);
                EkleKomut.Parameters.AddWithValue("@DepoHacmi", txtDHacim.Text);
                EkleKomut.Parameters.AddWithValue("@RuhsatNo", txtRuhsatNo.Text);
                EkleKomut.Parameters.AddWithValue("@NetAgirlik", txtAgirlik.Text);
                EkleKomut.Parameters.AddWithValue("@MotorGucu", cmbMotorGucu.Text);
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
            cmbMarka.BackColor = Color.White;
            cmbModel.BackColor = Color.White;
            cmbRenk.BackColor = Color.White;
            txtUretimYili.BackColor = Color.White;
            cmbVites.BackColor = Color.White;
            txtKM.BackColor = Color.White;
            cmbYakit.BackColor = Color.White;
            txtPlaka.BackColor = Color.White;
            txtADeger.BackColor = Color.White;
            txtHgs.BackColor = Color.White;
            txtDHacim.BackColor = Color.White;
            txtRuhsatNo.BackColor = Color.White;
            txtAgirlik.BackColor = Color.White;
            cmbMotorGucu.BackColor = Color.White;
  


            if (cmbMarka.Text == "Marka Seçiniz" || cmbMarka.Text == "")
            {
                cmbMarka.BackColor = Color.Red;
                cmbMarka.Focus();
                bos = true;

            }

            if (cmbRenk.Text == "Renk Seçiniz" || cmbRenk.Text == "")
            {
                cmbRenk.BackColor = Color.Red;
                cmbRenk.Focus();
                bos = true;

            }

            if (cmbModel.Text == "Model Seçiniz" || cmbModel.Text == "")
            {
                cmbModel.BackColor = Color.Red;
                cmbModel.Focus();
                bos = true;

            }

            if (cmbVites.Text == "Vites Seçiniz" || cmbVites.Text == "")
            {
                cmbVites.BackColor = Color.Red;
                cmbVites.Focus();
                bos = true;

            }
            if (cmbYakit.Text == "Yakıt Seçiniz" || cmbYakit.Text == "")
            {
                cmbYakit.BackColor = Color.Red;
                cmbYakit.Focus();
                bos = true;

            }

            if (cmbMotorGucu.Text == "Motor Gücü Seçiniz" || cmbMotorGucu.Text == "")
            {
                cmbMotorGucu.BackColor = Color.Red;
                cmbMotorGucu.Focus();
                bos = true;

            }

 
            if (txtKM.Text == "")
            {
                txtKM.BackColor = Color.Red;
                txtKM.Focus();
                bos = true;
            }

            if (txtPlaka.Text == "")
            {
                txtPlaka.BackColor = Color.Red;
                txtPlaka.Focus();
                bos = true;
            }

            if (txtADeger.Text == "")
            {
                txtADeger.BackColor = Color.Red;
                txtADeger.Focus();
                bos = true;
            }


            if (txtHgs.Text == "")
            {
                txtHgs.BackColor = Color.Red;
                txtHgs.Focus();
                bos = true;
            }

            if (txtSasi.Text == "")
            {
                txtSasi.BackColor = Color.Red;
                txtSasi.Focus();
                bos = true;
            }

            if (txtDHacim.Text == "")
            {
                txtDHacim.BackColor = Color.Red;
                txtDHacim.Focus();
                bos = true;
            }

            if (txtRuhsatNo.Text == "")
            {
                txtRuhsatNo.BackColor = Color.Red;
                txtRuhsatNo.Focus();
                bos = true;
            }

            if (txtAgirlik.Text == "")
            {
                txtAgirlik.BackColor = Color.Red;
                txtAgirlik.Focus();
                bos = true;
            }

            if (txtUretimYili.Text == "" || txtUretimYili.Text.Length < 4)
            {
                txtUretimYili.BackColor = Color.Red;
                txtUretimYili.Focus();
                bos = true;
            }

   

            return bos;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Tanımlama frm5 = new Tanımlama();
            frm5.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbMarka.Text = "";
            cmbModel.Text = "";
            cmbRenk.Text = "";
            txtUretimYili.Text = "";
            cmbVites.Text = "";
            txtKM.Text = "";
            txtSasi.Text = "";
            cmbYakit.Text = "";
            txtPlaka.Text = "";
            txtADeger.Text = "";
            txtHgs.Text = "";
            txtDHacim.Text = "";
            txtRuhsatNo.Text = "";
            txtAgirlik.Text = "";
            cmbMotorGucu.Text = "";
            cmbMarka.Focus();
        }
    }
}
