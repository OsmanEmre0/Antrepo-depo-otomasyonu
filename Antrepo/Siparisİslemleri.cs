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
    public partial class Siparisİslemleri : Form
    {
        public Siparisİslemleri()
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
                string Sorgu = "Select * from GirişFişiİşlemleri"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "GirişFişiİşlemleri");
                dvgFis.DataSource = ds.Tables["GirişFişiİşlemleri"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        //Çıkış
        public void KayitListele2()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select * from ÇıkışFişiİşlemleri"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "ÇıkışFişiİşlemleri");
                dvgFis.DataSource = ds.Tables["ÇıkışFişiİşlemleri"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        //giris gönder

        public void GFisiVeriYukle1()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Select Gonderici from GirişFişiİşlemleri";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbGirisGonder.Items.Add(dr["Gonderici"]);
                }
                Siparisİslemleri.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //giriş ulke

        public void GFisiVeriYukle2()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Select Ülkesi from GirişFişiİşlemleri";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbGirisUlke.Items.Add(dr["Ülkesi"]);
                }
                Siparisİslemleri.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //giriş Tasima

        public void GFisiVeriYukle3()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Select TasimaTipi from GirişFişiİşlemleri";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbGirisTasima.Items.Add(dr["TasimaTipi"]);
                }
                Siparisİslemleri.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //giriş kayıt arama

        public void GFisiKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguGfisiKayitlar = "select * from GirişFişiİşlemleri";
                string SorguGGonder = "Select * From GirişFişiİşlemleri where Gonderici='" + cmbGirisGonder.Text + "'";
                string SorguGUlke = "Select * From GirişFişiİşlemleri where Ülkesi='" + cmbGirisUlke.Text + "'";
                string SorguGTasima = "Select * From GirişFişiİşlemleri where TasimaTipi='" + cmbGirisTasima.Text + "'";

                string SorguGGonderUlke = "Select * From GirişFişiİşlemleri where Gonderici='" + cmbGirisGonder.Text + "' And Ülkesi='" + cmbGirisUlke.Text + "'";
                string SorguGGonderTasima = "Select * From GirişFişiİşlemleri where Gonderici='" + cmbGirisGonder.Text + "' And TasimaTipi='" + cmbGirisTasima.Text + "'";
                string SorguGUlkeTasima = "Select * From GirişFişiİşlemleri where Ülkesi='" + cmbGirisUlke.Text + "' And TasimaTipi='" + cmbGirisTasima.Text + "'";
                string SorguGGonderULkeTasima = "Select * From GirişFişiİşlemleri where Gonderici='" + cmbGirisGonder.Text + "' And Ülkesi='" + cmbGirisUlke.Text + "'  And TasimaTipi='" + cmbGirisTasima.Text + "'";

                if (chkGirisGonder.Checked && chkGirisUlke.Checked && chkGirisTasima.Checked)
                    SorguGfisiKayitlar = SorguGGonderULkeTasima;
                else if (chkGirisGonder.Checked && chkGirisUlke.Checked)
                    SorguGfisiKayitlar = SorguGGonderUlke;
                else if (chkGirisGonder.Checked && chkGirisTasima.Checked)
                    SorguGfisiKayitlar = SorguGGonderTasima;
                else if (chkGirisUlke.Checked && chkGirisTasima.Checked)
                    SorguGfisiKayitlar = SorguGUlkeTasima;
                else if (chkGirisGonder.Checked)
                    SorguGfisiKayitlar = SorguGGonder;
                else if (chkGirisUlke.Checked)
                    SorguGfisiKayitlar = SorguGUlke;
                else if (chkGirisTasima.Checked)
                    SorguGfisiKayitlar = SorguGTasima;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguGfisiKayitlar, Baglanti);
                da.Fill(ds, "GirişFişiİşlemleri");
                dvgFis.DataSource = ds.Tables["GirişFişiİşlemleri"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        //çıkıs alici

        public void CFisiVeriYukle1()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Select Alici from ÇıkışFişiİşlemleri";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbCkisAlici.Items.Add(dr["Alici"]);
                }
                Siparisİslemleri.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //çıkış cins

        public void CFisiVeriYukle2()
        {
            try
            {
                Siparisİslemleri.BaglantiAc();
                string Sorgu = "Select Malincinsi from ÇıkışFişiİşlemleri";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Siparisİslemleri.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbCikisCins.Items.Add(dr["Malincinsi"]);
                }
                Siparisİslemleri.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }


        //Çıkıs kayıt arama

        public void ÇFisiKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguÇfisiKayitlar = "select * from ÇıkışFişiİşlemleri";
                string SorguCAlici = "Select * From ÇıkışFişiİşlemleri where Alici='" + cmbCkisAlici.Text + "'";
                string SorguCCins = "Select * From ÇıkışFişiİşlemleri where Malincinsi='" + cmbCikisCins.Text + "'";
                string SorguCTarih = "Select * From ÇıkışFişiİşlemleri where CikisTarihi='" + txtCikisTarih.Text + "'";

                string SorguCAliciCins = "Select * From ÇıkışFişiİşlemleri where Alici='" + cmbCkisAlici.Text + "' And Malincinsi='" + cmbCikisCins.Text + "'";
                string SorguCAliciTarih = "Select * From ÇıkışFişiİşlemleri where Alici='" + cmbCkisAlici.Text + "' And CikisTarihi='" + txtCikisTarih.Text + "'";
                string SorguCCİnsTarih = "Select * From ÇıkışFişiİşlemleri where Malincinsi='" + cmbCikisCins.Text + "' And CikisTarihi='" + txtCikisTarih.Text + "'";
                string SorguCAliciCinsTarih = "Select * From ÇıkışFişiİşlemleri where Alici='" + cmbCkisAlici.Text + "' And Malincinsi='" + cmbCikisCins.Text + "'  And CikisTarihi='" + txtCikisTarih.Text + "'";

                if (chkCikisAlici.Checked && chkCikisCins.Checked && chkCikisTarih.Checked)
                    SorguÇfisiKayitlar = SorguCAliciCinsTarih;
                else if (chkCikisAlici.Checked && chkCikisCins.Checked)
                    SorguÇfisiKayitlar = SorguCAliciCins;
                else if (chkCikisAlici.Checked && chkCikisTarih.Checked)
                    SorguÇfisiKayitlar = SorguCAliciTarih;
                else if (chkCikisCins.Checked && chkCikisTarih.Checked)
                    SorguÇfisiKayitlar = SorguCCİnsTarih;
                else if (chkCikisAlici.Checked)
                    SorguÇfisiKayitlar = SorguCAlici;
                else if (chkCikisCins.Checked)
                    SorguÇfisiKayitlar = SorguCCins;
                else if (chkCikisTarih.Checked)
                    SorguÇfisiKayitlar = SorguCTarih;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguÇfisiKayitlar, Baglanti);
                da.Fill(ds, "ÇıkışFişiİşlemleri");
                dvgFis.DataSource = ds.Tables["ÇıkışFişiİşlemleri"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }



        private void girişFişiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void programıKapatToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Ekrana dönülüyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main frm2 = new main();
            frm2.Show();
            this.Hide();
        }

        private void çıkışFişiİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitListele2();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisFisiSil frmsil2 = new GirisFisiSil();
            frmsil2.txtID.Text = dvgFis.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtGonderici.Text = dvgFis.CurrentRow.Cells[1].Value.ToString();
            frmsil2.txtAlici.Text = dvgFis.CurrentRow.Cells[2].Value.ToString();
            frmsil2.txtPlaka.Text = dvgFis.CurrentRow.Cells[5].Value.ToString();



            frmsil2.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirisFisiGuncelle frmdegistir = new GirisFisiGuncelle();
            frmdegistir.txtID.Text = dvgFis.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbGonder.Text = dvgFis.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.cmbAl.Text = dvgFis.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.cmbNakliyat.Text = dvgFis.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.cmbUlke.Text = dvgFis.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtPlaka.Text = dvgFis.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.cmbTTipi.Text = dvgFis.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.txtMdeger2.Text = dvgFis.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.cmbCins.Text = dvgFis.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtMKurDeger.Text = dvgFis.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.txtGTarihi.Text = dvgFis.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.txtTasfiyeT.Text = dvgFis.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.txtTahakkukT.Text = dvgFis.CurrentRow.Cells[12].Value.ToString();


            frmdegistir.Show();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CikisFisiSil frmsil2 = new CikisFisiSil();
            frmsil2.txtID16.Text = dvgFis.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtAlici.Text = dvgFis.CurrentRow.Cells[1].Value.ToString();
            frmsil2.txtAdi.Text = dvgFis.CurrentRow.Cells[3].Value.ToString();
            frmsil2.txtSoyad.Text = dvgFis.CurrentRow.Cells[4].Value.ToString();



            frmsil2.ShowDialog();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CikisFisiGuncelle frmdegistir = new CikisFisiGuncelle();
            frmdegistir.txtID.Text = dvgFis.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbAlici.Text = dvgFis.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.cmbTTipi.Text = dvgFis.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtAdi.Text = dvgFis.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtSoyadi.Text = dvgFis.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtMdegeri.Text = dvgFis.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txtMKurDegeri.Text = dvgFis.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.cmbMcinsi.Text = dvgFis.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.txtPlaka.Text = dvgFis.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtCTarihi.Text = dvgFis.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.txtTTarih.Text = dvgFis.CurrentRow.Cells[10].Value.ToString();


            frmdegistir.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGirisGonder.Checked == true)
            {
                cmbGirisGonder.Enabled = true;
                cmbGirisGonder.Focus();
            }
            else if (chkGirisGonder.Checked == false)
            {
                cmbGirisGonder.Text = "";
                cmbGirisGonder.Enabled = false;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkGirisUlke_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGirisUlke.Checked == true)
            {
                cmbGirisUlke.Enabled = true;
                cmbGirisUlke.Focus();
            }
            else if (chkGirisUlke.Checked == false)
            {
                cmbGirisUlke.Text = "";
                cmbGirisUlke.Enabled = false;


            }

        }

        private void chkGirisTasima_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGirisTasima.Checked == true)
            {
                cmbGirisTasima.Enabled = true;
                cmbGirisTasima.Focus();
            }
            else if (chkGirisTasima.Checked == false)
            {
                cmbGirisTasima.Text = "";
                cmbGirisTasima.Enabled = false;


            }
        }

        private void chkCikisAlici_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCikisAlici.Checked == true)
            {
                cmbCkisAlici.Enabled = true;
                cmbCkisAlici.Focus();
            }
            else if (chkCikisAlici.Checked == false)
            {
                cmbCkisAlici.Text = "";
                cmbCkisAlici.Enabled = false;


            }
        }

        private void chkCikisCins_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCikisCins.Checked == true)
            {
                cmbCikisCins.Enabled = true;
                cmbCikisCins.Focus();
            }
            else if (chkCikisCins.Checked == false)
            {
                cmbCikisCins.Text = "";
                cmbCikisCins.Enabled = false;


            }
        }

        private void chkCikisTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCikisTarih.Checked == true)
            {
                txtCikisTarih.Enabled = true;
                txtCikisTarih.Focus();
            }
            else if (chkCikisTarih.Checked == false)
            {
                txtCikisTarih.Text = "";
                txtCikisTarih.Enabled = false;


            }
        }

        private void Siparisİslemleri_Load(object sender, EventArgs e)
        {
            CFisiVeriYukle1();
            CFisiVeriYukle2();

            GFisiVeriYukle1();
            GFisiVeriYukle2();
            GFisiVeriYukle3();
            
        }

        private void btnGirisAra_Click(object sender, EventArgs e)
        {
            GFisiKayitAra();
        }

        private void btnCikisAra_Click(object sender, EventArgs e)
        {
            ÇFisiKayitAra();
        }

        private void yurtiçiListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GirişFişiRaporForm frmyurticiRapor = new GirişFişiRaporForm();
            frmyurticiRapor.ShowDialog();
           
        }

        private void yurtdışıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CikisFisiRaporForm frmYurtdisiRapor = new CikisFisiRaporForm();
            frmYurtdisiRapor.ShowDialog();
            
        }
    }
}
