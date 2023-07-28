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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db_users.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" && txtpassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Kullanıcı adi ve şifre alanları boş", "KAYIT BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtpassword.Text == txtComPassword.Text)
            {
                con.Open();
                string kayitol = "INSERT INTO Kallanıcı (Kullaniciadi,Sifre) VALUES ('" + txtusername.Text + "','" + txtpassword.Text + "')";
                cmd = new OleDbCommand(kayitol, con);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Başarılı Bir Şekilde Kayıt İşlemini Tamamladınız.", "KAYIT TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor Ltfen Tekrar Girin", "KAYIT BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtComPassword.Text = "";
                txtpassword.Focus();
            }
        }

        private void checkbxshowpas_CheckedChanged(object sender, EventArgs e)
        {
            if(checkbxshowpas.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtComPassword.Text = "";
            txtusername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new GirişEkranı().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult deneme = MessageBox.Show("Uygulamadan Çıkış Yapmak\nİstiyor musunuz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == deneme)
            {
                Application.Exit();
            }
        }
    }
}
