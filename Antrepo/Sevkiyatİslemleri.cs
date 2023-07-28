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
    public partial class Sevkiyatİslemleri : Form
    {
        public Sevkiyatİslemleri()
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
                string Sorgu = "Select *from Yurticisevkiyat"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "Yurticisevkiyat");
                dvgSevkiyat.DataSource = ds.Tables["Yurticisevkiyat"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        public void KayitListele2()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();   //Dataset tanımla
                string Sorgu = "Select *from YurtDisisevkiyat"; //Sql Komutunu yaz
                OleDbDataAdapter da = new OleDbDataAdapter(Sorgu, Baglanti);
                da.Fill(ds, "YurtDisisevkiyat");
                dvgSevkiyat.DataSource = ds.Tables["YurtDisisevkiyat"]; //Personel tablosunu formda gösterdik
                Baglanti.Close();

            }
            catch (Exception Hata)
            {

                MessageBox.Show(Hata.Message, "Kayıt Listele Hata Penceresi");
            }
        }

        //yi kayıt arama

        public void ÇFisiKayitAra()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguÇfisiKayitlar = "select * from Yurticisevkiyat";
                string SorguCAlici = "Select * From Yurticisevkiyat where GondermeTarihi='" + txtYiTarihAra.Text + "'";
                string SorguCCins = "Select * From Yurticisevkiyat where Tasit='" + cmbYiTaşit.Text + "'";
                

                string SorguCAliciCins = "Select * From Yurticisevkiyat where GondermeTarihi='" + txtYiTarihAra.Text + "' And Tasit='" + cmbYiTaşit.Text + "'";

               
                if (chkYiTarih.Checked && chkYiTasit.Checked)
                    SorguÇfisiKayitlar = SorguCAliciCins;
                else if (chkYiTarih.Checked)
                    SorguÇfisiKayitlar = SorguCAlici;
                else if (chkYiTasit.Checked)
                    SorguÇfisiKayitlar = SorguCCins;
                



                OleDbDataAdapter da = new OleDbDataAdapter(SorguÇfisiKayitlar, Baglanti);
                da.Fill(ds, "Yurticisevkiyat");
                dvgSevkiyat.DataSource = ds.Tables["Yurticisevkiyat"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        //yiçi kayıt arama

        public void ÇFisiKayitAra2()
        {
            try
            {
                BaglantiAc();
                DataSet ds = new DataSet();
                string SorguÇfisiKayitlar2 = "select * from YurtDisisevkiyat";
                string SorguCAlici2 = "Select * From YurtDisisevkiyat where GidecekMalzeme='" + cmbYDMalzeme.Text + "'";
                string SorguCCins2 = "Select * From YurtDisisevkiyat where GonderilenYerı='" + cmbYDGYer.Text + "'";


                string SorguCAliciCins = "Select * From YurtDisisevkiyat where GidecekMalzeme='" + cmbYDMalzeme.Text + "' And GonderilenYerı='" + cmbYDGYer.Text + "'";


                if (chkYDMalzeme.Checked && chkYDGYer.Checked)
                    SorguÇfisiKayitlar2 = SorguCAliciCins;
                else if (chkYDMalzeme.Checked)
                    SorguÇfisiKayitlar2 = SorguCAlici2;
                else if (chkYDGYer.Checked)
                    SorguÇfisiKayitlar2 = SorguCCins2;




                OleDbDataAdapter da = new OleDbDataAdapter(SorguÇfisiKayitlar2, Baglanti);
                da.Fill(ds, "YurtDisisevkiyat");
                dvgSevkiyat.DataSource = ds.Tables["YurtDisisevkiyat"];
                Baglanti.Close();
            }
            catch (Exception Hata)
            {
                //Sistem Hata Mesajını Göster
                MessageBox.Show(Hata.Message, "Kayıt Arama Hata Penceresi");
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            KayitListele();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Ekrana dönülüyor.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            main frm2 = new main();
            frm2.Show();
            this.Hide();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
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

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            KayitListele2();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

            {
                YurtiçiSevkiyatSil frmsil2 = new YurtiçiSevkiyatSil();
                frmsil2.txtYID.Text = dvgSevkiyat.CurrentRow.Cells[0].Value.ToString();
                frmsil2.txtYMalzeme.Text = dvgSevkiyat.CurrentRow.Cells[1].Value.ToString();
                frmsil2.txtYTasit.Text = dvgSevkiyat.CurrentRow.Cells[5].Value.ToString();



                frmsil2.ShowDialog();
            }
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YurtiçiSevkiyatGuncelle frmdegistir = new YurtiçiSevkiyatGuncelle();
            frmdegistir.txtYGID.Text = dvgSevkiyat.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbMalzeme.Text = dvgSevkiyat.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtAdet.Text = dvgSevkiyat.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtYfiyat.Text = dvgSevkiyat.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtGTarihi.Text = dvgSevkiyat.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.cmbTasit.Text = dvgSevkiyat.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.cmbGyer.Text = dvgSevkiyat.CurrentRow.Cells[6].Value.ToString();


            frmdegistir.ShowDialog();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YurtdışıSevkiyatGüncelle frmdegistir = new YurtdışıSevkiyatGüncelle();
            frmdegistir.txtYGID.Text = dvgSevkiyat.CurrentRow.Cells[0].Value.ToString();
            frmdegistir.cmbMalzeme.Text = dvgSevkiyat.CurrentRow.Cells[1].Value.ToString();
            frmdegistir.txtAdet.Text = dvgSevkiyat.CurrentRow.Cells[2].Value.ToString();
            frmdegistir.txtYfiyat.Text = dvgSevkiyat.CurrentRow.Cells[3].Value.ToString();
            frmdegistir.txtGTarihi.Text = dvgSevkiyat.CurrentRow.Cells[4].Value.ToString();
            frmdegistir.cmbTasit.Text = dvgSevkiyat.CurrentRow.Cells[5].Value.ToString();
            frmdegistir.cmbGyer.Text = dvgSevkiyat.CurrentRow.Cells[6].Value.ToString();


            frmdegistir.ShowDialog();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            YurtdışıSevkiyatSil frmsil2 = new YurtdışıSevkiyatSil();
            frmsil2.txtYID.Text = dvgSevkiyat.CurrentRow.Cells[0].Value.ToString();
            frmsil2.txtYMalzeme.Text = dvgSevkiyat.CurrentRow.Cells[1].Value.ToString();
            frmsil2.txtYTasit.Text = dvgSevkiyat.CurrentRow.Cells[5].Value.ToString();



            frmsil2.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void yuriçiListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YurticiRaporForm frmyurticiRapor = new YurticiRaporForm();
            frmyurticiRapor.ShowDialog();

        }

        private void yurtdışıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YurtdisiRaporForm frmYurtdisiRapor = new YurtdisiRaporForm();
            frmYurtdisiRapor.ShowDialog();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void chkYiTasit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYiTasit.Checked == true)
            {
                cmbYiTaşit.Enabled = true;
                cmbYiTaşit.Focus();
            }
            else if (chkYiTasit.Checked == false)
            {
                cmbYiTaşit.Text = "";
                cmbYiTaşit.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÇFisiKayitAra();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

          
        }

        private void chkYDGYer_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÇFisiKayitAra2();
        }

        private void chkYiTarih_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYiTarih.Checked == true)
            {
                txtYiTarihAra.Enabled = true;
                txtYiTarihAra.Focus();
            }
            else if (chkYiTarih.Checked == false)
            {
                txtYiTarihAra.Text = "";
                txtYiTarihAra.Enabled = false;
            }
        }

        private void chkYiTasit_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkYiTasit.Checked == true)
            {
                cmbYiTaşit.Enabled = true;
                cmbYiTaşit.Focus();
            }
            else if (chkYiTasit.Checked == false)
            {
                cmbYiTaşit.Text = "";
                cmbYiTaşit.Enabled = false;
            }
        }

        private void chkYDGYer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkYDGYer.Checked == true)
            {
                cmbYDGYer.Enabled = true;
                cmbYDGYer.Focus();
            }
            else if (chkYDGYer.Checked == false)
            {
                cmbYDGYer.Text = "";
                cmbYDGYer.Enabled = false;


            }
        }

        private void chkYDMalzeme_CheckedChanged(object sender, EventArgs e)
        {
            if (chkYDMalzeme.Checked == true)
            {
                cmbYDMalzeme.Enabled = true;
                cmbYDMalzeme.Focus();
            }
            else if (chkYDMalzeme.Checked == false)
            {
                cmbYDMalzeme.Text = "";
                cmbYDMalzeme.Enabled = false;


            }
        }
    }   

}
