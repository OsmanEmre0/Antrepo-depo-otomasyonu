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
    public partial class TasitGuncelle : Form
    {
        public TasitGuncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Update KaraTasit Set Marka=@Marka,Model=@Model,Renk=@Renk,UretimYili=@UretimYili,Vites=@Vites,KM=@KM,Yakit=@Yakit,Plaka=@Plaka ,AracinPiyasaDegeri=@AracinPiyasaDegeri ,HGSNo=@HGSNo ,SasiNo=@SasiNo ,DepoHacmi=@DepoHacmi ,RuhsatNo=@RuhsatNo,NetAgirlik=@NetAgirlik ,MotorGucu=@MotorGucu  where ID=@ID";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Marka", cmbMarka.Text);
                DegistirKomut.Parameters.AddWithValue("@Model", cmbModel.Text);
                DegistirKomut.Parameters.AddWithValue("@Renk", cmbRenk.Text);
                DegistirKomut.Parameters.AddWithValue("@UretimYili", txtUretimYili.Text);
                DegistirKomut.Parameters.AddWithValue("@Vites", cmbVites.Text);
                DegistirKomut.Parameters.AddWithValue("@KM", txtKM.Text);
                DegistirKomut.Parameters.AddWithValue("@Yakit", cmbYakit.Text);
                DegistirKomut.Parameters.AddWithValue("@Plaka", txtPlaka.Text);
                DegistirKomut.Parameters.AddWithValue("@AracinPiyasaDegeri", txtADeger.Text);
                DegistirKomut.Parameters.AddWithValue("@HGSNo", txtHgs.Text);
                DegistirKomut.Parameters.AddWithValue("@SasiNo", txtSasi.Text);
                DegistirKomut.Parameters.AddWithValue("@DepoHacmi", txtDHacim.Text);
                DegistirKomut.Parameters.AddWithValue("@RuhsatNo", txtRuhsatNo.Text);
                DegistirKomut.Parameters.AddWithValue("@NetAgirlik", txtAgirlik.Text);
                DegistirKomut.Parameters.AddWithValue("@MotorGucu", cmbMotorGucu.Text);
                DegistirKomut.Parameters.AddWithValue("@ID", txtID15.Text);

                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(cmbMarka.Text + "" + cmbModel.Text + "isimli kayıt Değiştirildi");
                Taşıt.Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Değistir hata penceresi");
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayıtDegistir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Taşıt frm5 = new Taşıt();
            frm5.Show();
            this.Hide();
        }
    }
}
