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
using System.Xml;

namespace Antrepo
{
    public partial class Fatura : Form
    {
        public Fatura()
        {
            InitializeComponent();
        }
        public static OleDbConnection Baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");


        public static void BaglantiAc()
        {
            try
            {
                Baglanti.Open();
            }
            catch (Exception Hata)
            {
                //sistem hata mesajı
                MessageBox.Show(Hata.Message, "Bağlantı Açma Hata Penceresi");
            }
        }

        public void KayitListele()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Fatura"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Fatura");
                dvgFatura.DataSource = ds.Tables["Fatura"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        //fatura cins

        public void FaturaVeriYukle2()
        {
            try
            {
                Fatura.BaglantiAc();
                string Sorgu = "Select FaturaCinsi from Fatura";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Fatura.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbKFaturaCins.Items.Add(dr["FaturaCinsi"]);
                }
                Fatura.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //fatura bayi

        public void FaturaVeriYukle1()
        {
            try
            {
                Fatura.BaglantiAc();
                string Sorgu = "Select Bayi from Fatura";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Fatura.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbFaturaBayi.Items.Add(dr["Bayi"]);
                }
                Fatura.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //fatura kayıt arama

        public void FaturaKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguFaturaKayitlar = "select * from Fatura";
                string SorguFaturaTarih = "Select * From Fatura where FaturaTarihi='" + txtFaturaTarihi.Text + "'";
                string SorguFaturaCins = "Select * From Fatura where FaturaCinsi='" + cmbKFaturaCins.Text + "'";
                string SorguFaturaBayi = "Select * From Fatura where Bayi='" + cmbFaturaBayi.Text + "'";

                string SorguFaturaTarihCins = "Select * From Fatura where FaturaTarihi='" + txtFaturaTarihi.Text + "' And FaturaCinsi='" + cmbKFaturaCins.Text + "'";
                string SorguFaturaTarihBayi = "Select * From Fatura where FaturaTarihi='" + txtFaturaTarihi.Text + "' And Bayi='" + cmbFaturaBayi.Text + "'";
                string SorguFaturaCinsBayi = "Select * From Fatura where FaturaCinsi='" + cmbKFaturaCins.Text + "' And Bayi='" + cmbFaturaBayi.Text + "'";
                string SorguFaturaTarihCinsBayi = "Select * From Fatura where FaturaTarihi='" + txtFaturaTarihi.Text + "' And FaturaCinsi='" + cmbKFaturaCins.Text + "'  And Bayi='" + cmbFaturaBayi.Text + "'";

                if (chkFaturaTarih.Checked && chkFaturacins.Checked && chkBayi.Checked)
                    SorguFaturaKayitlar = SorguFaturaTarihCinsBayi;
                else if (chkFaturaTarih.Checked && chkFaturacins.Checked)
                    SorguFaturaKayitlar = SorguFaturaTarihCins;
                else if (chkFaturaTarih.Checked && chkBayi.Checked)
                    SorguFaturaKayitlar = SorguFaturaTarihBayi;
                else if (chkFaturacins.Checked && chkBayi.Checked)
                    SorguFaturaKayitlar = SorguFaturaCinsBayi;
                else if (chkFaturaTarih.Checked)
                    SorguFaturaKayitlar = SorguFaturaTarih;
                else if (chkFaturacins.Checked)
                    SorguFaturaKayitlar = SorguFaturaCins;
                else if (chkBayi.Checked)
                    SorguFaturaKayitlar = SorguFaturaBayi;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguFaturaKayitlar, Baglanti);
                da.Fill(ds, "Fatura");
                dvgFatura.DataSource = ds.Tables["Fatura"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        //hızlı arama

        public void HizliAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Fatura";
                string SorguBayiilebaslayan = "Select * From Fatura where Bayi Like '" + txtAranan.Text + "%'";
                string SorguBayiilebiten = "Select * From Fatura where Bayi Like '%" + txtAranan.Text + "'";
                string SorguBayiiceren = "Select * From Fatura where Bayi Like '%" + txtAranan.Text + "%'";

                string SorguMalindegerilebaslayan = "Select * From Fatura where MalinDegeri Like '" + txtAranan.Text + "%'";
                string SorguMalındegerilebiten = "Select * From Fatura where MalinDegeri Like '%" + txtAranan.Text + "'";
                string SorguMalındegericeren = "Select * From Fatura where MalinDegeri Like '%" + txtAranan.Text + "%'";

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    if (radBayi.Checked)
                        SorguTumKayitlar = SorguBayiilebaslayan;
                    else
                        SorguTumKayitlar = SorguMalindegerilebaslayan;
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    if (radBayi.Checked)
                        SorguTumKayitlar = SorguBayiilebiten;
                    else
                        SorguTumKayitlar = SorguMalındegerilebiten;
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    if (radBayi.Checked)
                        SorguTumKayitlar = SorguBayiiceren;
                    else
                        SorguTumKayitlar = SorguMalındegericeren;
                }

                OleDbDataAdapter da = new OleDbDataAdapter(SorguTumKayitlar, Baglanti);
                da.Fill(ds, "Fatura");
                dvgFatura.DataSource = ds.Tables["Fatura"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        //Kayıt ekle

        public void KayitEkle()
        {
            try
            {
                Personel.BaglantiAc();
                string Sorgu = "Insert Into Fatura (GirisFisiNo,FaturaTarihi,VadeTarihi,MalinDegeri,MalinKurDegeri,KurTarihi,FaturaCinsi,GirisTarihi,UrunAgirligi,Bayi) Values (@GirisFisiNo,@FaturaTarihi,@VadeTarihi,@MalinDegeri,@MalinKurDegeri,@KurTarihi,@FaturaCinsi,@GirisTarihi,@UrunAgirligi,@Bayi)";
                OleDbCommand EkleKomut = new OleDbCommand(Sorgu, Personel.Baglanti);
                EkleKomut.Parameters.AddWithValue("@GirisFisiNo", txtGFis.Text);
                EkleKomut.Parameters.AddWithValue("@FaturaTarihi", txtFaturaT.Text);
                EkleKomut.Parameters.AddWithValue("@VadeTarihi", txtVadeT.Text);
                EkleKomut.Parameters.AddWithValue("@MalinDegeri", txtMDeger.Text);
                EkleKomut.Parameters.AddWithValue("@MalinKurDegeri", txtMalKurDeger.Text);
                EkleKomut.Parameters.AddWithValue("@KurTarihi", txtKurTarih.Text);
                EkleKomut.Parameters.AddWithValue("@FaturaCinsi", cmbFaturaCins.Text);
                EkleKomut.Parameters.AddWithValue("@GirisTarihi", txtGirisTarih.Text);
                EkleKomut.Parameters.AddWithValue("@UrunAgirligi", txtUrunAgirlik.Text);
                EkleKomut.Parameters.AddWithValue("@Bayi", cmbBayi.Text);
                if (EkleKomut.ExecuteNonQuery() == 1)
                    MessageBox.Show("Kayıt Eklendi");
                Fatura.Baglanti.Close();
            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Ekle Hata Penceresi");
            }
        }

        public bool BoslukKontrol()
        {
            bool bos = false; //tüm alanlar dolu
            txtGFis.BackColor = Color.White;
            txtFaturaT.BackColor = Color.White;
            txtVadeT.BackColor = Color.White;
            txtMDeger.BackColor = Color.White;
            txtMalKurDeger.BackColor = Color.White;
            txtKurTarih.BackColor = Color.White;
            cmbFaturaCins.BackColor = Color.White;
            txtGirisTarih.BackColor = Color.White;
            txtUrunAgirlik.BackColor = Color.White;
            cmbBayi.BackColor = Color.White;


            if (txtGFis.Text == "")
            {
                txtGFis.BackColor = Color.Red;
                txtGFis.Focus();
                bos = true;

            }

            if (txtFaturaT.Text == "  .  ." || txtFaturaT.Text.Length < txtFaturaT.TextLength)
            {
                txtFaturaT.BackColor = Color.Red;
                txtFaturaT.Focus();
                bos = true;
            }

            if (txtVadeT.Text == "  .  ." || txtVadeT.Text.Length < txtFaturaT.TextLength)
            {
                txtVadeT.BackColor = Color.Red;
                txtVadeT.Focus();
                bos = true;
            }

            if (txtMDeger.Text == "")
            {
                txtMDeger.BackColor = Color.Red;
                txtMDeger.Focus();
                bos = true;

            }

            if (txtMalKurDeger.Text == "")
            {
                txtMalKurDeger.BackColor = Color.Red;
                txtMalKurDeger.Focus();
                bos = true;

            }

            if (txtKurTarih.Text == "  .  ." || txtKurTarih.Text.Length < txtKurTarih.TextLength)
            {
                txtKurTarih.BackColor = Color.Red;
                txtKurTarih.Focus();
                bos = true;
            }

            if(cmbFaturaCins.Text=="" || cmbFaturaCins.Text=="Fatura Seçiniz")
            {
                cmbFaturaCins.BackColor = Color.Red;
                cmbFaturaCins.Focus();
                bos = true;
            }

            if (txtGirisTarih.Text == "  .  ." || txtGirisTarih.Text.Length < txtGirisTarih.TextLength)
            {
                txtGirisTarih.BackColor = Color.Red;
                txtGirisTarih.Focus();
                bos = true;
            }

            if (txtUrunAgirlik.Text == "")
            {
                txtUrunAgirlik.BackColor = Color.Red;
                txtUrunAgirlik.Focus();
                bos = true;

            }

            if (cmbBayi.Text == "" || cmbBayi.Text == "Bayi Seçiniz")
            {
                cmbBayi.BackColor = Color.Red;
                cmbBayi.Focus();
                bos = true;
            }

            
            return bos;

        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            FaturaVeriYukle1();
            FaturaVeriYukle2();

            btncik.FlatStyle = FlatStyle.Flat;
            btncik.BackColor = Color.Transparent;
            btncik.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btncik.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btngeri.FlatStyle = FlatStyle.Flat;
            btngeri.BackColor = Color.Transparent;
            btngeri.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btngeri.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            main frm1 = new main();
            frm1.Show();
            this.Hide();
        }

        private void btncik_Click(object sender, EventArgs e)
        {
            DialogResult deneme = MessageBox.Show("Uygulamadan Çıkış Yapmak\nİstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == deneme)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Programa geri dönülüyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (BoslukKontrol() == true)
                MessageBox.Show("Boş alanlara veri giriniz.", "DİKKAT");
            else
                KayitEkle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtGFis.Text = "";
            txtFaturaT.Text = "";
            txtVadeT.Text = "";
            txtMDeger.Text = "";
            txtMalKurDeger.Text = "";
            txtKurTarih.Text = "";
            cmbFaturaCins.Text = "";
            txtGirisTarih.Text = "";
            txtUrunAgirlik.Text = "";
            cmbBayi.Text = "";
            txtGFis.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FaturaSil frmsil = new FaturaSil();
            frmsil.txtID.Text = dvgFatura.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtFtarih.Text = dvgFatura.CurrentRow.Cells[2].Value.ToString();
            frmsil.txtMdeger.Text = dvgFatura.CurrentRow.Cells[4].Value.ToString();
            frmsil.txtFcins.Text = dvgFatura.CurrentRow.Cells[7].Value.ToString();

            frmsil.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FaturaGuncelle frmdegistir = new FaturaGuncelle();
            frmdegistir.txtID13.Text = dvgFatura.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtGFis.Text = dvgFatura.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtFaturaT.Text = dvgFatura.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtVadeT.Text = dvgFatura.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtMDeger.Text = dvgFatura.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtMalKurDeger.Text = dvgFatura.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txtKurTarih.Text = dvgFatura.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.cmbFaturaCins.Text = dvgFatura.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.txtGirisTarih.Text = dvgFatura.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtUrunAgirlik.Text = dvgFatura.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.cmbBayi.Text = dvgFatura.CurrentRow.Cells[10].Value.ToString();


            frmdegistir.Show();
        }

        private void chkFaturaTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFaturaTarih.Checked == true)
            {
                txtFaturaTarihi.Enabled = true;
                txtFaturaTarihi.Focus();
            }
            else if (chkFaturaTarih.Checked == false)
            {
                txtFaturaTarihi.Text = "";
                txtFaturaTarihi.Enabled = false;


            }
        }

        private void chkFaturacins_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFaturacins.Checked == true)
            {
                cmbKFaturaCins.Enabled = true;
                cmbKFaturaCins.Focus();
            }
            else if (chkFaturacins.Checked == false)
            {
                cmbKFaturaCins.Text = "";
                cmbKFaturaCins.Enabled = false;


            }
        }

        private void chkBayi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBayi.Checked == true)
            {
                cmbFaturaBayi.Enabled = true;
                cmbFaturaBayi.Focus();
            }
            else if (chkBayi.Checked == false)
            {
                cmbFaturaBayi.Text = "";
                cmbFaturaBayi.Enabled = false;


            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            FaturaKayitAra();
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            HizliAra();

        }

        private void radBayi_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Bayi :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void radDeger_CheckedChanged(object sender, EventArgs e)
        {
            lblArananAlan.Text = "Malın Değeri :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FaturaRaporForm frmfaturarapor = new FaturaRaporForm();
            frmfaturarapor.ShowDialog();
           
        }
    }
}
