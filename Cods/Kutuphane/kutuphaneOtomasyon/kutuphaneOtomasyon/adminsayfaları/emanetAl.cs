using MySql.Data.MySqlClient;
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
    public partial class Emanet : Form
    {
        public Emanet()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa ac = new anasayfa();
            ac.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand("insert into emanetkitap(ogrenci_id,kitap_ad,emanet_tarih,teslimtarih) values (@ogrno,@ad,@emanet,@teslim)", baglanti);
            komut.Parameters.AddWithValue("@ogrno",txt_ogr);
            komut.Parameters.AddWithValue("@ad",txt_kitap);
            komut.Parameters.AddWithValue("@emanet", dateTimePicker1);
            komut.Parameters.AddWithValue("@teslim", dateTimePicker2);
            if (String.IsNullOrEmpty(txt_ogr.Text) || String.IsNullOrEmpty(txt_kitap.Text))
            {
                MessageBox.Show("Boş Geçilemez");
            }
            else
            {
                komut.ExecuteNonQuery();
                MessageBox.Show("Emanet Kaydı Oluştruldu");
            }
            baglanti.Close();
        }

        private void Emanet_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
