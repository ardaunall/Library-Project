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
    public partial class analiz : Form
    {
        public analiz()
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

      
        private void label7_Click(object sender, EventArgs e)
        {
            
        }
        #region label listeleme
        private void kitap_sayisi()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand ktpsayi = new MySqlCommand("SELECT SUM(stok) from kitap;", baglanti);
            kitap_sayi.Text = ktpsayi.ExecuteScalar().ToString();
            baglanti.Close();

        }
        private void ogrenci_sayisi()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand ktpsayi = new MySqlCommand("SELECT COUNT(*) FROM ogrenci;", baglanti);
            uye_sayi.Text = ktpsayi.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void yazar_sayisi()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand ktpsayi = new MySqlCommand("SELECT COUNT(*) FROM yazar;", baglanti);
            yazar_say.Text = ktpsayi.ExecuteScalar().ToString();
            baglanti.Close();
        }
        private void kategor_say()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand ktpsayi = new MySqlCommand("SELECT COUNT(*) FROM kategori;", baglanti);
            kate_say.Text = ktpsayi.ExecuteScalar().ToString();
            baglanti.Close();
        }
        #endregion
        private void label8_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();

            MySqlCommand ktp = new MySqlCommand("SELECT COUNT(`id`) FROM `kitap`;", baglanti);
            ktp.ExecuteNonQuery();
            baglanti.Close();
        }

        private void analiz_Load(object sender, EventArgs e)
        {
            kitap_sayisi();
            ogrenci_sayisi();
            yazar_sayisi();
            kategor_say();
            enCokKitap();
            enCokOgr();
            enCokYazar();
            enCokKatg();
        }
        private void enCokKitap()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter ktp = new MySqlDataAdapter("SELECT kitap.kitap_ad ,COUNT(kitap.kitap_ad) FROM emanetkitap INNER JOIN kitap ON emanetkitap.kitap_id = kitap.id GROUP BY emanetkitap.kitap_id ORDER BY COUNT(kitap.kitap_ad) DESC LIMIT 20", baglanti);
            DataTable ktptab = new DataTable();
            ktp.Fill(ktptab);
            dataKitap.DataSource = ktptab;
            baglanti.Close();
            dataKitap.Columns[0].HeaderText = "Kitap Adı";
            dataKitap.Columns[1].HeaderText = "Okunma Sayısı";
        }
        private void enCokOgr()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter ogr = new MySqlDataAdapter("SELECT ogrenci.ogrenci_id,ogrenci.ad,ogrenci.soyad,ogrenci.bolum_ad, COUNT(ogrenci.ogrenci_id) FROM emanetkitap INNER JOIN ogrenci ON emanetkitap.ogrenci_no = ogrenci.ogrenci_id GROUP BY emanetkitap.ogrenci_no LIMIT 20", baglanti);
            DataTable ogrtablo = new DataTable();
            ogr.Fill(ogrtablo);
            dataOgrenci.DataSource = ogrtablo;
            baglanti.Close();
            dataOgrenci.Columns[0].HeaderText = "Öğrenci No";
            dataOgrenci.Columns[1].HeaderText = "Ad";
            dataOgrenci.Columns[2].HeaderText = "Soyad";
            dataOgrenci.Columns[3].HeaderText = "Bölüm";
            dataOgrenci.Columns[4].HeaderText = "Okuduğu Kitap Sayısı";
        }
        private void enCokYazar()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter yzr = new MySqlDataAdapter("SELECT yazar.ad ,COUNT(yazar.ad) FROM emanetkitap INNER JOIN kitap ON emanetkitap.kitap_id = kitap.id INNER JOIN yazar ON kitap.yazar_id = yazar.id GROUP BY emanetkitap.kitap_id ORDER BY COUNT(yazar.ad) DESC LIMIT 20", baglanti);
            DataTable yzrtab = new DataTable();
            yzr.Fill(yzrtab);
            dataYazar.DataSource = yzrtab;
            baglanti.Close();
            dataYazar.Columns[0].HeaderText = "Yazar Adı";
            dataYazar.Columns[1].HeaderText = "Okunma Sayısı";
        }
        private void enCokKatg()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlDataAdapter ktg = new MySqlDataAdapter("SELECT kategori.kategoritur ,COUNT(kategori.kategoritur) FROM emanetkitap INNER JOIN kitap ON emanetkitap.kitap_id = kitap.id INNER JOIN kategori ON kitap.kategori_id = kategori.id GROUP BY emanetkitap.kitap_id ORDER BY COUNT(kategori.kategoritur) DESC LIMIT 20", baglanti);
            DataTable ktgtab = new DataTable();
            ktg.Fill(ktgtab);
            dataKategori.DataSource = ktgtab;
            baglanti.Close();
            dataKategori.Columns[0].HeaderText = "Kategori Adı";
            dataKategori.Columns[1].HeaderText = "Okunma Sayısı";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
