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
    public partial class studentKayit : Form
    {
        public studentKayit()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("SERVER=172.21.54.3;DATABASE=ARES;UID=ARES;PWD=Ares895900.");
            baglanti.Open();

            MySqlCommand cmdekle = new MySqlCommand("insert into ogrenci (ogrenci_id,ad,soyad,bolum_ad,email) values (@ogrenci_id,@ad,@soyad,@bolum_ad,@email)", baglanti);
            cmdekle.Parameters.AddWithValue("@ogrenci_id", txt_ogrno.Text);
            cmdekle.Parameters.AddWithValue("@ad", txt_ad.Text);
            cmdekle.Parameters.AddWithValue("@soyad", txt_soyad.Text);
            cmdekle.Parameters.AddWithValue("@bolum_ad", cmb_bolum.Text);
            cmdekle.Parameters.AddWithValue("@email", txt_email.Text);
            

            if (String.IsNullOrEmpty(txt_ogrno.Text) || String.IsNullOrEmpty(txt_ad.Text) || String.IsNullOrEmpty(txt_soyad.Text) || String.IsNullOrEmpty(cmb_bolum.Text) || String.IsNullOrEmpty(txt_email.Text))
            {
                MessageBox.Show("Boş Geçilemez");
            }
            else
            {
                MessageBox.Show("Kayıt Başarılı");

            }
            cmdekle.ExecuteNonQuery();
            baglanti.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa don = new anasayfa();
            don.Show();
        }
    }
}
