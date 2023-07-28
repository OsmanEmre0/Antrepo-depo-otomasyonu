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
    public partial class PersonelGuncelle : Form
    {
        public PersonelGuncelle()
        {
            InitializeComponent();
        }

        public void KayıtDegistir()
        {
            try
            {
                Personel.BaglantiAc();
                string Sorgu = "Update Personel Set Adi=@Adi,Soyadi=@Soyadi,TcNo=@TcNo,Cinsiyet=@Cinsiyet,Adres=@Adres,Telefon=@Telefon,OgrenimDurumu=@OgrenimDurumu,Birimi=@Birimi ,IbanBilgisi=@IbanBilgisi ,Maas=@Maas ,Prim=@Prim ,Avans=@Avans ,CalismaYili=@CalismaYili ,IseBaslamaTarihi=@IseBaslamaTarihi ,EhliyetNo=@EhliyetNo ,SrcNo=@SrcNo ,KanGrubu=@KanGrubu  where Personel_id=@Personel_id";
                OleDbCommand DegistirKomut = new OleDbCommand(Sorgu, Personel.Baglanti);
                DegistirKomut.Parameters.AddWithValue("@Adi", txtAd.Text);
                DegistirKomut.Parameters.AddWithValue("@Soyadi", txtSoyad.Text);
                DegistirKomut.Parameters.AddWithValue("@TcNo", txtTcNo.Text);
                if (radBay.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@Cinsiyet", "Bay");
                else if (radBayan.Checked == true)
                    DegistirKomut.Parameters.AddWithValue("@Cinsiyet", "Bayan");
                DegistirKomut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                DegistirKomut.Parameters.AddWithValue("@Telefon", txtTel.Text);
                DegistirKomut.Parameters.AddWithValue("@OgrenimDurumu", cmbOgrenim.Text);
                DegistirKomut.Parameters.AddWithValue("@Birimi", cmbBirim.Text);
                DegistirKomut.Parameters.AddWithValue("@IbanBilgisi", txtİban.Text);
                DegistirKomut.Parameters.AddWithValue("@Maas", txtMaas.Text);
                DegistirKomut.Parameters.AddWithValue("@Prim", txtPrim.Text);
                DegistirKomut.Parameters.AddWithValue("@Avans", txtAvans.Text);
                DegistirKomut.Parameters.AddWithValue("@CalismaYili", txtCalismaYili.Text);
                DegistirKomut.Parameters.AddWithValue("@IseBaslamaTarihi", txtİseBaslamaTarih.Text);
                DegistirKomut.Parameters.AddWithValue("@EhliyetNo", txtEhliyetNo.Text);
                DegistirKomut.Parameters.AddWithValue("@SrcNo", cmbSrc.Text);
                DegistirKomut.Parameters.AddWithValue("@KanGrubu", cmbKan.Text);
                DegistirKomut.Parameters.AddWithValue("@Personel_id", txtID8.Text);
                if (DegistirKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show(txtAd.Text + "" + txtSoyad.Text + "isimli kayıt Değiştirildi");
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

            if (txtCalismaYili.Text == "")
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

        private void button1_Click(object sender, EventArgs e)
        {
            Personel frm5 = new Personel();
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
