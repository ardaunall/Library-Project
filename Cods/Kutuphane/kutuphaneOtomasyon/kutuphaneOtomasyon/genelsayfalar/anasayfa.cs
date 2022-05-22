using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kutuphaneOtomasyon
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
        DataSet daset = new DataSet();

        private void kitaplistele()
        {
            baglanti.Open();
            MySqlDataAdapter adtr = new MySqlDataAdapter("select kitap_ad'Kitap Adı',yazar_id'Yazar Adı',kategori_id'Kategori',yayinevi_id'Yayın Evi',konum_id'Raf',dil'Dil',sayfasayisi'Sayfa Sayısı',yayintarih'Yayın Tarihi',ciltsayisi'Cilt Sayısı',stok'Stok',cevirmen'Çevirmen' from kitap",baglanti);
            adtr.Fill(daset,"kitap");
            dataGridView1.DataSource = daset.Tables["kitap"];
            baglanti.Close();
        }
        public static void displayAndSearch(string query, DataGridView dgv)
        {
            /*MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

            string sql = query;
            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            baglanti.Close();*/
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //displayAndSearch("SELECT kitap_ad AS Kitap,yazar_id,kategori_id,yayinevi_id,konum_id,dil,sayfasayisi,yayintarih,ciltsayisi,stok,cevirmen FROM kitap WHERE kitap_ad LIKE '%" + textBox1.Text + "%'", dataGridView1);
        }
        private void cikis_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            kitaplistele();
        }
        #region Butonlar
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

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            KitapEkle ac = new KitapEkle();
            ac.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Emanet ac = new Emanet();
            ac.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisYap ac = new GirisYap();
            ac.Show();
        }
        #endregion
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
