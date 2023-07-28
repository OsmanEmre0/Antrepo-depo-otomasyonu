using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Antrepo
{
    public partial class Tanımlama : Form
    {
        public Tanımlama()
        {
            InitializeComponent();
        }

        private void anaEkranToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GıdaEkle frm4 = new GıdaEkle();
            frm4.Show();
            this.Hide();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ElektronikEkle frmElektronik = new ElektronikEkle();
            frmElektronik.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MobilyaEkle frmMobilya = new MobilyaEkle();
            frmMobilya.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PersonelEkle frmPersonel = new PersonelEkle();
            frmPersonel.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            TaşıtEkle frmTasit = new TaşıtEkle();
            frmTasit.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            UyeEkle frmUye = new UyeEkle();
            frmUye.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            GirisFisiEkle frmgir = new GirisFisiEkle();
            frmgir.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            CikisFisiEkle frmcıkıs = new CikisFisiEkle();
            frmcıkıs.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            HavaEkle havaEkle = new HavaEkle();
            havaEkle.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            YurtiçiSevkiyatEkle frmyekle = new YurtiçiSevkiyatEkle();
            frmyekle.Show();
            this.Hide();
        }

        private void ekleToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            YurtDışıSevkiyatEkle frmeklerapor = new YurtDışıSevkiyatEkle();
            frmeklerapor.Show();
            this.Hide();
        }
    }
}
