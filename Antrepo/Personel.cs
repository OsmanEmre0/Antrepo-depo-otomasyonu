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
    public partial class Personel : Form
    {
        public Personel()
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
                string Sorgu = "Select *from Kallanıcı"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Kallanıcı");
                dvgPersonel.DataSource = ds.Tables["Kallanıcı"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }
        //Personel
        public void KayitListele2()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Personel"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Personel");
                dvgPersonel.DataSource = ds.Tables["Personel"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        private void üyeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void uygulamayıKapatToolStripMenuItem_Click(object sender, EventArgs e)
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


        public void MobilyaVeriYukle3()
        {
            try
            {
                Personel.BaglantiAc();
                string Sorgu = "Select Birimi from Personel";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Personel.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbPersonelBirim.Items.Add(dr["Birimi"]);
                }
                Personel.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }


        //uye kayıt arama

        public void UyeKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguUyeKayitlar = "select * from Kallanıcı";
                string SorguUyeKullanici = "Select * From Kallanıcı where Kullaniciadi='" + txtUyeKullanıcı.Text + "'";
           
                if (chkUyeKullanıcı.Checked)
                    SorguUyeKayitlar = SorguUyeKullanici;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguUyeKayitlar, Baglanti);
                da.Fill(ds, "Kallanıcı");
                dvgPersonel.DataSource = ds.Tables["Kallanıcı"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }


        //Personel kayıt arama

        public void PersonelKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguPersonelKayitlar = "select * from Personel";
                string SorguPersonelAdi = "Select * From Personel where Adi='" + txtPersonelAd.Text + "'";
                string SorguPersonelTcNo = "Select * From Personel where TcNo='" + txtPersonelTcno.Text + "'";
                string SorguPersonelBirim = "Select * From Personel where Birimi='" + cmbPersonelBirim.Text + "'";

                string SorguPersonelAdiTcNo = "Select * From Personel where Adi='" + txtPersonelAd.Text + "' And TcNo='" + txtPersonelTcno.Text + "'";
                string SorguPersonelAdiBirim = "Select * From Personel where Adi='" + txtPersonelAd.Text + "' And Birimi='" + cmbPersonelBirim.Text + "'";
                string SorguPersonelTcNoBirim = "Select * From Personel where TcNo='" + txtPersonelTcno.Text + "' And Birimi='" + cmbPersonelBirim.Text + "'";
                string SorguPersonelAdiTcNoBirim = "Select * From Personel where Adi='" + txtPersonelAd.Text + "' And TcNo='" + txtPersonelTcno.Text + "'  And Birimi='" + cmbPersonelBirim.Text + "'";

                if (chkPersonelAd.Checked && chkPersonelTcno.Checked && chkPersonelBirim.Checked)
                    SorguPersonelKayitlar = SorguPersonelAdiTcNoBirim;
                else if (chkPersonelAd.Checked && chkPersonelTcno.Checked)
                    SorguPersonelKayitlar = SorguPersonelAdiTcNo;
                else if (chkPersonelAd.Checked && chkPersonelBirim.Checked)
                    SorguPersonelKayitlar = SorguPersonelAdiBirim;
                else if (chkPersonelTcno.Checked && chkPersonelBirim.Checked)
                    SorguPersonelKayitlar = SorguPersonelTcNoBirim;
                else if (chkPersonelAd.Checked)
                    SorguPersonelKayitlar = SorguPersonelAdi;
                else if (chkPersonelTcno.Checked)
                    SorguPersonelKayitlar = SorguPersonelTcNo;
                else if (chkPersonelBirim.Checked)
                    SorguPersonelKayitlar = SorguPersonelBirim;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguPersonelKayitlar, Baglanti);
                da.Fill(ds, "Personel");
                dvgPersonel.DataSource = ds.Tables["Personel"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        //hızlı kayıt personel
        public void HizliAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Personel";
                string SorguBayiilebaslayan = "Select * From Personel where Adi Like '" + txtAranan.Text + "%'";
                string SorguBayiilebiten = "Select * From Personel where Adi Like '%" + txtAranan.Text + "'";
                string SorguBayiiceren = "Select * From Personel where Adi Like '%" + txtAranan.Text + "%'";

                string SorguMalindegerilebaslayan = "Select * From Personel where TcNo Like '" + txtAranan.Text + "%'";
                string SorguMalındegerilebiten = "Select * From Personel where TcNo Like '%" + txtAranan.Text + "'";
                string SorguMalındegericeren = "Select * From Personel where TcNo Like '%" + txtAranan.Text + "%'";

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    if (radAd.Checked)
                        SorguTumKayitlar = SorguBayiilebaslayan;
                    else
                        SorguTumKayitlar = SorguMalindegerilebaslayan;
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    if (radAd.Checked)
                        SorguTumKayitlar = SorguBayiilebiten;
                    else
                        SorguTumKayitlar = SorguMalındegerilebiten;
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    if (radAd.Checked)
                        SorguTumKayitlar = SorguBayiiceren;
                    else
                        SorguTumKayitlar = SorguMalındegericeren;
                }

                OleDbDataAdapter da = new OleDbDataAdapter(SorguTumKayitlar, Baglanti);
                da.Fill(ds, "Personel");
                dvgPersonel.DataSource = ds.Tables["Personel"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Ekrana dönüş yapılıyor", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main frm1 = new main();
            frm1.Show();
            this.Hide();
            
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitListele2();
        }

        private void kullanıcıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirişEkranı frmgiris = new GirişEkranı();
            frmgiris.Show();
            this.Hide();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelSil frmsil2 = new PersonelSil();
            frmsil2.txtID3.Text = dvgPersonel.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtAd3.Text = dvgPersonel.CurrentRow.Cells[1].Value.ToString();
            frmsil2.txtTcNo3.Text = dvgPersonel.CurrentRow.Cells[3].Value.ToString();



            frmsil2.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelGuncelle frmdegistir = new PersonelGuncelle();
            frmdegistir.txtID8.Text = dvgPersonel.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtAd.Text = dvgPersonel.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtSoyad.Text = dvgPersonel.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtTcNo.Text = dvgPersonel.CurrentRow.Cells[3].Value.ToString();
            if (dvgPersonel.CurrentRow.Cells[4].Value.ToString() == "Bay")
                frmdegistir.radBay.Checked = true;
            else if (dvgPersonel.CurrentRow.Cells[4].Value.ToString() == "Bayan")
                frmdegistir.radBayan.Checked = true;
            frmdegistir.txtAdres.Text = dvgPersonel.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txtTel.Text = dvgPersonel.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.cmbOgrenim.Text = dvgPersonel.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.cmbBirim.Text = dvgPersonel.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtİban.Text = dvgPersonel.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.txtİseBaslamaTarih.Text = dvgPersonel.CurrentRow.Cells[14].Value.ToString();
            frmdegistir.txtEhliyetNo.Text = dvgPersonel.CurrentRow.Cells[15].Value.ToString();
            frmdegistir.cmbSrc.Text = dvgPersonel.CurrentRow.Cells[16].Value.ToString();
            frmdegistir.txtMaas.Text = dvgPersonel.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.txtPrim.Text = dvgPersonel.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.txtAvans.Text = dvgPersonel.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.txtCalismaYili.Text = dvgPersonel.CurrentRow.Cells[13].Value.ToString();
            frmdegistir.cmbKan.Text = dvgPersonel.CurrentRow.Cells[17].Value.ToString();
           
            


            frmdegistir.Show();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UyeSil frmsil2 = new UyeSil();
            frmsil2.txtID11.Text = dvgPersonel.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtKUL.Text = dvgPersonel.CurrentRow.Cells[1].Value.ToString();
            frmsil2.txtSİF.Text = dvgPersonel.CurrentRow.Cells[2].Value.ToString();

            frmsil2.ShowDialog();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UyeGuncelle frmdegistir = new UyeGuncelle();
            frmdegistir.txtid.Text = dvgPersonel.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.txtKul.Text = dvgPersonel.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtSif.Text = dvgPersonel.CurrentRow.Cells[2].Value.ToString();


            frmdegistir.Show();
        }

        private void chkPersonelAd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPersonelAd.Checked == true)
            {
                txtPersonelAd.Enabled = true;
                txtPersonelAd.Focus();
            }
            else if (chkPersonelAd.Checked == false)
            {
                txtPersonelAd.Text = "";
                txtPersonelAd.Enabled = false;


            }
        }

        private void chkPersonelTcno_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPersonelTcno.Checked == true)
            {
                txtPersonelTcno.Enabled = true;
                txtPersonelTcno.Focus();
            }
            else if (chkPersonelTcno.Checked == false)
            {
                txtPersonelTcno.Text = "";
                txtPersonelTcno.Enabled = false;


            }
        }

        private void chkPersonelBirim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPersonelBirim.Checked == true)
            {
                cmbPersonelBirim.Enabled = true;
                cmbPersonelBirim.Focus();
            }
            else if (chkPersonelBirim.Checked == false)
            {
                cmbPersonelBirim.Text = "";
                cmbPersonelBirim.Enabled = false;


            }
        }

        private void chkUyeKullanıcı_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUyeKullanıcı.Checked == true)
            {
                txtUyeKullanıcı.Enabled = true;
                txtUyeKullanıcı.Focus();
            }
            else if (chkUyeKullanıcı.Checked == false)
            {
                txtUyeKullanıcı.Text = "";
                txtUyeKullanıcı.Enabled = false;


            }
        }

        private void Personel_Load_1(object sender, EventArgs e)
        {
            MobilyaVeriYukle3();
        }

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
            PersonelKayitAra();
        }

        private void btnUyeAra_Click(object sender, EventArgs e)
        {
            UyeKayitAra();
        }

        private void genelListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelRaporForm frmraporform = new PersonelRaporForm();
            frmraporform.ShowDialog();
            
        }

        private void üyeListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UyeRaporForm frmuyeform = new UyeRaporForm();
            frmuyeform.ShowDialog();
           
        }

        private void radAd_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "Ad :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void radTcNo_CheckedChanged(object sender, EventArgs e)
        {
            lblArananalan.Text = "TcNo :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            HizliAra();
        }

        private void birimListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonelBirimRaporForm frmbirimrapro = new PersonelBirimRaporForm();
            frmbirimrapro.ShowDialog();
        }
    }
}
