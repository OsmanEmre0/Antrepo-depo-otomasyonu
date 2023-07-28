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
    public partial class HavaGuncelle : Form
    {
        public HavaGuncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Update HavaTasiti Set Model=@Model,Renk=@Renk,UretimYili=@UretimYili,PiyasaDegeri=@PiyasaDegeri,NetAgirlik=@NetAgirlik where hava_id=@hava_id";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Model", cmbModel.Text);
                DegistirKomut.Parameters.AddWithValue("@Renk", cmbRenk.Text);
                DegistirKomut.Parameters.AddWithValue("@UretimYili", txtUyili.Text);
                DegistirKomut.Parameters.AddWithValue("@PiyasaDegeri", txtDegeri.Text);
                DegistirKomut.Parameters.AddWithValue("@NetAgirlik", txtAgirlik.Text);
                DegistirKomut.Parameters.AddWithValue("@hava_id", txtID19.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(cmbModel.Text + "" + cmbRenk.Text + "isimli kayıt Değiştirildi");
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
            cmbModel.BackColor = Color.White;
            cmbRenk.BackColor = Color.White;
            txtUyili.BackColor = Color.White;
            txtDegeri.BackColor = Color.White;
            txtAgirlik.BackColor = Color.White;




            if (cmbModel.Text == "Model Seçiniz" || cmbModel.Text == "")
            {
                cmbModel.BackColor = Color.Red;
                cmbModel.Focus();
                bos = true;

            }

            if (cmbRenk.Text == "Renk Seçiniz" || cmbRenk.Text == "")
            {
                cmbRenk.BackColor = Color.Red;
                cmbRenk.Focus();
                bos = true;

            }

            if (txtUyili.Text == "")
            {
                txtUyili.BackColor = Color.Red;
                txtUyili.Focus();
                bos = true;

            }

            if (txtDegeri.Text == "")
            {
                txtDegeri.BackColor = Color.Red;
                txtDegeri.Focus();
                bos = true;

            }

            if (txtAgirlik.Text == "")
            {
                txtAgirlik.BackColor = Color.Red;
                txtAgirlik.Focus();
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
            Taşıt frmtasit = new Taşıt();
            frmtasit.Show();
            this.Hide();
        }
    }
}
