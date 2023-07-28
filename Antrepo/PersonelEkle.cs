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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }


        public void KayitEkle()
        {
            try
            {
                Personel.BaglantiAc();
                string Sorgu = "Insert Into Personel (Adi,Soyadi,TcNo,Cinsiyet,Adres,Telefon,OgrenimDurumu,Birimi,IbanBilgisi,Maas,Prim,Avans,CalismaYili,IseBaslamaTarihi,EhliyetNo,SrcNo,KanGrubu) Values (@Adi,@Soyadi,@TcNo,@Cinsiyet,@Adres,@Telefon,@OgrenimDurumu,@Birimi,@IbanBilgisi,@Maas,@Prim,@Avans,@CalismaYili,@IseBaslamaTarihi,@EhliyetNo,@SrcNo,@KanGrubu)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Personel.Baglanti);
                EkleKomut.Parameters.AddWithValue("@Adi", txtAd.Text);
                EkleKomut.Parameters.AddWithValue("@Soyadi", txtSoyad.Text);
                EkleKomut.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
                if (radBay.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Bay");
                else if (radBayan.Checked == true)
                    EkleKomut.Parameters.AddWithValue("@Cinsiyet", "Bayan");
                EkleKomut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                EkleKomut.Parameters.AddWithValue("@Telefon", txtTel.Text);
                EkleKomut.Parameters.AddWithValue("@OgrenimDurumu", cmbOgrenim.Text);
                EkleKomut.Parameters.AddWithValue("@Birimi", cmbBirim.Text);
                EkleKomut.Parameters.AddWithValue("@IbanBilgisi", txtİban.Text);
                EkleKomut.Parameters.AddWithValue("@Maas", txtMaas.Text);
                EkleKomut.Parameters.AddWithValue("@Prim", txtPrim.Text);
                EkleKomut.Parameters.AddWithValue("@Avans", txtAvans.Text);
                EkleKomut.Parameters.AddWithValue("@CalismaYili", txtCalismaYili.Text);
                EkleKomut.Parameters.AddWithValue("@IseBaslamaTarihi", txtİseBaslamaTarih.Text);
                EkleKomut.Parameters.AddWithValue("@EhliyetNo", txtEhliyetNo.Text);
                EkleKomut.Parameters.AddWithValue("@SrcNo", cmbSrc.Text);
                EkleKomut.Parameters.AddWithValue("@KanGrubu", cmbKan.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Personel.Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }


        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtAd.BackColor = Color.White;
            txtSoyad.BackColor = Color.White;
            txtTcNo.BackColor = Color.White;
            radBay.BackColor = Color.White;
            radBayan.BackColor = Color.White;
            txtAdres.BackColor = Color.White;
            txtTel.BackColor = Color.White;
            cmbOgrenim.BackColor = Color.White;
            cmbBirim.BackColor = Color.White;
            txtİban.BackColor = Color.White;
            txtMaas.BackColor = Color.White;
            txtPrim.BackColor = Color.White;
            txtAvans.BackColor = Color.White;
            txtCalismaYili.BackColor = Color.White;
            txtİseBaslamaTarih.BackColor = Color.White;
            txtEhliyetNo.BackColor = Color.White;
            cmbSrc.BackColor = Color.White;
            cmbKan.BackColor = Color.White;


            if (cmbBirim.Text == "Birim Seçiniz" || cmbBirim.Text == "")
            {
                cmbBirim.BackColor = Color.Red;
                cmbBirim.Focus();
                bos = true;

            }

            if (cmbOgrenim.Text == "Öğrenim Durumu" || cmbOgrenim.Text == "")
            {
                cmbOgrenim.BackColor = Color.Red;
                cmbOgrenim.Focus();
                bos = true;

            }

            if (cmbKan.Text == "Kan Grubu Seçin" || cmbKan.Text == "")
            {
                cmbKan.BackColor = Color.Red;
                cmbKan.Focus();
                bos = true;

            }

            if (cmbSrc.Text == "Src Seçiniz" || cmbSrc.Text == "")
            {
                cmbSrc.BackColor = Color.Red;
                cmbSrc.Focus();
                bos = true;

            }

            if (txtTel.Text == "(   )    -" || txtTel.Text.Length < txtTel.TextLength)
            {
                txtTel.BackColor = Color.Red;
                txtTel.Focus();
                bos = true;
            }
            

            //datetime kullanırsak txtDtar.Text==DateTime.Now.ToShortDateString() diye yazılabilir.

            if (txtİseBaslamaTarih.Text == "  .  ." || txtİseBaslamaTarih.Text.Length < txtİseBaslamaTarih.TextLength)
            {
                txtİseBaslamaTarih.BackColor = Color.Red;
                txtİseBaslamaTarih.Focus();
                bos = true;
            }

            if (txtCalismaYili.Text == "" )
            {
                txtCalismaYili.BackColor = Color.Red;
                txtCalismaYili.Focus();
                bos = true;
            }



            if (radBay.Checked == false && radBayan.Checked == false)
            {
                radBay.BackColor = Color.Red;
                radBayan.BackColor = Color.Red;
                bos = true;
            }


            if (txtSoyad.Text == "")
            {
                txtSoyad.BackColor = Color.Red;
                txtSoyad.Focus();
                bos = true;
            }

            if (txtAd.Text == "")
            {
                txtAd.BackColor = Color.Red;
                txtAd.Focus();
                bos = true;
            }

            if (txtAdres.Text == "")
            {
                txtAdres.BackColor = Color.Red;
                txtAdres.Focus();
                bos = true;
            }

            if (txtMaas.Text == "")
            {
                txtMaas.BackColor = Color.Red;
                txtMaas.Focus();
                bos = true;
            }

            if (txtPrim.Text == "")
            {
                txtPrim.BackColor = Color.Red;
                txtPrim.Focus();
                bos = true;
            }

            if (txtAvans.Text == "")
            {
                txtAvans.BackColor = Color.Red;
                txtAvans.Focus();
                bos = true;
            }

            if (txtİban.Text == "" || txtİban.Text.Length < 26)
            {
                txtİban.BackColor = Color.Red;
                txtİban.Focus();
                bos = true;
            }

            if (txtEhliyetNo.Text == "" || txtEhliyetNo.Text.Length < 5)
            {
                txtEhliyetNo.BackColor = Color.Red;
                txtEhliyetNo.Focus();
                bos = true;
            }


            if (txtTcNo.Text == "" || txtTcNo.Text.Length < 11)
            {
                txtTcNo.BackColor = Color.Red;
                txtTcNo.Focus();
                bos = true;
            }


            return bos;

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Tanımlama frmtanımla = new Tanımlama();
            frmtanımla.Show();
            this.Hide();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTcNo.Text = "";
            txtAdres.Text = "";
            txtTel.Text = "";
            cmbOgrenim.Text = "";
            cmbBirim.Text = "";
            txtİban.Text = "";
            txtMaas.Text = "";
            txtPrim.Text = "";
            txtAvans.Text = "";
            txtCalismaYili.Text = "";
            txtİseBaslamaTarih.Text = "";
            txtEhliyetNo.Text = "";
            cmbSrc.Text = "";
            cmbKan.Text = "";
            txtAd.Focus();
        }
    }
}
