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
    public partial class Taşıt : Form
    {
        public Taşıt()
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
                string Sorgu = "Select *from KaraTasit"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "KaraTasit");
                dvgTasit.DataSource = ds.Tables["KaraTasit"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        //hava
        public void KayitListele2()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from HavaTasiti"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "HavaTasiti");
                dvghava.DataSource = ds.Tables["HavaTasiti"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        //Taşıt Marka
        public void TasitVeriYukle3()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Select Marka from KaraTasit";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbKaraMarka.Items.Add(dr["Marka"]);
                }
                Taşıt.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }
        //taşıt model

        public void TasitVeriYukle2()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Select Model from KaraTasit";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbKaraModel.Items.Add(dr["Model"]);
                }
                Taşıt.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }



        //taşıt yakit
        public void TasitVeriYukle1()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Select Yakit from KaraTasit";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbKaraYakıt.Items.Add(dr["Yakit"]);
                }
                Taşıt.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //hava Model

        public void HavaVeriYukle1()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Select Model from HavaTasiti";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbHavaModel.Items.Add(dr["Model"]);
                }
                Taşıt.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //hava renk
        public void HavaVeriYukle2()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Select Renk from HavaTasiti";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbHavaRenk.Items.Add(dr["Renk"]);
                }
                Taşıt.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }

        //hava uretimyili
        public void HavaVeriYukle3()
        {
            try
            {
                Taşıt.BaglantiAc();
                string Sorgu = "Select UretimYili from HavaTasiti";
                OleDbCommand YukleKomut = new OleDbCommand(Sorgu, Taşıt.Baglanti);
                OleDbDataReader dr = YukleKomut.ExecuteReader();
                while (dr.Read())
                {
                    cmbHavaUretimYili.Items.Add(dr["UretimYili"]);
                }
                Taşıt.Baglanti.Close();
            }
            catch (Exception Hata)
            {
                MessageBox.Show(Hata.Message, "Veri Yükleme Hata Penceresi");
            }
        }


        //Hava kayıt

        public void HavaTasitKayitAra2()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguHavaTasitKayitlar = "select * from HavaTasiti";
                string SorguHavaModel = "Select * From HavaTasiti where Model='" + cmbHavaModel.Text + "'";
                string SorguHavaRenk = "Select * From HavaTasiti where Renk='" + cmbHavaRenk.Text + "'";
                string SorguHavaUretimyili = "Select * From HavaTasiti where UretimYili='" + cmbHavaUretimYili.Text + "'";

                string SorguHavaModelRenk = "Select * From HavaTasiti where Model='" + cmbHavaModel.Text + "' And Renk='" + cmbHavaRenk.Text + "'";
                string SorguHavaModelUretimyili = "Select * From HavaTasiti where Model='" + cmbHavaModel.Text + "' And UretimYili='" + cmbHavaUretimYili.Text + "'";
                string SorguHavaRenkUretimyili = "Select * From HavaTasiti where Renk='" + cmbHavaRenk.Text + "' And UretimYili='" + cmbHavaUretimYili.Text + "'";
                string SorguHavaModelRenkUretimyili = "Select * From HavaTasiti where Model='" + cmbHavaModel.Text + "' And Renk='" + cmbHavaRenk.Text + "'  And UretimYili='" + cmbHavaUretimYili.Text + "'";

                if (chkHavaModel.Checked && chkHavaRenk.Checked && chkHavaUretimyili.Checked)
                    SorguHavaTasitKayitlar = SorguHavaModelRenkUretimyili;
                else if (chkHavaModel.Checked && chkHavaRenk.Checked)
                    SorguHavaTasitKayitlar = SorguHavaModelRenk;
                else if (chkHavaModel.Checked && chkHavaUretimyili.Checked)
                    SorguHavaTasitKayitlar = SorguHavaModelUretimyili;
                else if (chkHavaRenk.Checked && chkHavaUretimyili.Checked)
                    SorguHavaTasitKayitlar = SorguHavaRenkUretimyili;
                else if (chkHavaModel.Checked)
                    SorguHavaTasitKayitlar = SorguHavaModel;
                else if (chkHavaRenk.Checked)
                    SorguHavaTasitKayitlar = SorguHavaRenk;
                else if (chkHavaUretimyili.Checked)
                    SorguHavaTasitKayitlar = SorguHavaUretimyili;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguHavaTasitKayitlar, Baglanti);
                da.Fill(ds, "HavaTasiti");
                dvghava.DataSource = ds.Tables["HavaTasiti"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }




        //Taşıt Kayıt ara

        public void KaraTasitKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguKaraTasitKayitlar = "select * from KaraTasit";
                string SorguKaraMarka = "Select * From KaraTasit where Marka='" + cmbKaraMarka.Text + "'";
                string SorguKaraModel = "Select * From KaraTasit where Model='" + cmbKaraModel.Text + "'";
                string SorguKaraYakit = "Select * From KaraTasit where Yakit='" + cmbKaraYakıt.Text + "'";

                string SorguKaraMarkaModel = "Select * From KaraTasit where Marka='" + cmbKaraMarka.Text + "' And Model='" + cmbKaraModel.Text + "'";
                string SorguKaraMarkaYakit = "Select * From KaraTasit where Marka='" + cmbKaraMarka.Text + "' And Yakit='" + cmbKaraYakıt.Text + "'";
                string SorguKaraModelYakit = "Select * From KaraTasit where Model='" + cmbKaraModel.Text + "' And Yakit='" + cmbKaraYakıt.Text + "'";
                string SorguKaraMarkaModelYakit = "Select * From KaraTasit where Marka='" + cmbKaraMarka.Text + "' And Model='" + cmbKaraModel.Text + "'  And Yakit='" + cmbKaraYakıt.Text + "'";

                if (chkKaraMarka.Checked && chkKaraModel.Checked && chkKaraYakıt.Checked)
                    SorguKaraTasitKayitlar = SorguKaraMarkaModelYakit;
                else if (chkKaraMarka.Checked && chkKaraModel.Checked)
                    SorguKaraTasitKayitlar = SorguKaraMarkaModel;
                else if (chkKaraMarka.Checked && chkKaraYakıt.Checked)
                    SorguKaraTasitKayitlar = SorguKaraMarkaYakit;
                else if (chkKaraModel.Checked && chkKaraYakıt.Checked)
                    SorguKaraTasitKayitlar = SorguKaraModelYakit;
                else if (chkKaraMarka.Checked)
                    SorguKaraTasitKayitlar = SorguKaraMarka;
                else if (chkKaraModel.Checked)
                    SorguKaraTasitKayitlar = SorguKaraModel;
                else if (chkKaraYakıt.Checked)
                    SorguKaraTasitKayitlar = SorguKaraYakit;



                OleDbDataAdapter da = new OleDbDataAdapter(SorguKaraTasitKayitlar, Baglanti);
                da.Fill(ds, "KaraTasit");
                dvgTasit.DataSource = ds.Tables["KaraTasit"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Ekrana dönülüyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main frm2 = new main();
            frm2.Show();
            this.Hide();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
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

        private void Taşıt_Load(object sender, EventArgs e)
        {


            

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TasitSil frmsil = new TasitSil();
            frmsil.txtTasitID.Text = dvgTasit.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtPlaka.Text = dvgTasit.CurrentRow.Cells[8].Value.ToString();
            frmsil.txtSasi.Text = dvgTasit.CurrentRow.Cells[11].Value.ToString();



            frmsil.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            TasitGuncelle frmdegistir = new TasitGuncelle();
            frmdegistir.txtID15.Text = dvgTasit.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbMarka.Text = dvgTasit.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.cmbModel.Text = dvgTasit.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.cmbRenk.Text = dvgTasit.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtUretimYili.Text = dvgTasit.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.cmbVites.Text = dvgTasit.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.txtKM.Text = dvgTasit.CurrentRow.Cells[6].Value.ToString();
            frmdegistir.cmbYakit.Text = dvgTasit.CurrentRow.Cells[7].Value.ToString();
            frmdegistir.txtPlaka.Text = dvgTasit.CurrentRow.Cells[8].Value.ToString();
            frmdegistir.txtADeger.Text = dvgTasit.CurrentRow.Cells[9].Value.ToString();
            frmdegistir.txtHgs.Text = dvgTasit.CurrentRow.Cells[10].Value.ToString();
            frmdegistir.txtSasi.Text = dvgTasit.CurrentRow.Cells[11].Value.ToString();
            frmdegistir.txtDHacim.Text = dvgTasit.CurrentRow.Cells[12].Value.ToString();
            frmdegistir.txtRuhsatNo.Text = dvgTasit.CurrentRow.Cells[13].Value.ToString();
            frmdegistir.txtAgirlik.Text = dvgTasit.CurrentRow.Cells[14].Value.ToString();
            frmdegistir.cmbMotorGucu.Text = dvgTasit.CurrentRow.Cells[15].Value.ToString();



            frmdegistir.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            KayitListele2();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            HavaSil frmsil = new HavaSil();
            frmsil.txtID18.Text = dvghava.CurrentRow.Cells[0].Value.ToString();
            frmsil.txtModel.Text = dvghava.CurrentRow.Cells[1].Value.ToString();
            frmsil.txtRenk.Text = dvghava.CurrentRow.Cells[2].Value.ToString();
            frmsil.txtUyil.Text = dvghava.CurrentRow.Cells[3].Value.ToString();



            frmsil.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            HavaGuncelle frmdegistir = new HavaGuncelle();
            frmdegistir.txtID19.Text = dvghava.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbModel.Text = dvghava.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.cmbRenk.Text = dvghava.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtUyili.Text = dvghava.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtDegeri.Text = dvghava.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.txtAgirlik.Text = dvghava.CurrentRow.Cells[5].Value.ToString();

            frmdegistir.Show();
        }

        private void chkKaraMarka_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKaraMarka.Checked == true)
            {
                cmbKaraMarka.Enabled = true;
                cmbKaraMarka.Focus();
            }
            else if (chkKaraMarka.Checked == false)
            {
                cmbKaraMarka.Text = "";
                cmbKaraMarka.Enabled = false;


            }
        }

        private void chkKaraModel_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKaraModel.Checked == true)
            {
                cmbKaraModel.Enabled = true;
                cmbKaraModel.Focus();
            }
            else if (chkKaraModel.Checked == false)
            {
                cmbKaraModel.Text = "";
                cmbKaraModel.Enabled = false;


            }
        }

        private void chkKaraYakıt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKaraYakıt.Checked == true)
            {
                cmbKaraYakıt.Enabled = true;
                cmbKaraYakıt.Focus();
            }
            else if (chkKaraYakıt.Checked == false)
            {
                cmbKaraYakıt.Text = "";
                cmbKaraYakıt.Enabled = false;


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHavaModel.Checked == true)
            {
                cmbHavaModel.Enabled = true;
                cmbHavaModel.Focus();
            }
            else if (chkHavaModel.Checked == false)
            {
                cmbHavaModel.Text = "";
                cmbHavaModel.Enabled = false;


            }
        }

        private void chkHavaRenk_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHavaRenk.Checked == true)
            {
                cmbHavaRenk.Enabled = true;
                cmbHavaRenk.Focus();
            }
            else if (chkHavaRenk.Checked == false)
            {
                cmbHavaRenk.Text = "";
                cmbHavaRenk.Enabled = false;


            }
        }

        private void chkHavaUretimyili_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHavaUretimyili.Checked == true)
            {
                cmbHavaUretimYili.Enabled = true;
                cmbHavaUretimYili.Focus();
            }
            else if (chkHavaUretimyili.Checked == false)
            {
                cmbHavaUretimYili.Text = "";
                cmbHavaUretimYili.Enabled = false;


            }
        }

        private void btnKaraAra_Click(object sender, EventArgs e)
        {
            KaraTasitKayitAra();
        }

        private void Taşıt_Load_1(object sender, EventArgs e)
        {

            HavaVeriYukle1();
            HavaVeriYukle2();
            HavaVeriYukle3();
            TasitVeriYukle3();
            TasitVeriYukle2();
            TasitVeriYukle1();
            
        }

        private void btnHavaAra_Click(object sender, EventArgs e)
        {
            HavaTasitKayitAra2();
        }

        private void tasitListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TasitRaporForm frmtasit = new TasitRaporForm();
            frmtasit.Show();
           
        }

        private void havaTasitListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HavaTasitRaporForm frmhava = new HavaTasitRaporForm();
            frmhava.Show();
           
        }

        private void markaListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TasitMarkaRaporForm frmtasit = new TasitMarkaRaporForm();
            frmtasit.ShowDialog();
        }
    }
}
