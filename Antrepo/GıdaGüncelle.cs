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
    public partial class GıdaGüncelle : Form
    {
        public GıdaGüncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Update Gıda Set İsim=@İsim,Tür=@Tür,Adet=@Adet,SonTuketim=@SonTuketim,GelişTarihi=@GelişTarihi,GelişYeri=@GelişYeri,KGGelişFiyati=@KGGelişFiyati where ID=@ID";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@İsim", cmbÜrün.Text);
                DegistirKomut.Parameters.AddWithValue("@Tür", cmdTür.Text);
                DegistirKomut.Parameters.AddWithValue("@Adet", txtAdet.Text);
                DegistirKomut.Parameters.AddWithValue("@SonTuketim", txtSonTarih.Text);
                DegistirKomut.Parameters.AddWithValue("@GelişTarihi", txtGelisTarih.Text);
                DegistirKomut.Parameters.AddWithValue("@GelişYeri", cmbGelis.Text);
                DegistirKomut.Parameters.AddWithValue("@KGGelişFiyati", txtFiyat.Text);
                DegistirKomut.Parameters.AddWithValue("@ID", txtID.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(cmbÜrün.Text + "" + cmdTür.Text + "isimli kayıt Değiştirildi");
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
            txtAdet.BackColor = Color.White;
            txtGelisTarih.BackColor = Color.White;
            cmbGelis.BackColor = Color.White;
            txtSonTarih.BackColor = Color.White;
            cmbÜrün.BackColor = Color.White;
            cmdTür.BackColor = Color.White;
            txtFiyat.BackColor = Color.White;


            if (cmbÜrün.Text == "Ürün Seçiniz" || cmbÜrün.Text == "")
            {
                cmbÜrün.BackColor = Color.Red;
                cmbÜrün.Focus();
                bos = true;

            }


            if (cmdTür.Text == "Tür Seçiniz" || cmdTür.Text == "")
            {
                cmdTür.BackColor = Color.Red;
                cmdTür.Focus();
                bos = true;
            }

            //datetime kullanırsak txtDtar.Text==DateTime.Now.ToShortDateString() diye yazılabilir.

            if (txtSonTarih.Text == "  .  ." || txtSonTarih.Text.Length < txtSonTarih.TextLength)
            {
                txtSonTarih.BackColor = Color.Red;
                txtSonTarih.Focus();
                bos = true;
            }


            if (txtAdet.Text == "")
            {
                txtAdet.BackColor = Color.Red;
                txtAdet.Focus();
                bos = true;

            }


            if (txtGelisTarih.Text == "  .  ." || txtGelisTarih.Text.Length < txtSonTarih.TextLength)
            {
                txtGelisTarih.BackColor = Color.Red;
                txtGelisTarih.Focus();
                bos = true;
            }


            if (cmbGelis.Text == "Geliş Seçiniz" || cmbÜrün.Text == "")
            {
                cmbGelis.BackColor = Color.Red;
                cmbGelis.Focus();
                bos = true;
            }

            if (txtFiyat.Text == "")
            {
                txtFiyat.BackColor = Color.Red;
                txtFiyat.Focus();
                bos = true;

            }

            return bos;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stoklar frm5 = new Stoklar();
            frm5.Show();
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
