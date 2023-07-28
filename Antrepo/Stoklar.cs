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
    public partial class Stoklar : Form
    {
        public Stoklar()
        {
            InitializeComponent();
        }

        //gıda listesi
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
                string Sorgu = "Select *from Gıda"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Gıda");
                dgvGıda.DataSource = ds.Tables["Gıda"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        //Elektronik
        public void KayitListele2()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Elektronik"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Elektronik");
                dgvGıda.DataSource = ds.Tables["Elektronik"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        //Mobilya

        public void KayitListele3()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from Mobilya"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Mobilya");
                dgvGıda.DataSource = ds.Tables["Mobilya"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }
        //Gıda isim
        public void GıdaVeriYukle1()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select İsim from Gıda";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbGıdaisim.Items.Add(dr["İsim"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //Gıda Tür

        public void GıdaVeriYukle2()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select Tür from Gıda";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbGıdatür.Items.Add(dr["Tür"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //Gıda GelişYeri

        public void GıdaVeriYukle3()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select GelişYeri from Gıda";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbGıdagelisyeri.Items.Add(dr["GelişYeri"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //Elektronik Tür

        public void ElektronikVeriYukle1()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select Tür from Elektronik";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbElektroTur.Items.Add(dr["Tür"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //Elektronik marka
        public void ElektronikVeriYukle2()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select Marka from Elektronik";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbElektroMarka.Items.Add(dr["Marka"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //Elektronik GelişYeri

        public void ElektronikVeriYukle3()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select GelişYeri from Elektronik";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbElektroGelisyeri.Items.Add(dr["GelişYeri"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //mobilya marka

        public void MobilyaVeriYukle1()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select Marka from Mobilya";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbMobilyaMarka.Items.Add(dr["Marka"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //mobilya gelisyeri

        public void MobilyaVeriYukle2()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select GelişYeri from Mobilya";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbMobilyaGelisyeri.Items.Add(dr["GelişYeri"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //mobilya tür

        public void MobilyaVeriYukle3()
        {
            try
            {
                Stoklar.BaglantiAc();
                string Sorgu = "Select Tür from Mobilya";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Stoklar.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbMobilyaTur.Items.Add(dr["Tür"]);
                }
                Stoklar.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }



        //Gıda kayıt ara
        public void GıdaKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguGıdaKayitlar = "select * from Gıda";
                string SorguIsim = "Select * From Gıda where İsim='" + cmbGıdaisim.Text + "'";
                string SorguTur = "Select * From Gıda where Tür='" + cmbGıdatür.Text + "'";
                string SorguGelisYeri = "Select * From Gıda where GelişYeri='" + cmbGıdagelisyeri.Text + "'";

                string SorguIsimTur = "Select * From Gıda where İsim='" + cmbGıdaisim.Text + "' And Tür='" + cmbGıdatür.Text + "'";
                string SorguIsimGelisYeri = "Select * From Gıda where İsim='" + cmbGıdaisim.Text + "' And GelişYeri='" + cmbGıdagelisyeri.Text + "'";
                string SorguTurGelisYeri = "Select * From Gıda where Tür='" + cmbGıdatür.Text + "' And GelişYeri='" + cmbGıdagelisyeri.Text + "'";
                string SorguIsimTurGelisYeri = "Select * From Gıda where İsim='" + cmbGıdaisim.Text + "' And Tür='" + cmbGıdatür.Text + "'  And GelişYeri='" + cmbGıdagelisyeri.Text + "'";

                if (chkGıdaisim.Checked && chkGıdatür.Checked && chkGıdagelisyeri.Checked)
                    SorguGıdaKayitlar = SorguIsimTurGelisYeri;
                else if (chkGıdaisim.Checked && chkGıdatür.Checked)
                    SorguGıdaKayitlar = SorguIsimTur;
                else if (chkGıdaisim.Checked && chkGıdagelisyeri.Checked)
                    SorguGıdaKayitlar = SorguIsimGelisYeri;
                else if (chkGıdatür.Checked && chkGıdagelisyeri.Checked)
                    SorguGıdaKayitlar = SorguTurGelisYeri;
                else if (chkGıdaisim.Checked)
                    SorguGıdaKayitlar = SorguIsim;
                else if (chkGıdatür.Checked)
                    SorguGıdaKayitlar = SorguTur;
                else if (chkGıdagelisyeri.Checked)
                    SorguGıdaKayitlar = SorguGelisYeri;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguGıdaKayitlar, Baglanti);
                da.Fill(ds, "Gıda");
                dgvGıda.DataSource = ds.Tables["Gıda"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        //Elektronik kayıt ara

        public void ElektronikKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguElektronikKayitlar = "select * from Elektronik";
                string SorguElektroTur = "Select * From Elektronik where Tür='" + cmbElektroTur.Text + "'";
                string SorguElektroMarka = "Select * From Elektronik where Marka='" + cmbElektroMarka.Text + "'";
                string SorguElektroGelisYeri = "Select * From Elektronik where GelişYeri='" + cmbElektroGelisyeri.Text + "'";

                string SorguElektroTurMarka = "Select * From Elektronik where Tür='" + cmbElektroTur.Text + "' And Marka='" + cmbElektroMarka.Text + "'";
                string SorguElektroTurGelisYeri = "Select * From Elektronik where Tür='" + cmbElektroTur.Text + "' And GelişYeri='" + cmbElektroGelisyeri.Text + "'";
                string SorguElektroMarkaGelisYeri = "Select * From Elektronik where Marka='" + cmbElektroMarka.Text + "' And GelişYeri='" + cmbElektroGelisyeri.Text + "'";
                string SorguElektroTurMarkaGelisYeri = "Select * From Elektronik where Tür='" + cmbElektroTur.Text + "' And Marka='" + cmbElektroMarka.Text + "'  And GelişYeri='" + cmbElektroGelisyeri.Text + "'";

                if (chkElektroTur.Checked && chkElektroMarka.Checked && chkElektroGelisyeri.Checked)
                    SorguElektronikKayitlar = SorguElektroTurMarkaGelisYeri;
                else if (chkElektroTur.Checked && chkElektroMarka.Checked)
                    SorguElektronikKayitlar = SorguElektroTurMarka;
                else if (chkElektroTur.Checked && chkElektroGelisyeri.Checked)
                    SorguElektronikKayitlar = SorguElektroTurGelisYeri;
                else if (chkElektroMarka.Checked && chkElektroGelisyeri.Checked)
                    SorguElektronikKayitlar = SorguElektroMarkaGelisYeri;
                else if (chkElektroTur.Checked)
                    SorguElektronikKayitlar = SorguElektroTur;
                else if (chkElektroMarka.Checked)
                    SorguElektronikKayitlar = SorguElektroMarka;
                else if (chkElektroGelisyeri.Checked)
                    SorguElektronikKayitlar = SorguElektroGelisYeri;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguElektronikKayitlar, Baglanti);
                da.Fill(ds, "Elektronik");
                dgvGıda.DataSource = ds.Tables["Elektronik"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        //Mobilya kayıt Ara

        public void MobilyaKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguMobilyaKayitlar = "select * from Mobilya";
                string SorguMobilyaMarka = "Select * From Mobilya where Marka='" + cmbMobilyaMarka.Text + "'";
                string SorguMobilyaGelişyeri = "Select * From Mobilya where GelişYeri='" + cmbMobilyaGelisyeri.Text + "'";
                string SorguMobilyaTur = "Select * From Mobilya where Tür='" + cmbMobilyaTur.Text + "'";

                string SorguMobilyaMarkaGelişYeri = "Select * From Mobilya where Marka='" + cmbMobilyaMarka.Text + "' And GelişYeri='" + cmbMobilyaGelisyeri.Text + "'";
                string SorguMobilyaMarkaTur = "Select * From Mobilya where Marka='" + cmbMobilyaMarka.Text + "' And Tür='" + cmbMobilyaTur.Text + "'";
                string SorguMobilyaGelisYeriTur = "Select * From Mobilya where GelişYeri='" + cmbMobilyaGelisyeri.Text + "' And Tür='" + cmbMobilyaTur.Text + "'";
                string SorguMobilyaMarkaGelişYeriTur = "Select * From Mobilya where Marka='" + cmbMobilyaMarka.Text + "' And GelişYeri='" + cmbMobilyaGelisyeri.Text + "'  And Tür='" + cmbMobilyaTur.Text + "'";

                if (chkMobilyaMarka.Checked && chkMobilyaGelisyeri.Checked && chkMobilyaTur.Checked)
                    SorguMobilyaKayitlar = SorguMobilyaMarkaGelişYeriTur;
                else if (chkMobilyaMarka.Checked && chkMobilyaGelisyeri.Checked)
                    SorguMobilyaKayitlar = SorguMobilyaMarkaGelişYeri;
                else if (chkMobilyaMarka.Checked && chkMobilyaTur.Checked)
                    SorguMobilyaKayitlar = SorguMobilyaMarkaTur;
                else if (chkMobilyaGelisyeri.Checked && chkMobilyaTur.Checked)
                    SorguMobilyaKayitlar = SorguMobilyaGelisYeriTur;
                else if (chkMobilyaMarka.Checked)
                    SorguMobilyaKayitlar = SorguMobilyaMarka;
                else if (chkMobilyaGelisyeri.Checked)
                    SorguMobilyaKayitlar = SorguMobilyaGelişyeri;
                else if (chkMobilyaTur.Checked)
                    SorguMobilyaKayitlar = SorguMobilyaTur;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguMobilyaKayitlar, Baglanti);
                da.Fill(ds, "Mobilya");
                dgvGıda.DataSource = ds.Tables["Mobilya"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        //hızlı ara gıda 

        public void GıdaHizliAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Gıda";
                string SorguBayiilebaslayan = "Select * From Gıda where İsim Like '" + txtAranan.Text + "%'";
                string SorguBayiilebiten = "Select * From Gıda where İsim Like '%" + txtAranan.Text + "'";
                string SorguBayiiceren = "Select * From Gıda where İsim Like '%" + txtAranan.Text + "%'";

                string SorguMalindegerilebaslayan = "Select * From Gıda where GelişYeri Like '" + txtAranan.Text + "%'";
                string SorguMalındegerilebiten = "Select * From Gıda where GelişYeri Like '%" + txtAranan.Text + "'";
                string SorguMalındegericeren = "Select * From Gıda where GelişYeri Like '%" + txtAranan.Text + "%'";

                if (cmbAramaTuru.Text == "İle Başlayan")
                {
                    if (radİsim.Checked)
                        SorguTumKayitlar = SorguBayiilebaslayan;
                    else
                        SorguTumKayitlar = SorguMalindegerilebaslayan;
                }
                else if (cmbAramaTuru.Text == "İle Biten")
                {
                    if (radİsim.Checked)
                        SorguTumKayitlar = SorguBayiilebiten;
                    else
                        SorguTumKayitlar = SorguMalındegerilebiten;
                }
                else if (cmbAramaTuru.Text == "İçeren")
                {
                    if (radİsim.Checked)
                        SorguTumKayitlar = SorguBayiiceren;
                    else
                        SorguTumKayitlar = SorguMalındegericeren;
                }

                OleDbDataAdapter da = new OleDbDataAdapter(SorguTumKayitlar, Baglanti);
                da.Fill(ds, "Gıda");
                dgvGıda.DataSource = ds.Tables["Gıda"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }
        //hızlı ara elektronik

        public void ElektronikHizliAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Elektronik";
                string SorguBayiilebaslayan = "Select * From Elektronik where Tür Like '" + txtAranan2.Text + "%'";
                string SorguBayiilebiten = "Select * From Elektronik where Tür Like '%" + txtAranan2.Text + "'";
                string SorguBayiiceren = "Select * From Elektronik where Tür Like '%" + txtAranan2.Text + "%'";

                string SorguMalindegerilebaslayan = "Select * From Elektronik where Marka Like '" + txtAranan2.Text + "%'";
                string SorguMalındegerilebiten = "Select * From Elektronik where Marka Like '%" + txtAranan2.Text + "'";
                string SorguMalındegericeren = "Select * From Elektronik where Marka Like '%" + txtAranan2.Text + "%'";

                if (cmbAramaTuru2.Text == "İle Başlayan")
                {
                    if (radTur.Checked)
                        SorguTumKayitlar = SorguBayiilebaslayan;
                    else
                        SorguTumKayitlar = SorguMalindegerilebaslayan;
                }
                else if (cmbAramaTuru2.Text == "İle Biten")
                {
                    if (radTur.Checked)
                        SorguTumKayitlar = SorguBayiilebiten;
                    else
                        SorguTumKayitlar = SorguMalındegerilebiten;
                }
                else if (cmbAramaTuru2.Text == "İçeren")
                {
                    if (radTur.Checked)
                        SorguTumKayitlar = SorguBayiiceren;
                    else
                        SorguTumKayitlar = SorguMalındegericeren;
                }

                OleDbDataAdapter da = new OleDbDataAdapter(SorguTumKayitlar, Baglanti);
                da.Fill(ds, "Elektronik");
                dgvGıda.DataSource = ds.Tables["Elektronik"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        //mobilya Hızlı Ara

        public void MobilyaHizliAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguTumKayitlar = "select * from Mobilya";
                string SorguBayiilebaslayan = "Select * From Mobilya where Marka Like '" + txtAranan3.Text + "%'";
                string SorguBayiilebiten = "Select * From Mobilya where Marka Like '%" + txtAranan3.Text + "'";
                string SorguBayiiceren = "Select * From Mobilya where Marka Like '%" + txtAranan3.Text + "%'";

                string SorguMalindegerilebaslayan = "Select * From Mobilya where GelişYeri Like '" + txtAranan3.Text + "%'";
                string SorguMalındegerilebiten = "Select * From Mobilya where GelişYeri Like '%" + txtAranan3.Text + "'";
                string SorguMalındegericeren = "Select * From Mobilya where GelişYeri Like '%" + txtAranan3.Text + "%'";

                if (cmbAramaTuru3.Text == "İle Başlayan")
                {
                    if (radMarka2.Checked)
                        SorguTumKayitlar = SorguBayiilebaslayan;
                    else
                        SorguTumKayitlar = SorguMalindegerilebaslayan;
                }
                else if (cmbAramaTuru3.Text == "İle Biten")
                {
                    if (radMarka2.Checked)
                        SorguTumKayitlar = SorguBayiilebiten;
                    else
                        SorguTumKayitlar = SorguMalındegerilebiten;
                }
                else if (cmbAramaTuru3.Text == "İçeren")
                {
                    if (radMarka2.Checked)
                        SorguTumKayitlar = SorguBayiiceren;
                    else
                        SorguTumKayitlar = SorguMalındegericeren;
                }

                OleDbDataAdapter da = new OleDbDataAdapter(SorguTumKayitlar, Baglanti);
                da.Fill(ds, "Mobilya");
                dgvGıda.DataSource = ds.Tables["Mobilya"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Hızlı Arama Hata Penceresi");
            }
        }

        private void geriDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Ekrana dönülüyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main frm2 = new main();
            frm2.Show();
            this.Hide();
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

        private void gıdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void teknolojiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitListele2();
        }

        private void mobilyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KayitListele3();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GıdaKayıtSil frmsil = new GıdaKayıtSil();
            frmsil.txtID2.Text = dgvGıda.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtIsim.Text = dgvGıda.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtTur.Text = dgvGıda.CurrentRow.Cells[2].Value.ToString();



            frmsil.ShowDialog();
        }

        private void Stoklar_Activated(object sender, EventArgs e)
        {
            Baglanti.Close();

        }

        private void dgvGıda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ElektronikKayıtSil frmsil2 = new ElektronikKayıtSil();
            frmsil2.txtID4.Text = dgvGıda.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtisim2.Text = dgvGıda.CurrentRow.Cells[1].Value.ToString();
            frmsil2.txtTur2.Text = dgvGıda.CurrentRow.Cells[3].Value.ToString();
            frmsil2.txtAdet2.Text = dgvGıda.CurrentRow.Cells[5].Value.ToString();



            frmsil2.ShowDialog();
        }

        private void silToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MobilyaKayıtSil frmsil2 = new MobilyaKayıtSil();
            frmsil2.txtID5.Text = dgvGıda.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtGelis5.Text = dgvGıda.CurrentRow.Cells[1].Value.ToString();
            frmsil2.txtMarka5.Text = dgvGıda.CurrentRow.Cells[2].Value.ToString();
            frmsil2.txtTur5.Text = dgvGıda.CurrentRow.Cells[5].Value.ToString();



            frmsil2.ShowDialog();
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GıdaGüncelle frmdegistir = new GıdaGüncelle();
            frmdegistir.txtID.Text = dgvGıda.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbÜrün.Text = dgvGıda.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.cmdTür.Text = dgvGıda.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtAdet.Text = dgvGıda.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtSonTarih.Text = dgvGıda.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtGelisTarih.Text = dgvGıda.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.cmbGelis.Text = dgvGıda.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.txtFiyat.Text = dgvGıda.CurrentRow.Cells[7].Value.ToString();
            

            frmdegistir.Show();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ElektronikGuncelle frmsil2 = new ElektronikGuncelle();
            frmsil2.txtID.Text = dgvGıda.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtisim.Text = dgvGıda.CurrentRow.Cells[1].Value.ToString();
            frmsil2.txtGelisTarihi.Text = dgvGıda.CurrentRow.Cells[2].Value.ToString();
            frmsil2.cmbTur.Text = dgvGıda.CurrentRow.Cells[3].Value.ToString();
            frmsil2.cmbMarka.Text = dgvGıda.CurrentRow.Cells[4].Value.ToString();
            frmsil2.txtAdet.Text = dgvGıda.CurrentRow.Cells[5].Value.ToString();
            frmsil2.cmbGelisYeri.Text = dgvGıda.CurrentRow.Cells[6].Value.ToString();
            frmsil2.txtGelisFiyati.Text = dgvGıda.CurrentRow.Cells[7].Value.ToString();
            frmsil2.txtTaneFiyati.Text = dgvGıda.CurrentRow.Cells[8].Value.ToString();



            frmsil2.ShowDialog();
            this.Hide();
        }

        private void güncelleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MobilyaGuncelle frmsil2 = new MobilyaGuncelle();
            frmsil2.txtID.Text = dgvGıda.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtGelisTarihi.Text = dgvGıda.CurrentRow.Cells[1].Value.ToString();
            frmsil2.cmbMarka.Text = dgvGıda.CurrentRow.Cells[2].Value.ToString();
            frmsil2.txtAdet.Text = dgvGıda.CurrentRow.Cells[3].Value.ToString();
            frmsil2.cmbGelisYeri.Text = dgvGıda.CurrentRow.Cells[4].Value.ToString();
            frmsil2.cmbTur.Text = dgvGıda.CurrentRow.Cells[5].Value.ToString();
            frmsil2.txtGelisFiyati.Text = dgvGıda.CurrentRow.Cells[6].Value.ToString();
            frmsil2.txtTaneFiyati.Text = dgvGıda.CurrentRow.Cells[7].Value.ToString();


            frmsil2.ShowDialog();
        }

       


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkGıdatur_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chkGıdaGyeri_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnGıdaAra_Click(object sender, EventArgs e)
        {
            
        }

        private void Stoklar_Load(object sender, EventArgs e)
        {
           
          
        }

        private void chkGıdaisim_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGıdaisim.Checked == true)
            {
                cmbGıdaisim.Enabled = true;
                cmbGıdaisim.Focus();
            }
            else if (chkGıdaisim.Checked == false)
            {
                cmbGıdaisim.Text = "";
                cmbGıdaisim.Enabled = false;


            }
        }

        private void chkGıdatür_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGıdatür.Checked == true)
            {
                cmbGıdatür.Enabled = true;
                cmbGıdatür.Focus();
            }
            else if (chkGıdatür.Checked == false)
            {
                cmbGıdatür.Text = "";
                cmbGıdatür.Enabled = false;


            }
        }

        private void chkGıdagelisyeri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGıdagelisyeri.Checked == true)
            {
                cmbGıdagelisyeri.Enabled = true;
                cmbGıdagelisyeri.Focus();
            }
            else if (chkGıdagelisyeri.Checked == false)
            {
                cmbGıdagelisyeri.Text = "";
                cmbGıdagelisyeri.Enabled = false;


            }
        }

        private void Stoklar_Load_1(object sender, EventArgs e)
        {
            GıdaVeriYukle1();
            GıdaVeriYukle2();
            GıdaVeriYukle3();
            ElektronikVeriYukle1();
            ElektronikVeriYukle2();
            ElektronikVeriYukle3();
            MobilyaVeriYukle1();
            MobilyaVeriYukle2();
            MobilyaVeriYukle3();
        }

        private void btnGıdaAra_Click_1(object sender, EventArgs e)
        {
            GıdaKayitAra();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkElektroTur.Checked == true)
            {
                cmbElektroTur.Enabled = true;
                cmbElektroTur.Focus();
            }
            else if (chkElektroTur.Checked == false)
            {
                cmbElektroTur.Text = "";
                cmbElektroTur.Enabled = false;


            }
        }

        private void chkElektroMarka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElektroMarka.Checked == true)
            {
                cmbElektroMarka.Enabled = true;
                cmbElektroMarka.Focus();
            }
            else if (chkElektroMarka.Checked == false)
            {
                cmbElektroMarka.Text = "";
                cmbElektroMarka.Enabled = false;


            }

        }

        private void chkElektroGelisyeri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkElektroGelisyeri.Checked == true)
            {
                cmbElektroGelisyeri.Enabled = true;
                cmbElektroGelisyeri.Focus();
            }
            else if (chkElektroGelisyeri.Checked == false)
            {
                cmbElektroGelisyeri.Text = "";
                cmbElektroGelisyeri.Enabled = false;


            }
        }

        private void btnElektronikara_Click(object sender, EventArgs e)
        {
            ElektronikKayitAra();
        }

        private void chkMobilyaMarka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMobilyaMarka.Checked == true)
            {
                cmbMobilyaMarka.Enabled = true;
                cmbMobilyaMarka.Focus();
            }
            else if (chkMobilyaMarka.Checked == false)
            {
                cmbMobilyaMarka.Text = "";
                cmbMobilyaMarka.Enabled = false;


            }
        }

        private void chkMobilyaGelisyeri_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMobilyaGelisyeri.Checked == true)
            {
                cmbMobilyaGelisyeri.Enabled = true;
                cmbMobilyaGelisyeri.Focus();
            }
            else if (chkMobilyaGelisyeri.Checked == false)
            {
                cmbMobilyaGelisyeri.Text = "";
                cmbMobilyaGelisyeri.Enabled = false;


            }
        }

        private void chkMobilyaTur_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMobilyaTur.Checked == true)
            {
                cmbMobilyaTur.Enabled = true;
                cmbMobilyaTur.Focus();
            }
            else if (chkMobilyaTur.Checked == false)
            {
                cmbMobilyaTur.Text = "";
                cmbMobilyaTur.Enabled = false;


            }
        }

        private void brnMobilyaAra_Click(object sender, EventArgs e)
        {
            MobilyaKayitAra();
        }

        private void gıdaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GıdaRaporForm frmraporgıda = new GıdaRaporForm();
            frmraporgıda.ShowDialog();
            
        }

        private void elektronikListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElektronikRaporForm frmelektrorapor = new ElektronikRaporForm();
            frmelektrorapor.ShowDialog();
           
        }

        private void mobilyaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MobilyaRaporForm frmmobilyarapor = new MobilyaRaporForm();
            frmmobilyarapor.ShowDialog();
            
        }

        private void radİsim_CheckedChanged(object sender, EventArgs e)
        {
            lblAlananalan.Text = "İsim :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void radGelisYeri_CheckedChanged(object sender, EventArgs e)
        {
            lblAlananalan.Text = "Geliş Yeri :";
            txtAranan.Focus();
            txtAranan.Text = "";
        }

        private void txtAranan_TextChanged(object sender, EventArgs e)
        {
            GıdaHizliAra();
        }

        private void txtAranan2_TextChanged(object sender, EventArgs e)
        {
            ElektronikHizliAra();
        }

        private void radTur_CheckedChanged(object sender, EventArgs e)
        {
            lblAlananalan2.Text = "Tür :";
            txtAranan2.Focus();
            txtAranan2.Text = "";
        }

        private void radMarka_CheckedChanged(object sender, EventArgs e)
        {
            lblAlananalan2.Text = "Marka :";
            txtAranan2.Focus();
            txtAranan2.Text = "";
        }

        private void radMarka2_CheckedChanged(object sender, EventArgs e)
        {
            lblAlananalan3.Text = "Marka :";
            txtAranan3.Focus();
            txtAranan3.Text = "";
        }

        private void radGelisYeri2_CheckedChanged(object sender, EventArgs e)
        {
            lblAlananalan3.Text = "Geliş Yeri :";
            txtAranan3.Focus();
            txtAranan3.Text = "";
        }

        private void txtAranan3_TextChanged(object sender, EventArgs e)
        {
            MobilyaHizliAra();
        }

        private void adetListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GıdaAdetRaporForm frmgıdarapor = new GıdaAdetRaporForm();
            frmgıdarapor.ShowDialog();
        }

        private void fiyatListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElektronikTürRaporForm frmelekrapor = new ElektronikTürRaporForm();
            frmelekrapor.ShowDialog();
        }

        private void markaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MobilyaMarkaRaporForm frmmobilyarapor = new MobilyaMarkaRaporForm();
            frmmobilyarapor.ShowDialog();
        }
    }
}
