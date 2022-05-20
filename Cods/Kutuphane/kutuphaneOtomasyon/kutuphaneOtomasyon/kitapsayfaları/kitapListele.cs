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
    public partial class kitapListele : Form
    {
        public kitapListele()
        {
            InitializeComponent();
        }

        private void kitapListele_Load(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
        }
        public static void displayAndSearch(string query, DataGridView dgv)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

            string sql = query;
            MySqlCommand cmd = new MySqlCommand(sql, baglanti);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            baglanti.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            displayAndSearch("SELECT id,kitap_ad,yazar_id,kategori_id,yayinevi_id,konum_id,dil,sayfasayisi,yayintarih,ciltsayisi,stok,cevirmen FROM kitap WHERE kitap_ad LIKE '%" + textBox1.Text + "%'", dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            KitapEkle ac = new KitapEkle();
            ac.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            KitapEkle ac = new KitapEkle();
            ac.Show();
        }
    }

}
