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
    public partial class geciklenler : Form
    {
        public geciklenler()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        void EmaListele()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT o.ogrenci_id, o.ad, o.soyad, k.kitap_ad, e.teslimtarih FROM emanetkitap e, ogrenci o, kitap k WHERE e.ogrenci_no = o.ogrenci_id AND k.id = e.kitap_id AND e.teslimtarih<CURRENT_DATE and e.teslimedildi = 'Teslim Edilmedi'", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }

        private void geciklenler_Load(object sender, EventArgs e)
        {
            EmaListele();
            #region Sütun Adları
            dataGridView1.Columns[0].HeaderText = "Öğrenci No";
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Kitap Adı";
            dataGridView1.Columns[4].HeaderText = "Teslim Tarihi";
            #endregion
            
        }
        #region Öğrenci Arama
        public static void ogrenciAra(string query, DataGridView dgv)
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

        private void txt_ograra_TextChanged(object sender, EventArgs e)
        {
            ogrenciAra("SELECT o.ogrenci_id, o.ad, o.soyad, k.kitap_ad, e.teslimtarih FROM emanetkitap e, ogrenci o, kitap k WHERE e.ogrenci_no = o.ogrenci_id AND k.id = e.kitap_id AND e.teslimtarih<CURRENT_DATE and e.teslimedildi = 'Teslim Edilmedi' LIKE '%" + txt_ograra.Text + "%'", dataGridView1);
        }
        #endregion

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
