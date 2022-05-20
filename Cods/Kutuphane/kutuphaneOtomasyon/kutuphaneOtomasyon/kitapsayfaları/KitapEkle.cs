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

            string conString = "SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.";
            #region Yazar Listeleme
            using (var baglanti  = new MySqlConnection(conString))
            {
                using (var command = new MySqlCommand("SELECT ad FROM yazar ORDER BY ad ASC", baglanti))
                {
                    try
                    {
                        command.Connection.Open();
                        MySqlDataReader yz = command.ExecuteReader();
                        while (yz.Read())
                        {
                            comboYazar.Items.Add(yz["ad"]).ToString();

                        }
                        comboYazar.SelectedIndex = 0;

                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show($"{hata}");
                    }
                }
            }
            #endregion
            #region Kategori Listeleme
            using (var baglanti = new MySqlConnection(conString))
            {
                using (var command = new MySqlCommand("SELECT kategoritur FROM kategori ORDER BY kategoritur ASC", baglanti))
                {
                    try
                    {
                        command.Connection.Open();
                        MySqlDataReader ktg = command.ExecuteReader();
                        while (ktg.Read())
                        {
                            comboKategori.Items.Add(ktg["kategoritur"]).ToString();

                        }
                        comboKategori.SelectedIndex = 0;

                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show($"{hata}");
                    }
                }
            }
            #endregion
            #region Yayın Evi Listeleme
            using (var baglanti = new MySqlConnection(conString))
            {
                using (var command = new MySqlCommand("SELECT ad FROM yayinevi ORDER BY ad ASC", baglanti))
                {
                    try
                    {
                        command.Connection.Open();
                        MySqlDataReader yayn = command.ExecuteReader();
                        while (yayn.Read())
                        {
                            comboYayin.Items.Add(yayn["ad"]).ToString();

                        }
                        comboYayin.SelectedIndex = 0;

                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show($"{hata}");
                    }
                }
            }
            #endregion
            #region Konum Listeleme
            using (var baglanti = new MySqlConnection(conString))
            {
                using (var command = new MySqlCommand("SELECT kategorikonum FROM konum ORDER BY kategorikonum ASC", baglanti))
                {
                    try
                    {
                        command.Connection.Open();
                        MySqlDataReader knm = command.ExecuteReader();
                        while (knm.Read())
                        {
                            comboRaf.Items.Add(knm["kategorikonum"]).ToString();

                        }
                        comboRaf.SelectedIndex = 0;

                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show($"{hata}");
                    }
                }
            }
            #endregion
        }
        private MySqlConnection getConnection()
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            return baglanti;
        }
        #region Kitap Ekleme
        private int getLastInsertedId(MySqlConnection baglanti)
        {
            MySqlCommand lastInsertedIdCmd = new MySqlCommand("SELECT LAST_INSERT_ID();", baglanti);
            var lastInsertedIdValue = lastInsertedIdCmd.ExecuteScalar().ToString();
            return int.Parse(lastInsertedIdValue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = getConnection();

            MySqlCommand yazar = new MySqlCommand("insert into yazar (ad) values (@ad)", baglanti);
            yazar.Parameters.AddWithValue("@ad", txt_yazar.Text);
            yazar.ExecuteNonQuery();
            int lastInsertedYazarIdValue = getLastInsertedId(baglanti);

            MySqlCommand kategori = new MySqlCommand("insert into kategori (kategoritur) values (@tur)", baglanti);
            kategori.Parameters.AddWithValue("@tur", txt_kategori.Text);
            kategori.ExecuteNonQuery();
            int lastInsertedKategoriId = getLastInsertedId(baglanti);

            MySqlCommand yayin = new MySqlCommand("insert into yayinevi (ad) values (@yayinev)",baglanti);
            yayin.Parameters.AddWithValue("@yayinev", txt_yayinevi.Text);
            yayin.ExecuteNonQuery();
            int lastInsertedYayinEviId = getLastInsertedId(baglanti);


            MySqlCommand konum = new MySqlCommand("insert into konum (kategorikonum) values (@konum)",baglanti);
            konum.Parameters.AddWithValue("@konum", txt_konum.Text);
            konum.ExecuteNonQuery();
            int lastInsertedKategoriKonumId = getLastInsertedId(baglanti);            

            MySqlCommand ekle = new MySqlCommand("insert into kitap (yazar_id,kategori_id,yayinevi_id,konum_id,dil,sayfasayisi,yayintarih,ciltsayisi,stok,cevirmen,kitap_ad) values (@yazarId,@kategoriId,@yayinEviId,@konumId,@dil,@sayfa,@yayin,@cilt,@stok,@cevirmen,@ad)", baglanti);
            ekle.Parameters.AddWithValue("@yazarId", lastInsertedYazarIdValue);
            ekle.Parameters.AddWithValue("@kategoriId", lastInsertedKategoriId);
            ekle.Parameters.AddWithValue("@yayinEviId", lastInsertedYayinEviId);
            ekle.Parameters.AddWithValue("@konumId", lastInsertedKategoriKonumId);
            ekle.Parameters.AddWithValue("@dil", txt_dil.Text);
            ekle.Parameters.AddWithValue("@sayfa", txt_sayfasayi.Text);
            ekle.Parameters.AddWithValue("@yayin", txt_yayintarih.Text);
            ekle.Parameters.AddWithValue("@cilt", txt_cilt.Text);
            ekle.Parameters.AddWithValue("@stok", txt_stok.Text);
            ekle.Parameters.AddWithValue("@cevirmen", txt_cevirmen.Text);
            ekle.Parameters.AddWithValue("@ad", txt_kitapad.Text);

            if (String.IsNullOrEmpty(txt_dil.Text) || String.IsNullOrEmpty(txt_sayfasayi.Text) || String.IsNullOrEmpty(txt_yayintarih.Text) || String.IsNullOrEmpty(txt_cilt.Text) || String.IsNullOrEmpty(txt_stok.Text) || String.IsNullOrEmpty(txt_cevirmen.Text) || String.IsNullOrEmpty(txt_kitapad.Text) ||)
            {
                MessageBox.Show("Alanlar Boş Geçilemez"); 
            }
            else
            {
                ekle.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı");
            }
            baglanti.Close();

        }
        #endregion
    }
}
