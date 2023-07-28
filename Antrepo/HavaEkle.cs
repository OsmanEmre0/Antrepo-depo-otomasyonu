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
    public partial class HavaEkle : Form
    {
        public HavaEkle()
        {
            InitializeComponent();
        }

        public void KayitEkle()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Insert Into HavaTasiti (Model,Renk,UretimYili,PiyasaDegeri,NetAgirlik) Values (@Model,@Renk,@UretimYili,@PiyasaDegeri,@NetAgirlik)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Model", cmbModel.Text);
                EkleKomut.Parameters.AddWithValue("@Renk", cmbRenk.Text);
                EkleKomut.Parameters.AddWithValue("@UretimYili", txtUyili.Text);
                EkleKomut.Parameters.AddWithValue("@PiyasaDegeri", txtDegeri.Text);
                EkleKomut.Parameters.AddWithValue("@NetAgirlik", txtAgirlik.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cmbModel.Text = "";
            cmbRenk.Text = "";
            txtUyili.Text = "";
            txtDegeri.Text = "";
            txtAgirlik.Text = "";
            cmbModel.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tanımlama frm5 = new Tanımlama();
            frm5.Show();
            this.Hide();
        }
    }
}
