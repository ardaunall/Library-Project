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

        void kitaplistele()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT kitap.kitap_ad,yazar.ad,kategori.kategoritur,yayinevi.ad,konum.kategorikonum,kitap.dil,kitap.sayfasayisi,kitap.yayintarih,kitap.cevirmen,kitap.ciltsayisi,kitap.stok FROM kitap INNER JOIN yazar ON kitap.yazar_id = yazar.id INNER JOIN kategori ON kitap.kategori_id = kategori.id INNER JOIN yayinevi ON kitap.yayinevi_id = yayinevi.id INNER JOIN konum ON kitap.konum_id = konum.id", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public static void kitapAra(string query, DataGridView dgv)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

            string sorgu = query;
            MySqlCommand ogr = new MySqlCommand(sorgu, baglanti);
            MySqlDataAdapter adp = new MySqlDataAdapter(ogr);
            DataTable ogrtbl = new DataTable();
            adp.Fill(ogrtbl);
            dgv.DataSource = ogrtbl;
            baglanti.Close();

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            #region Kitap Listesi
            kitaplistele();
            dataGridView1.Columns[0].HeaderText = "Kitap Adı";
            dataGridView1.Columns[1].HeaderText = "Yazar";
            dataGridView1.Columns[2].HeaderText = "Kategori";
            dataGridView1.Columns[3].HeaderText = "Yayın Evi";
            dataGridView1.Columns[4].HeaderText = "Raf";
            dataGridView1.Columns[5].HeaderText = "Dil";
            dataGridView1.Columns[6].HeaderText = "Sayfa Sayısı";
            dataGridView1.Columns[7].HeaderText = "Yayın Yılı";
            dataGridView1.Columns[8].HeaderText = "Çevirmen";
            dataGridView1.Columns[9].HeaderText = "Cilt Sayısı";
            dataGridView1.Columns[10].HeaderText = "Stok";
            #endregion

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
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
        }

        private void dataGridView1_Sorted(object sender, EventArgs e)
        {

        }

        private void dataGridView1_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
            analiz ac = new analiz();
            ac.Show();
        }

        private void txt_kitapad_TextChanged(object sender, EventArgs e)
        {
            kitapAra("SELECT kitap.kitap_ad,yazar.ad,kategori.kategoritur,yayinevi.ad,konum.kategorikonum,kitap.dil,kitap.sayfasayisi,kitap.yayintarih,kitap.cevirmen,kitap.ciltsayisi,kitap.stok FROM kitap INNER JOIN yazar ON kitap.yazar_id = yazar.id INNER JOIN kategori ON kitap.kategori_id = kategori.id INNER JOIN yayinevi ON kitap.yayinevi_id = yayinevi.id INNER JOIN konum ON kitap.konum_id = konum.id WHERE kitap_ad LIKE '%" + txt_kitapad.Text + "%'", dataGridView1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            kitapAra("SELECT kitap.kitap_ad,yazar.ad,kategori.kategoritur,yayinevi.ad,konum.kategorikonum,kitap.dil,kitap.sayfasayisi,kitap.yayintarih,kitap.cevirmen,kitap.ciltsayisi,kitap.stok FROM kitap INNER JOIN yazar ON kitap.yazar_id = yazar.id INNER JOIN kategori ON kitap.kategori_id = kategori.id INNER JOIN yayinevi ON kitap.yayinevi_id = yayinevi.id INNER JOIN konum ON kitap.konum_id = konum.id WHERE yazar.ad LIKE '%" + txt_yazar.Text + "%'", dataGridView1);
        }

        private void txt_yayin_TextChanged(object sender, EventArgs e)
        {
            kitapAra("SELECT kitap.kitap_ad,yazar.ad,kategori.kategoritur,yayinevi.ad,konum.kategorikonum,kitap.dil,kitap.sayfasayisi,kitap.yayintarih,kitap.cevirmen,kitap.ciltsayisi,kitap.stok FROM kitap INNER JOIN yazar ON kitap.yazar_id = yazar.id INNER JOIN kategori ON kitap.kategori_id = kategori.id INNER JOIN yayinevi ON kitap.yayinevi_id = yayinevi.id INNER JOIN konum ON kitap.konum_id = konum.id WHERE yayinevi.ad LIKE '%" + txt_yayin.Text + "%'", dataGridView1);
        }

        private void txt_kateg_TextChanged(object sender, EventArgs e)
        {
            kitapAra("SELECT kitap.kitap_ad,yazar.ad,kategori.kategoritur,yayinevi.ad,konum.kategorikonum,kitap.dil,kitap.sayfasayisi,kitap.yayintarih,kitap.cevirmen,kitap.ciltsayisi,kitap.stok FROM kitap INNER JOIN yazar ON kitap.yazar_id = yazar.id INNER JOIN kategori ON kitap.kategori_id = kategori.id INNER JOIN yayinevi ON kitap.yayinevi_id = yayinevi.id INNER JOIN konum ON kitap.konum_id = konum.id WHERE kategori.kategoritur LIKE '%" + txt_kateg.Text + "%'", dataGridView1);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Close();
            geciklenler ac = new geciklenler();
            ac.Show();
        }
    }
}
