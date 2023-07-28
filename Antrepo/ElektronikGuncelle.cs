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
    public partial class ElektronikGuncelle : Form
    {
        public ElektronikGuncelle()
        {
            InitializeComponent();
        }
        public void KayıtDegistir()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Update Elektronik Set İsim=@İsim,GelişTarihi=@GelişTarihi,Tür=@Tür,Marka=@Marka,Adet=@Adet,GelişYeri=@GelişYeri,GelisFiyati=@GelisFiyati,TaneFiyat=@TaneFiyat where Elektronik_id=@Elektronik_id";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@İsim", txtisim.Text);
                DegistirKomut.Parameters.AddWithValue("@GelişTarihi", txtGelisTarihi.Text);
                DegistirKomut.Parameters.AddWithValue("@Tür", cmbTur.Text);
                DegistirKomut.Parameters.AddWithValue("@Marka", cmbMarka.Text);
                DegistirKomut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                DegistirKomut.Parameters.AddWithValue("@GelişYeri", cmbGelisYeri.Text);
                DegistirKomut.Parameters.AddWithValue("@GelisFiyati", txtGelisFiyati.Text);
                DegistirKomut.Parameters.AddWithValue("@TaneFiyat", txtTaneFiyati.Text);
                DegistirKomut.Parameters.AddWithValue("@Elektronik_id", txtID.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtisim.Text + "" + cmbTur.Text + "isimli kayıt Değiştirildi");
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
            txtisim.BackColor = Color.White;
            txtAdet.BackColor = Color.White;
            txtGelisFiyati.BackColor = Color.White;
            txtGelisTarihi.BackColor = Color.White;
            txtTaneFiyati.BackColor = Color.White;
            cmbGelisYeri.BackColor = Color.White;
            cmbMarka.BackColor = Color.White;
            cmbTur.BackColor = Color.White;


            if (cmbGelisYeri.Text == "Geliş Yeri Seçiniz" || cmbGelisYeri.Text == "")
            {
                cmbGelisYeri.BackColor = Color.Red;
                cmbGelisYeri.Focus();
                bos = true;

            }


            if (cmbTur.Text == "Tür Seçiniz" || cmbTur.Text == "")
            {
                cmbTur.BackColor = Color.Red;
                cmbTur.Focus();
                bos = true;
            }

            if (cmbMarka.Text == "Marka Seçiniz" || cmbMarka.Text == "")
            {
                cmbMarka.BackColor = Color.Red;
                cmbMarka.Focus();
                bos = true;
            }

            //datetime kullanırsak txtDtar.Text==DateTime.Now.ToShortDateString() diye yazılabilir.

            if (txtGelisTarihi.Text == "  .  ." || txtGelisTarihi.Text.Length < txtGelisTarihi.TextLength)
            {
                txtGelisTarihi.BackColor = Color.Red;
                txtGelisTarihi.Focus();
                bos = true;
            }

            if (txtisim.Text == "")
            {
                txtisim.BackColor = Color.Red;
                txtisim.Focus();
                bos = true;

            }

            if (txtAdet.Text == "")
            {
                txtAdet.BackColor = Color.Red;
                txtAdet.Focus();
                bos = true;

            }




            if (txtTaneFiyati.Text == "")
            {
                txtTaneFiyati.BackColor = Color.Red;
                txtTaneFiyati.Focus();
                bos = true;

            }

            if (txtGelisFiyati.Text == "")
            {
                txtGelisFiyati.BackColor = Color.Red;
                txtGelisFiyati.Focus();
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
            Stoklar frm5 = new Stoklar();
            frm5.Show();
            this.Hide();
        }
    }
}
