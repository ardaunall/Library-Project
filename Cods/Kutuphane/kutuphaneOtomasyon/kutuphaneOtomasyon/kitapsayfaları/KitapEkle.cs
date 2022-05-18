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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void KitapEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();

            MySqlCommand yazar = new MySqlCommand("insert into yazar (ad) values (@ad)", baglanti);
            yazar.Parameters.AddWithValue("@ad", txt_yazar.Text);
            yazar.ExecuteNonQuery();

            MySqlCommand kategori = new MySqlCommand("insert into kategori (kategoritur) values (@tur)", baglanti);
            kategori.Parameters.AddWithValue("@tur", txt_kategori.Text);
            kategori.ExecuteNonQuery();

            MySqlCommand yayin = new MySqlCommand("insert into yayinevi (ad) values (@yayinev)",baglanti);
            yayin.Parameters.AddWithValue("@yayinev", txt_yayinevi.Text);
            yayin.ExecuteNonQuery();

            MySqlCommand konum = new MySqlCommand("insert into konum (kategorikonum) values (@konum)",baglanti);
            konum.Parameters.AddWithValue("@konum", txt_konum.Text);
            konum.ExecuteNonQuery();

            MySqlCommand ekle = new MySqlCommand("insert into kitap (dil,sayfasayisi,yayintarih,ciltsayisi,stok,cevirmen,kitap_ad) values (@dil,@sayfa,@yayin,@cilt,@stok,@cevirmen,@ad)", baglanti);
            ekle.Parameters.AddWithValue("@dil", txt_dil.Text);
            ekle.Parameters.AddWithValue("@sayfa", txt_sayfasayi.Text);
            ekle.Parameters.AddWithValue("@yayin", txt_yayintarih.Text);
            ekle.Parameters.AddWithValue("@cilt", txt_cilt.Text);
            ekle.Parameters.AddWithValue("@stok", txt_stok.Text);
            ekle.Parameters.AddWithValue("@cevirmen", txt_cevirmen.Text);
            ekle.Parameters.AddWithValue("@ad", txt_kitapad.Text);
            ekle.ExecuteNonQuery();

            MessageBox.Show("oldu");
            baglanti.Close();

        }
    }
}
