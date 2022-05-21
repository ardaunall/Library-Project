using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneOtomasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisYap lgn = new GirisYap();
            lgn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           this.Close();
           studentKayit ogr = new studentKayit();
           ogr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label8.Text = dt.ToShortDateString();
            label9.Text = dt.ToLongTimeString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            studentKayit ac = new studentKayit();
            ac.Show();
        }
    }
}
